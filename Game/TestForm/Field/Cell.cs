using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm.Field
{
    public abstract class Cell : GameObject
    {
        protected Cell(int x, int y)
            : base("Cell", x , y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
