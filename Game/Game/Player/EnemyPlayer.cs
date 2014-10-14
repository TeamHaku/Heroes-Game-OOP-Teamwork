using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Player
{
    class EnemyPlayer : Player
    {
        public EnemyPlayer(Faction faction)
            : base(faction)
        {
        }

        public ICollection<Unit> Units { get; set; }
    }
}
