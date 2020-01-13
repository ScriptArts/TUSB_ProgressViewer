using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUSB_ProgressViewer.Util
{
    /// <summary>
    /// 座標
    /// </summary>
    public class Coordinate
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public Coordinate(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
