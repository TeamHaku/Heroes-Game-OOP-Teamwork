using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm.Player
{
    public class EnemyPlayer : Player
    {
        public EnemyPlayer(Faction faction, IList<Unit> units)
            : base(faction, units)
        {
        }
    }
}
