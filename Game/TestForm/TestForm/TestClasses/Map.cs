using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Field
{
    public sealed class Map
    {
        public MapCell[,] MapCells { get; set; }

        public Map(MapCell[,] mapCells)
        {
            this.MapCells = mapCells;
        }
    }
}
