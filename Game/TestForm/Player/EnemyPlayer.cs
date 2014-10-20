using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm.Player
{
    class EnemyPlayer : Player
    {
        public EnemyPlayer(Faction faction)
            : base(faction, new Dictionary<Unit, int>())
        {
        }

        public ICollection<Unit> Units { get; set; }
    }
}
