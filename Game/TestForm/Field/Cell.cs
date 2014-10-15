using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Field
{
    public abstract class Cell 
    {
        private static int sizeInPixels = 20;

        public int X { get; set; }

        public int Y { get; set; }

        protected Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
