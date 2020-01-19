using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TUSB_ProgressViewer.Util.EnumExtension;

namespace TUSB_ProgressViewer.Util
{
    /// <summary>
    /// 島のタイプ(?)
    /// </summary>
    public enum IslandType
    {
        /// <summary>
        /// ガスト島
        /// </summary>
        [Name("ガスト島"), Dimension(IslandDimension.Overworld), Coordinate(8, 25, 67)]
        Ghast,
        /// <summary>
        /// 荒れ地島
        /// </summary>
        [Name("荒れ地島"), Dimension(IslandDimension.Overworld), Coordinate(8, 25, 67)]
        Wasteland,
        /// <summary>
        /// シルバーフィッシュ＆エンダーマイト島
        /// </summary>
        [Name("シルバーフィッシュ＆エンダーマイト島"), Dimension(IslandDimension.Overworld), Coordinate(35, 8, -24)]
        SilverfishAndEndermite,
        /// <summary>
        /// 山岳島
        /// </summary>
        [Name("山岳島"), Dimension(IslandDimension.Overworld), Coordinate(59, 1, -47)]
        Mountains,
        /// <summary>
        /// 交易島
        /// </summary>
        [Name("交易島"), Dimension(IslandDimension.Overworld), Coordinate(-70, 15, 32)]
        Trade,
        /// <summary>
        /// 時計島
        /// </summary>
        [Name("時計島"), Dimension(IslandDimension.Overworld), Coordinate(55, 13, 16)]
        Clock,
        /// <summary>
        /// 砂塊島
        /// </summary>
        [Name("砂塊島"), Dimension(IslandDimension.Overworld), Coordinate(-98, 23, 7)]
        LumpOfSand,
        /// <summary>
        /// 灯台島
        /// </summary>
        [Name("灯台島"), Dimension(IslandDimension.Overworld), Coordinate(-60, 44, -22)]
        Lighthouse,
        /// <summary>
        /// かつての脅威島
        /// </summary>
        [Name("かつての脅威島"), Dimension(IslandDimension.Overworld), Coordinate(39, 6, 68)]
        FormerThreat,
        /// <summary>
        /// 墓場島
        /// </summary>
        [Name("墓場島"), Dimension(IslandDimension.Overworld), Coordinate(16, 12, -61)]
        Graveyard,
        /// <summary>
        /// 夜を司る島
        /// </summary>
        [Name("夜を司る島"), Dimension(IslandDimension.Overworld), Coordinate(3, 77, 87)]
        GovernTheNight,
        /// <summary>
        /// 匠島
        /// </summary>
        [Name("匠島"), Dimension(IslandDimension.Overworld), Coordinate(19, 63, -38)]
        Creeper,
        /// <summary>
        /// イカ島
        /// </summary>
        [Name("イカ島"), Dimension(IslandDimension.Overworld), Coordinate(-38, 85, 69)]
        Squid,
        /// <summary>
        /// カボチャ島
        /// </summary>
        [Name("カボチャ島"), Dimension(IslandDimension.Overworld), Coordinate(39, 78, 28)]
        Pumpkin,
        /// <summary>
        /// 燃える愛の島
        /// </summary>
        [Name("燃える愛の島"), Dimension(IslandDimension.Overworld), Coordinate(-3, 69, -8)]
        BurningLove,
        /// <summary>
        /// かまど島
        /// </summary>
        [Name("かまど島"), Dimension(IslandDimension.Overworld), Coordinate(103, 20, -104)]
        Furnace,
        /// <summary>
        /// オアシス島
        /// </summary>
        [Name("オアシス島"), Dimension(IslandDimension.Overworld), Coordinate(-105, 13, -80)]
        Oasis,
        /// <summary>
        /// 黒曜石の塔の島
        /// </summary>
        [Name("黒曜石の塔の島"), Dimension(IslandDimension.Overworld), Coordinate(82, 12, -19)]
        ObsidianTower,
        /// <summary>
        /// スティーブ島
        /// </summary>
        [Name("スティーブ島"), Dimension(IslandDimension.Overworld), Coordinate(-43, 60, -54)]
        Steve,
        /// <summary>
        /// 蜘蛛島
        /// </summary>
        [Name("蜘蛛島"), Dimension(IslandDimension.Overworld), Coordinate(107, 36, 53)]
        Spider,
        /// <summary>
        /// ニコニコ島
        /// </summary>
        [Name("ニコニコ島"), Dimension(IslandDimension.Overworld), Coordinate(114, 44, 3)]
        Smilingly,
        /// <summary>
        /// ケーキ島
        /// </summary>
        [Name("ケーキ島"), Dimension(IslandDimension.Overworld), Coordinate(104, 127, -21)]
        Cake,
        /// <summary>
        /// サボテン島
        /// </summary>
        [Name("サボテン島"), Dimension(IslandDimension.Overworld), Coordinate(158, 16, 15)]
        Cactus,
        /// <summary>
        /// スライム島
        /// </summary>
        [Name("スライム島"), Dimension(IslandDimension.Overworld), Coordinate(187, 31, 62)]
        Slime,
        /// <summary>
        /// 大釜＆ホッパー島
        /// </summary>
        [Name("大釜＆ホッパー島"), Dimension(IslandDimension.Overworld), Coordinate(178, 19, -76)]
        CauldronAndHopper,
        /// <summary>
        /// 作業台島
        /// </summary>
        [Name("作業台島"), Dimension(IslandDimension.Overworld), Coordinate(-56, 61, -113)]
        Workbench,
        /// <summary>
        /// エンダーマン島
        /// </summary>
        [Name("エンダーマン島"), Dimension(IslandDimension.Overworld), Coordinate(84, 112, 99)]
        Enderman,
        /// <summary>
        /// エンダーチェスト島
        /// </summary>
        [Name("エンダーチェスト島"), Dimension(IslandDimension.Overworld), Coordinate(86, 110, -94)]
        EnderChest,
        /// <summary>
        /// スケルトン島
        /// </summary>
        [Name("スケルトン島"), Dimension(IslandDimension.Overworld), Coordinate(116, 128, 35)]
        Skeleton,
        /// <summary>
        /// ボロ屋敷島
        /// </summary>
        [Name("ボロ屋敷島"), Dimension(IslandDimension.Overworld), Coordinate(-69, 97, -10)]
        RaggedHouse,
        /// <summary>
        /// 豪邸島
        /// </summary>
        [Name("豪邸島"), Dimension(IslandDimension.Overworld), Coordinate(157, 69, -21)]
        Mansion,
        /// <summary>
        /// 逆さ屋敷島
        /// </summary>
        [Name("逆さ屋敷島"), Dimension(IslandDimension.Overworld), Coordinate(67, 45, -58)]
        InvertedHouse,
        /// <summary>
        /// 魔女の家島
        /// </summary>
        [Name("魔女の家島"), Dimension(IslandDimension.Overworld), Coordinate(-78, 171, 88)]
        WitchHouse,
        /// <summary>
        /// 大木島
        /// </summary>
        [Name("大木島"), Dimension(IslandDimension.Overworld), Coordinate(193, 130, 162)]
        LargeTree,
        /// <summary>
        /// 筍島
        /// </summary>
        [Name("筍島"), Dimension(IslandDimension.Overworld), Coordinate(164, 63, -144)]
        BambooShoots,
        /// <summary>
        /// 隠里ノ島
        /// </summary>
        [Name("隠里ノ島"), Dimension(IslandDimension.Overworld), Coordinate(244, 197, -126)]
        HiddenVillage,
        /// <summary>
        /// 旧深淵島
        /// </summary>
        [Name("旧深淵島"), Dimension(IslandDimension.Overworld), Coordinate(-95, 159, -151)]
        OldAbyss,
        /// <summary>
        /// エンチャントテーブル島
        /// </summary>
        [Name("エンチャントテーブル島"), Dimension(IslandDimension.Overworld), Coordinate(-6, 134, -60)]
        EnchantTable,
        /// <summary>
        /// 海賊船島
        /// </summary>
        [Name("海賊船島"), Dimension(IslandDimension.Overworld), Coordinate(62, 2, -161)]
        PirateShip,
        /// <summary>
        /// 五重塔島
        /// </summary>
        [Name("五重塔島"), Dimension(IslandDimension.Overworld), Coordinate(66, 51, 87)]
        FiveStoriedPagoda,
        /// <summary>
        /// 廃病院島
        /// </summary>
        [Name("廃病院島"), Dimension(IslandDimension.Overworld), Coordinate(-134, 158, -60)]
        AbandonedHospital,
        /// <summary>
        /// 死神島
        /// </summary>
        [Name("死神島"), Dimension(IslandDimension.Overworld), Coordinate(17, 190, 181)]
        Reaper,
        /// <summary>
        /// エンドの入り口島
        /// </summary>
        [Name("エンドの入り口島"), Dimension(IslandDimension.Overworld), Coordinate(22, 213, -40)]
        EndEntrance,
        /// <summary>
        /// 地下世界
        /// </summary>
        [Name("地下世界"), Dimension(IslandDimension.Overworld), Coordinate(1287, 73, 179)]
        TheUnderworld,
        /// <summary>
        /// ネザー
        /// </summary>
        [Name("ネザー"), Dimension(IslandDimension.Nether), Coordinate(0, 31, -29)]
        TheNether,
        /// <summary>
        /// ガリバーランド
        /// </summary>
        [Name("ガリバーランド"), Dimension(IslandDimension.Overworld), Coordinate(72, 113, 738)]
        GulliversLand,
        /// <summary>
        /// クラウディア
        /// </summary>
        [Name("クラウディア"), Dimension(IslandDimension.Overworld), Coordinate(-1887, 114, -84)]
        Cloudia,
        /// <summary>
        /// テーブルマウンテン
        /// </summary>
        [Name("テーブルマウンテン"), Dimension(IslandDimension.Overworld), Coordinate(-3, 243, -2222)]
        TableMountain,
        /// <summary>
        /// トカルトコルデ
        /// </summary>
        [Name("トカルトコルデ"), Dimension(IslandDimension.Overworld), Coordinate(1377, 83, 2406)]
        TocultColde,
        /// <summary>
        /// エンド
        /// </summary>
        [Name("エンド"), Dimension(IslandDimension.TheEnd), Coordinate(-1385, 198, 9)]
        TheEnd
    }
}
