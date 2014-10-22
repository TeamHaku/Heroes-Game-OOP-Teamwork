using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm.Field
{
    public class BattlefieldCell : Cell
    {
        public BattlefieldCell(int x , int y, Unit unit = null)
            : base(x, y)
        {
            this.CellUnit = unit;
        }

        public Unit CellUnit { get; set; }
    }
}
