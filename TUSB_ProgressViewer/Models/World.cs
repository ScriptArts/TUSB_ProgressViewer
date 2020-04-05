using OrangeNBT.NBT;
using OrangeNBT.NBT.IO;
using OrangeNBT.World.Anvil;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
        public static ReactiveProperty<string> Path { get; } = new ReactiveProperty<string>();

        /// <summary>
        /// ワールドフォルダ名
        /// </summary>
        public static ReactiveProperty<string> FolderName { get; } = new ReactiveProperty<string>();

        /// <summary>
        /// ワールドデータ
        /// </summary>
        public static AnvilWorld WorldData { get; set; }

        /// <summary>
        /// 読み込み進捗
        /// </summary>
        public static ReactiveProperty<double> LoadingProgress { get; } = new ReactiveProperty<double>();

        /// <summary>
        /// 読込中フラグ
        /// </summary>
        public static ReactiveProperty<bool> IsLoading { get; } = new ReactiveProperty<bool>();

        /// <summary>
        /// エラーフラグ
        /// </summary>
        public static ReactiveProperty<bool> IsError { get; } = new ReactiveProperty<bool>();

        /// <summary>
        /// ワールド読み込み
        /// </summary>
        /// <param name="path">ワールドパス</param>
        public static void Load(string path)
        {
            if (IsLoading.Value) return;

            IslandsData.Reset();
            SpawnersData.Reset();
            ScoreData.Reset();

            FolderName.Value = System.IO.Path.GetFileName(path);
            IsLoading.Value = true;
            LoadingProgress.Value = 0;
            Path.Value = path;

            var count = 0;

            Task.Run(() =>
            {
                try
                {
                    WorldData = AnvilWorld.Load(path);

                    IslandsData.Load(ref count);
                    SpawnersData.Load(ref count);
                    ScoreData.Load();

                    // 100%を見せたいからという理由だけで0.3秒遅延させる
                    System.Threading.Thread.Sleep(300);
                }
                catch
                {
                    Path.Value = null;
                    IsError.Value = true;
                }
                finally
                {
                    IsLoading.Value = false;
                }
            });
        }

        /// <summary>
        /// ワールドを再読み込み
        /// </summary>
        public static void Reload()
        {
            Load(Path.Value);
        }
    }
}
