using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUSB_ProgressViewer.Models;
using TUSB_ProgressViewer.Util;

namespace TUSB_ProgressViewer.Models
{
    /// <summary>
    /// 島の情報
    /// </summary>
    public class IslandData
    {
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// ディメンション
        /// </summary>
        public IslandDimension Dimension { get; }

        /// <summary>
        /// 座標
        /// </summary>
        public Coordinate Coordinate { get; }

        public IslandData(string name, IslandDimension dimension, Coordinate coordinate)
        {
            Name = name;
            Dimension = dimension;
            Coordinate = coordinate;
        }
    }
}
