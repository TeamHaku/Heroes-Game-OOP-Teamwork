using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm.Field
{
    public sealed class Map
    {
        public Map(MapCell[,] mapCells)
        {
            this.MapCells = mapCells;
        }
        public MapCell[,] MapCells { get; set; }
    }
}
