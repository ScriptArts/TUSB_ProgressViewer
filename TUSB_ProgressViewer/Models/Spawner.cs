using OrangeNBT.World;
using OrangeNBT.World.Anvil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUSB_ProgressViewer.Models
{
    public class Spawner
    {
        public Coordinate Coordinate { get; set; }
        public bool IsBroken { get; set; }

        public Spawner(Coordinate coordinate, AnvilWorld world)
        {
            var block = world.Dimensions[Dimension.TheEnd].Blocks.GetBlock(coordinate.X, coordinate.Y, coordinate.Z);
            var id = block.Block.Id;

            IsBroken = id != 50;
        }
    }
}
