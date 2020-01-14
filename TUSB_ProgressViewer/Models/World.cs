using OrangeNBT.World.Anvil;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUSB_ProgressViewer.Util;

namespace TUSB_ProgressViewer.Models
{
    /// <summary>
    /// Minecraftワールド
    /// </summary>
    public static class World
    {
        /// <summary>
        /// ワールドパス
        /// </summary>
        public static string Path { get; private set; }

        /// <summary>
        /// ワールドデータ
        /// </summary>
        public static AnvilWorld WorldData { get; set; }

        /// <summary>
        /// 島リスト
        /// </summary>
        public static ReactiveCollection<Island> Islands { get; set; } = new ReactiveCollection<Island>();

        /// <summary>
        /// 島攻略数カウント
        /// </summary>
        public static ReactiveProperty<int> CompleteCount { get; } = new ReactiveProperty<int>();

        /// <summary>
        /// ワールド読み込み
        /// </summary>
        /// <param name="path">ワールドパス</param>
        public static void Load(string path)
        {
            Path = path;

            WorldData = AnvilWorld.Load(path);
            Islands.Clear();
            foreach (IslandType type in Enum.GetValues(typeof(IslandType)))
            {
                Islands.Add(new Island(type, WorldData));
            }
            CompleteCount.Value = Islands.Where(x => x.IsComplete).Count();
        }
    }
}
