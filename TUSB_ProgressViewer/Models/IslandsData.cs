using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TUSB_ProgressViewer.Controls;
using TUSB_ProgressViewer.Util;

namespace TUSB_ProgressViewer.Models
{
    public static class IslandsData
    {
        /// <summary>
        /// 島リスト
        /// </summary>
        public static ReactiveCollection<IslandPointer> Islands { get; } = new ReactiveCollection<IslandPointer>();

        /// <summary>
        /// 島攻略数カウント
        /// </summary>
        public static ReactiveProperty<int> CompletionCount { get; } = new ReactiveProperty<int>();

        /// <summary>
        /// 島攻略率
        /// </summary>
        public static ReactiveProperty<double> CompletionRate { get; } = new ReactiveProperty<double>();

        /// <summary>
        /// 島の数
        /// </summary>
        private const int islandCount = 50;

        /// <summary>
        /// 島読み込み
        /// </summary>
        /// <param name="count"></param>
        public static void Load(ref int count)
        {
            try
            {
                Islands.ClearOnScheduler();
                foreach (IslandType type in Enum.GetValues(typeof(IslandType)))
                {
                    var island = new Island(type, World.WorldData);

                    // 実際の座標と画像のピクセル数から画像上の島(エンドポータルフレーム)の位置を計算
                    // 画像のサイズが変わると壊れます()
                    var X = (island.IslandType.GetCoordinate().X + 221) / 512.0;
                    var Z = (island.IslandType.GetCoordinate().Z + 237) / 512.0;

                    // 別ディメンションは特殊な位置なので個別指定
                    switch (island.IslandType)
                    {
                        case IslandType.TheUnderworld:
                            X = 47 / 256.0;
                            Z = 234 / 256.0;
                            break;
                        case IslandType.TheNether:
                            X = 128 / 256.0;
                            Z = 234 / 256.0;
                            break;
                        case IslandType.GulliversLand:
                            X = 183 / 256.0;
                            Z = 234 / 256.0;
                            break;
                        case IslandType.Cloudia:
                            X = 43 / 256.0;
                            Z = 246 / 256.0;
                            break;
                        case IslandType.TableMountain:
                            X = 82 / 256.0;
                            Z = 246 / 256.0;
                            break;
                        case IslandType.TocultColde:
                            X = 157 / 256.0;
                            Z = 246 / 256.0;
                            break;
                        case IslandType.TheEnd:
                            X = 218 / 256.0;
                            Z = 246 / 256.0;
                            break;
                    }
                    
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        Islands.Add(new IslandPointer()
                        {
                            IslandName = island.IslandType.GetName(),
                            Center = new Point(X, Z),
                            IsComplete = island.IsComplete
                        });

                        CompletionCount.Value = Islands.Where(x => x.IsComplete).Count();
                        CompletionRate.Value = (CompletionCount.Value / (double)islandCount) * 100;
                    });

                    World.LoadingProgress.Value = (++count / 297.0) * 100;
                }
            }
            catch
            {
                Reset();
                throw;
            }
        }

        /// <summary>
        /// データをリセット
        /// </summary>
        public static void Reset()
        {
            Islands.ClearOnScheduler();
            CompletionCount.Value = 0;
            CompletionRate.Value = 0;
        }
    }
}
