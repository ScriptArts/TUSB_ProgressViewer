using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TUSB_ProgressViewer.Controls;

namespace TUSB_ProgressViewer.Models
{
    public static class SpawnersData
    {
        /// <summary>
        /// スポナーリスト
        /// </summary>
        public static ReactiveCollection<SpawnerPointer> Spawners { get; } = new ReactiveCollection<SpawnerPointer>();

        /// <summary>
        /// スポナー破壊数カウント
        /// </summary>
        public static ReactiveProperty<int> BrokenCount { get; } = new ReactiveProperty<int>();

        /// <summary>
        /// スポナー破壊率
        /// </summary>
        public static ReactiveProperty<double> BrokenRate { get; } = new ReactiveProperty<double>();

        /// <summary>
        /// スポナー座標リスト
        /// </summary>
        private static readonly Coordinate[] _spawnerCoordinates = new Coordinate[247]
        {
            new Coordinate(74, 49, -10),
            new Coordinate(74, 49, 10),
            new Coordinate(64, 57, 5),
            new Coordinate(55, 62, 5),
            new Coordinate(41, 56, 5),
            new Coordinate(31, 58, 5),
            new Coordinate(18, 61, 5),
            new Coordinate(9, 58, 5),
            new Coordinate(-6, 51, -7),
            new Coordinate(-7, 58, 5),
            new Coordinate(-8, 67, 19),
            new Coordinate(-27, 65, 18),
            new Coordinate(-29, 51, 6),
            new Coordinate(-31, 51, -7),
            new Coordinate(-34, 62, 5),
            new Coordinate(-35, 42, 18),
            new Coordinate(-39, 62, 5),
            new Coordinate(-52, 58, 10),
            new Coordinate(-55, 45, 18),
            new Coordinate(-59, 58, 6),
            new Coordinate(-61, 64, 14),
            new Coordinate(-63, 49, 18),
            new Coordinate(-70, 61, 2),
            new Coordinate(-71, 61, 18),
            new Coordinate(-78, 61, 18),
            new Coordinate(-95, 66, 4),
            new Coordinate(-95, 65, 21),
            new Coordinate(-105, 68, 13),
            new Coordinate(-107, 61, -4),
            new Coordinate(-107, 61, 31),
            new Coordinate(-118, 63, 3),
            new Coordinate(-118, 63, 23),
            new Coordinate(-128, 63, 5),
            new Coordinate(-128, 63, 21),
            new Coordinate(-139, 63, 5),
            new Coordinate(-139, 63, 21),
            new Coordinate(-149, 63, 1),
            new Coordinate(-149, 63, 25),
            new Coordinate(-159, 63, 11),
            new Coordinate(-159, 63, 15),
            new Coordinate(-165, 63, -7),
            new Coordinate(-165, 63, 33),
            new Coordinate(-168, 63, 13),
            new Coordinate(-183, 63, 0),
            new Coordinate(-197, 68, 14),
            new Coordinate(-198, 67, 28),
            new Coordinate(-207, 58, 1),
            new Coordinate(-207, 70, 13),
            new Coordinate(-212, 58, 25),
            new Coordinate(-222, 75, -4),
            new Coordinate(-228, 66, 8),
            new Coordinate(-236, 66, 2),
            new Coordinate(-236, 64, 10),
            new Coordinate(-236, 63, 12),
            new Coordinate(-236, 64, 14),
            new Coordinate(-236, 66, 22),
            new Coordinate(-244, 66, 17),
            new Coordinate(-252, 63, 29),
            new Coordinate(-261, 63, 0),
            new Coordinate(-265, 65, 11),
            new Coordinate(-278, 63, 28),
            new Coordinate(-279, 61, 9),
            new Coordinate(-291, 63, -1),
            new Coordinate(-296, 64, 14),
            new Coordinate(-301, 65, 20),
            new Coordinate(-304, 61, -5),
            new Coordinate(-306, 63, 28),
            new Coordinate(-313, 63, 11),
            new Coordinate(-319, 62, -4),
            new Coordinate(-326, 61, 15),
            new Coordinate(-328, 60, 2),
            new Coordinate(-333, 60, 28),
            new Coordinate(-344, 59, 2),
            new Coordinate(-353, 60, 24),
            new Coordinate(-358, 60, 11),
            new Coordinate(-367, 67, 12),
            new Coordinate(-378, 64, 0),
            new Coordinate(-382, 64, 19),
            new Coordinate(-396, 66, 5),
            new Coordinate(-395, 65, -4),
            new Coordinate(-401, 65, 31),
            new Coordinate(-407, 66, 24),
            new Coordinate(-413, 67, 31),
            new Coordinate(-414, 67, -3),
            new Coordinate(-415, 68, 14),
            new Coordinate(-428, 64, -12),
            new Coordinate(-432, 64, 29),
            new Coordinate(-434, 64, 2),
            new Coordinate(-435, 64, 1),
            new Coordinate(-443, 63, 18),
            new Coordinate(-451, 63, 2),
            new Coordinate(-458, 63, 25),
            new Coordinate(-463, 61, 14),
            new Coordinate(-469, 63, 0),
            new Coordinate(-478, 63, 18),
            new Coordinate(-496, 64, -12),
            new Coordinate(-500, 63, 39),
            new Coordinate(-518, 63, -15),
            new Coordinate(-528, 63, 2),
            new Coordinate(-525, 63, 43),
            new Coordinate(-532, 63, 22),
            new Coordinate(-544, 66, -9),
            new Coordinate(-546, 66, -11),
            new Coordinate(-546, 78, 32),
            new Coordinate(-548, 78, 34),
            new Coordinate(-562, 63, -10),
            new Coordinate(-563, 76, 14),
            new Coordinate(-565, 76, 16),
            new Coordinate(-566, 63, -15),
            new Coordinate(-569, 68, -8),
            new Coordinate(-570, 67, 31),
            new Coordinate(-571, 63, 37),
            new Coordinate(-577, 63, 32),
            new Coordinate(-579, 63, 4),
            new Coordinate(-582, 63, -13),
            new Coordinate(-583, 63, 16),
            new Coordinate(-587, 63, 33),
            new Coordinate(-600, 66, 9),
            new Coordinate(-600, 66, 15),
            new Coordinate(-610, 66, -6),
            new Coordinate(-610, 66, 30),
            new Coordinate(-615, 66, 5),
            new Coordinate(-615, 66, 19),
            new Coordinate(-618, 66, 43),
            new Coordinate(-619, 66, -19),
            new Coordinate(-622, 66, 12),
            new Coordinate(-624, 66, 10),
            new Coordinate(-624, 66, 12),
            new Coordinate(-624, 66, 14),
            new Coordinate(-625, 66, 2),
            new Coordinate(-625, 66, 23),
            new Coordinate(-626, 66, 12),
            new Coordinate(-627, 66, -11),
            new Coordinate(-627, 66, 35),
            new Coordinate(-644, 66, 3),
            new Coordinate(-644, 66, 21),
            new Coordinate(-647, 66, 12),
            new Coordinate(-790, 66, -4),
            new Coordinate(-790, 66, 28),
            new Coordinate(-802, 66, 12),
            new Coordinate(-829, 76, -1),
            new Coordinate(-829, 76, 26),
            new Coordinate(-830, 76, 12),
            new Coordinate(-881, 96, 1),
            new Coordinate(-881, 96, 12),
            new Coordinate(-881, 96, 23),
            new Coordinate(-907, 106, 0),
            new Coordinate(-907, 106, 12),
            new Coordinate(-907, 106, 26),
            new Coordinate(-933, 116, -5),
            new Coordinate(-933, 116, 3),
            new Coordinate(-933, 116, 12),
            new Coordinate(-933, 116, 21),
            new Coordinate(-933, 116, 29),
            new Coordinate(-960, 106, 1),
            new Coordinate(-960, 106, 8),
            new Coordinate(-960, 106, 16),
            new Coordinate(-960, 106, 23),
            new Coordinate(-984, 96, 4),
            new Coordinate(-984, 96, 21),
            new Coordinate(-985, 96, 12),
            new Coordinate(-1011, 86, -2),
            new Coordinate(-1011, 86, 26),
            new Coordinate(-1013, 86, 12),
            new Coordinate(-1037, 76, 3),
            new Coordinate(-1037, 76, 21),
            new Coordinate(-1039, 76, 12),
            new Coordinate(-1069, 66, 12),
            new Coordinate(-1076, 66, -4),
            new Coordinate(-1076, 66, 28),
            new Coordinate(-1083, 66, 12),
            new Coordinate(-1090, 66, 5),
            new Coordinate(-1090, 66, 19),
            new Coordinate(-1109, 74, -3),
            new Coordinate(-1109, 74, 27),
            new Coordinate(-1115, 66, -7),
            new Coordinate(-1115, 66, 31),
            new Coordinate(-1118, 67, 12),
            new Coordinate(-1130, 66, 0),
            new Coordinate(-1130, 66, 8),
            new Coordinate(-1130, 66, 16),
            new Coordinate(-1130, 66, 24),
            new Coordinate(-1143, 66, 12),
            new Coordinate(-1145, 66, -3),
            new Coordinate(-1145, 66, 27),
            new Coordinate(-1153, 73, 5),
            new Coordinate(-1153, 73, 19),
            new Coordinate(-1154, 73, -8),
            new Coordinate(-1154, 73, 32),
            new Coordinate(-1155, 149, -20),
            new Coordinate(-1155, 149, 44),
            new Coordinate(-1252, 80, -8),
            new Coordinate(-1256, 80, -10),
            new Coordinate(-1260, 89, 4),
            new Coordinate(-1298, 95, 56),
            new Coordinate(-1302, 95, 58),
            new Coordinate(-1307, 99, 41),
            new Coordinate(-1364, 114, -3),
            new Coordinate(-1365, 114, 20),
            new Coordinate(-1376, 163, 5),
            new Coordinate(-1376, 114, 9),
            new Coordinate(-1376, 163, 13),
            new Coordinate(-1377, 127, -5),
            new Coordinate(-1377, 114, 1),
            new Coordinate(-1377, 156, 9),
            new Coordinate(-1377, 114, 17),
            new Coordinate(-1377, 127, 23),
            new Coordinate(-1387, 163, 5),
            new Coordinate(-1387, 156, 9),
            new Coordinate(-1387, 163, 13),
            new Coordinate(-1388, 114, -2),
            new Coordinate(-1388, 206, 9),
            new Coordinate(-1388, 114, 21),
            new Coordinate(-1391, 127, -8),
            new Coordinate(-1391, 127, 26),
            new Coordinate(-1393, 156, 4),
            new Coordinate(-1393, 156, 14),
            new Coordinate(-1399, 163, 5),
            new Coordinate(-1399, 163, 13),
            new Coordinate(-1411, 202, 3),
            new Coordinate(-1412, 198, 10),
            new Coordinate(-1419, 151, -9),
            new Coordinate(-1419, 192, -9),
            new Coordinate(-1419, 198, -9),
            new Coordinate(-1419, 198, 27),
            new Coordinate(-1425, 157, 22),
            new Coordinate(-1427, 114, -1),
            new Coordinate(-1427, 114, 19),
            new Coordinate(-1428, 157, 33),
            new Coordinate(-1432, 145, -14),
            new Coordinate(-1433, 187, -11),
            new Coordinate(-1437, 184, -15),
            new Coordinate(-1440, 142, -17),
            new Coordinate(-1442, 159, 33),
            new Coordinate(-1447, 139, -9),
            new Coordinate(-1448, 120, 28),
            new Coordinate(-1453, 131, 10),
            new Coordinate(-1455, 179, -15),
            new Coordinate(-1456, 178, -9),
            new Coordinate(-1456, 114, 2),
            new Coordinate(-1456, 114, 16),
            new Coordinate(-1456, 164, 27),
            new Coordinate(-1457, 169, 12),
            new Coordinate(-1459, 127, 12),
            new Coordinate(-1460, 176, -5),
            new Coordinate(-1463, 131, 4),
            new Coordinate(-1463, 173, 4)
        };

        /// <summary>
        /// スポナー読み込み
        /// </summary>
        /// <param name="count"></param>
        public static void Load(ref int count)
        {
            try
            {
                Spawners.ClearOnScheduler();
                foreach (Coordinate coor in _spawnerCoordinates)
                {
                    // 実際の座標と画像のピクセル数から画像上のスポナー位置を計算
                    // 画像のサイズが変わると壊れます()
                    var X = (coor.X + 1502.5) / 1664;
                    var Z = (coor.Z + 114.5) / 247;

                    var isBroken = new Spawner(coor, World.WorldData).IsBroken;

                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        Spawners.Add(new SpawnerPointer()
                        {
                            Center = new Point(X, Z),
                            IsBroken = isBroken
                        });

                        BrokenCount.Value = Spawners.Where(x => x.IsBroken).Count();
                        BrokenRate.Value = (BrokenCount.Value / 247.0) * 100;
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
            Spawners.ClearOnScheduler();
            BrokenCount.Value = 0;
            BrokenRate.Value = 0;
        }
    }
}
