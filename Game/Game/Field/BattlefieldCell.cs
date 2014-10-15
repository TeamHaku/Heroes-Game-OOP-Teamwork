 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Field
{
    class BattlefieldCell : Cell
    {
        public GameObject gameObject { get; set; }

        public BattlefieldCell(GameObject gameObject)
        {
            this.gameObject = gameObject;
        }
    }
}
