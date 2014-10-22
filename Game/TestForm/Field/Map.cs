using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm.Field
{
    public struct Map
    {
        public Map(MapCell[,] mapCells)
            : this()
        {
            this.MapCells = mapCells;
        }

        public MapCell[,] MapCells { get; set; }
    }
}
