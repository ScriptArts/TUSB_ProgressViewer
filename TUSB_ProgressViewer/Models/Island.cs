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
        public IslandType IslandType { get; }

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
            IslandType = type;

            var block = world.Dimensions[(int)type.GetDimension()].Blocks.GetBlock(type.GetCoordinate().X, type.GetCoordinate().Y, type.GetCoordinate().Z);
            var id = block.Block.Id;
            var metadata = block.Metadata;

            // ブロックIDが121(エンドポータルフレームは120のはずだけどなぜか121)
            // 且つメタデータが4以上7以下(向きが4方向あるため)
            IsComplete = id == 121 && (4 <= metadata && metadata <= 7);
        }
    }
}
