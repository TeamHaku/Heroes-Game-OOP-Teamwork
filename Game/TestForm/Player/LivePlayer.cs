namespace TestForm.Player
{
    using System.Collections.Generic;

    public class LivePlayer : Player
    {
        public LivePlayer(Faction faction, IList<Unit> units, int gold = 1000)
            : base(faction, units)
        {
            this.Gold = gold;
        }

        public int Gold { get; set; }
    }
}
