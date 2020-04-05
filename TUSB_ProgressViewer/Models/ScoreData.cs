using OrangeNBT.NBT;
using OrangeNBT.NBT.IO;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TUSB_ProgressViewer.Models
{
    public static class ScoreData
    {
        /// <summary>
        /// プレイヤーデータのリスト
        /// </summary>
        public static ReactiveCollection<Player> Players { get; } = new ReactiveCollection<Player>();

        /// <summary>
        /// プレイヤーの数
        /// </summary>
        public static ReactiveProperty<int> PlayerCount { get; } = new ReactiveProperty<int>();

        /// <summary>
        /// スコアデータ読み込み
        /// </summary>
        public static void Load()
        {
            var data = NBTFile.FromFile($@"{World.Path.Value}\data\scoreboard.dat")["data"] as TagCompound;
            var PlayerScores = data["PlayerScores"] as TagList;

            // 複数のスコアオブジェクトを持っているエンティティ名を抽出
            // #100を除いてユーザー名だと思われる
            // ソースは俺
            var users = PlayerScores.Value
                .Select(x => ((x as TagCompound)["Name"] as TagString).Value)
                .GroupBy(x => x)
                .Where(x => x.Count() > 1)
                .Select(x => x.Key)
                .Where(x => x != "#100")
                .ToList();

            var list = PlayerScores.Value
                .Where(x => users.Contains(((x as TagCompound)["Name"] as TagString).Value))
                .GroupBy(x => ((x as TagCompound)["Name"] as TagString).Value)
                .ToList();

            foreach (var user in list)
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    var userData = new Player(user.Key);
                    Players.Add(userData);
                    PlayerCount.Value++;

                    foreach (var tag in user)
                    {
                        var name = ((tag as TagCompound)["Objective"] as TagString).Value;
                        var value = ((tag as TagCompound)["Score"] as TagInt).Value;
                        if (name == "KnightLevel") userData.KnightLevel = value;
                        if (name == "NinjaLevel") userData.NinjaLevel = value;
                        if (name == "ArcherLevel") userData.ArcherLevel = value;
                        if (name == "WhiteMageLevel") userData.WhiteMageLevel = value;
                        if (name == "BlackMageLevel") userData.BlackMageLevel = value;
                        if (name == "SummonerLevel") userData.SummonerLevel = value;
                    }
                });
            }
        }

        /// <summary>
        /// データをリセット
        /// </summary>
        public static void Reset()
        {
            Players.ClearOnScheduler();
            PlayerCount.Value = 0;
        }
    }
}
