namespace TestForm.Player
{
    using System.Collections.Generic;

    public class LivePlayer : Player
    {
        public LivePlayer(
            Faction faction,
            Hero hero,
            Dictionary<Unit, int> warUnits, int gold = 1000)
            : base(faction, warUnits)
        {
            this.Hero = hero;
            this.Gold = gold;
        }

        public Hero Hero { get; private set; }

        public int Gold { get; set; }

        //public Castle Castle { get; set; }
    }
}
