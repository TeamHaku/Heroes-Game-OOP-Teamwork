using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm.Field
{
    public class BattleField
    {
        public BattlefieldCell[,] BattlefieldCells { get; set; }

        public BattleField(BattlefieldCell[,] battlefield)
        {
            this.BattlefieldCells = battlefield;
        }
    }
}
