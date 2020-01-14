using OrangeNBT.World.Anvil;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUSB_ProgressViewer.Util;

namespace TUSB_ProgressViewer.Models
{
    /// <summary>
    /// 島
    /// </summary>
    public class Island: BindableBase
    {
        /// <summary>
        /// 島のデータ
        /// </summary>
        public IslandData Data { get; }

        /// <summary>
        /// 攻略フラグ
        /// </summary>
        public bool IsComplete { get; }

        /// <summary>
        /// 選択フラグ
        /// </summary>
        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }
        private bool _isSelected;

        public Island(IslandType type, AnvilWorld world)
        {
            switch (type)
            {
                case IslandType.Ghast:
                    Data = new IslandData("ガスト島"                            , IslandDimension.Overworld, new Coordinate(8, 25, 67));
                    break;
                case IslandType.Wasteland:
                    Data = new IslandData("荒れ地島"                            , IslandDimension.Overworld, new Coordinate(-13, 1, 23));
                    break;
                case IslandType.SilverfishAndEndermite:
                    Data = new IslandData("シルバーフィッシュ＆エンダーマイト島", IslandDimension.Overworld, new Coordinate(35, 8, -24));
                    break;
                case IslandType.Mountains:
                    Data = new IslandData("山岳島"                              , IslandDimension.Overworld, new Coordinate(59, 1, -47));
                    break;
                case IslandType.Trade:
                    Data = new IslandData("交易島"                              , IslandDimension.Overworld, new Coordinate(-70, 15, 32));
                    break;
                case IslandType.Clock:
                    Data = new IslandData("時計島"                              , IslandDimension.Overworld, new Coordinate(55, 13, 16));
                    break;
                case IslandType.LumpOfSand:
                    Data = new IslandData("砂塊島"                              , IslandDimension.Overworld, new Coordinate(-98, 23, 7));
                    break;
                case IslandType.Lighthouse:
                    Data = new IslandData("灯台島"                              , IslandDimension.Overworld, new Coordinate(-60, 44, -22));
                    break;
                case IslandType.FormerThreat:
                    Data = new IslandData("かつての脅威島"                      , IslandDimension.Overworld, new Coordinate(39, 6, 68));
                    break;
                case IslandType.Graveyard:
                    Data = new IslandData("墓場島"                              , IslandDimension.Overworld, new Coordinate(16, 12, -61));
                    break;
                case IslandType.GovernTheNight:
                    Data = new IslandData("夜を司る島"                          , IslandDimension.Overworld, new Coordinate(3, 77, 87));
                    break;
                case IslandType.Creeper:
                    Data = new IslandData("匠島"                                , IslandDimension.Overworld, new Coordinate(19, 63, -38));
                    break;
                case IslandType.Squid:
                    Data = new IslandData("イカ島"                              , IslandDimension.Overworld, new Coordinate(-38, 85, 69));
                    break;
                case IslandType.Pumpkin:
                    Data = new IslandData("カボチャ島"                          , IslandDimension.Overworld, new Coordinate(39, 78, 28));
                    break;
                case IslandType.BurningLove:
                    Data = new IslandData("燃える愛の島"                        , IslandDimension.Overworld, new Coordinate(-3, 69, -8));
                    break;
                case IslandType.Furnace:
                    Data = new IslandData("かまど島"                            , IslandDimension.Overworld, new Coordinate(103, 20, -104));
                    break;
                case IslandType.Oasis:
                    Data = new IslandData("オアシス島"                          , IslandDimension.Overworld, new Coordinate(-105, 13, -80));
                    break;
                case IslandType.ObsidianTower:
                    Data = new IslandData("黒曜石の塔の島"                      , IslandDimension.Overworld, new Coordinate(82, 12, -19));
                    break;
                case IslandType.Steve:
                    Data = new IslandData("スティーブ島"                        , IslandDimension.Overworld, new Coordinate(-43, 60, -54));
                    break;
                case IslandType.Spider:
                    Data = new IslandData("蜘蛛島"                              , IslandDimension.Overworld, new Coordinate(107, 36, 53));
                    break;
                case IslandType.Smilingly:
                    Data = new IslandData("ニコニコ島"                          , IslandDimension.Overworld, new Coordinate(114, 44, 3));
                    break;
                case IslandType.Cake:
                    Data = new IslandData("ケーキ島"                            , IslandDimension.Overworld, new Coordinate(104, 127, -21));
                    break;
                case IslandType.Cactus:
                    Data = new IslandData("サボテン島"                          , IslandDimension.Overworld, new Coordinate(158, 16, 15));
                    break;
                case IslandType.Slime:
                    Data = new IslandData("スライム島"                          , IslandDimension.Overworld, new Coordinate(187, 31, 62));
                    break;
                case IslandType.CauldronAndHopper:
                    Data = new IslandData("大釜＆ホッパー島"                    , IslandDimension.Overworld, new Coordinate(178, 19, -76));
                    break;
                case IslandType.Workbench:
                    Data = new IslandData("作業台島"                            , IslandDimension.Overworld, new Coordinate(-56, 61, -113));
                    break;
                case IslandType.Enderman:
                    Data = new IslandData("エンダーマン島"                      , IslandDimension.Overworld, new Coordinate(84, 112, 99));
                    break;
                case IslandType.EnderChest:
                    Data = new IslandData("エンダーチェスト島"                  , IslandDimension.Overworld, new Coordinate(86, 110, -94));
                    break;
                case IslandType.Skeleton:
                    Data = new IslandData("スケルトン島"                        , IslandDimension.Overworld, new Coordinate(116, 128, 35));
                    break;
                case IslandType.RaggedHouse:
                    Data = new IslandData("ボロ屋敷島"                          , IslandDimension.Overworld, new Coordinate(-69, 97, -10));
                    break;
                case IslandType.Mansion:
                    Data = new IslandData("豪邸島"                              , IslandDimension.Overworld, new Coordinate(157, 69, -21));
                    break;
                case IslandType.InvertedHouse:
                    Data = new IslandData("逆さ屋敷島"                          , IslandDimension.Overworld, new Coordinate(67, 45, -58));
                    break;
                case IslandType.WitchHouse:
                    Data = new IslandData("魔女の家島"                          , IslandDimension.Overworld, new Coordinate(-78, 171, 88));
                    break;
                case IslandType.LargeTree:
                    Data = new IslandData("大木島"                              , IslandDimension.Overworld, new Coordinate(193, 130, 162));
                    break;
                case IslandType.BambooShoots:
                    Data = new IslandData("筍島"                                , IslandDimension.Overworld, new Coordinate(164, 63, -144));
                    break;
                case IslandType.HiddenVillage:
                    Data = new IslandData("隠里ノ島"                            , IslandDimension.Overworld, new Coordinate(244, 197, -126));
                    break;
                case IslandType.OldAbyss:
                    Data = new IslandData("旧深淵島"                            , IslandDimension.Overworld, new Coordinate(-95, 159, -151));
                    break;
                case IslandType.EnchantTable:
                    Data = new IslandData("エンチャントテーブル島"              , IslandDimension.Overworld, new Coordinate(-6, 134, -60));
                    break;
                case IslandType.PirateShip:
                    Data = new IslandData("海賊船島"                            , IslandDimension.Overworld, new Coordinate(62, 2, -161));
                    break;
                case IslandType.FiveStoriedPagoda:
                    Data = new IslandData("五重塔島"                            , IslandDimension.Overworld, new Coordinate(66, 51, 87));
                    break;
                case IslandType.AbandonedHospital:
                    Data = new IslandData("廃病院島"                            , IslandDimension.Overworld, new Coordinate(-134, 158, -60));
                    break;
                case IslandType.Reaper:
                    Data = new IslandData("死神島"                              , IslandDimension.Overworld, new Coordinate(17, 190, 181));
                    break;
                case IslandType.EndEntrance:
                    Data = new IslandData("エンドの入り口島"                    , IslandDimension.Overworld, new Coordinate(22, 213, -40));
                    break;
                case IslandType.TheUnderworld:
                    Data = new IslandData("地下世界"                            , IslandDimension.Overworld, new Coordinate(1287, 73, 179));
                    break;
                case IslandType.TheNether:
                    Data = new IslandData("ネザー"                              , IslandDimension.Nether   , new Coordinate(0, 31, -29));
                    break;
                case IslandType.GulliversLand:
                    Data = new IslandData("ガリバーランド"                      , IslandDimension.Overworld, new Coordinate(72, 113, 738));
                    break;
                case IslandType.Cloudia:
                    Data = new IslandData("クラウディア"                        , IslandDimension.Overworld, new Coordinate(-1887, 114, -84));
                    break;
                case IslandType.TableMountain:
                    Data = new IslandData("テーブルマウンテン"                  , IslandDimension.Overworld, new Coordinate(-3, 243, -2222));
                    break;
                case IslandType.TocultColde:
                    Data = new IslandData("トカルトコルデ"                      , IslandDimension.Overworld, new Coordinate(1377, 83, 2406));
                    break;
                case IslandType.TheEnd:
                    Data = new IslandData("エンド"                              , IslandDimension.TheEnd   , new Coordinate(-1385, 198, 9));
                    break;
            }

            var block = world.Dimensions[(int)Data.Dimension].Blocks.GetBlock(Data.Coordinate.X, Data.Coordinate.Y, Data.Coordinate.Z);
            var id = block.Block.Id;
            var metadata = block.Metadata;

            // ブロックIDが121(エンドポータルフレームは120のはずだけどなぜか121)
            // 且つメタデータが4以上7以下(向きが4方向あるため)
            IsComplete = id == 121 && (4 <= metadata && metadata <= 7);
        }
    }
}
