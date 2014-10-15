﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Field
{
    class BattlefieldCell : Cell
    {
        public Unit CellUnit { get; set; }

        public BattlefieldCell(int x , int y, Unit unit = null)
            : base(x, y)
        {
            this.CellUnit = unit;
        }
    }
}