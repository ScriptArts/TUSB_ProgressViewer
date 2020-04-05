using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUSB_ProgressViewer.Models
{
    /// <summary>
    /// 座標
    /// </summary>
    public class Coordinate
    {
        /// <summary>
        /// X座標
        /// </summary>
        public int X { get; }

        /// <summary>
        /// Y座標
        /// </summary>
        public int Y { get; }

        /// <summary>
        /// Z座標
        /// </summary>
        public int Z { get; }

        public Coordinate(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
