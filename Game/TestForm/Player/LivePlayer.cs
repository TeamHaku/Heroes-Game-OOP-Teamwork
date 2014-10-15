namespace Game.Player
{
    using System.Collections.Generic;

    class LivePlayer : Player
    {
        public LivePlayer(
            Faction faction,
            Hero hero,
            Dictionary<Unit, int> warUnits)
            : base(faction, warUnits)
        {
            this.Hero = hero;
        }

        public Hero Hero { get; private set; }

        //public Castle Castle { get; set; }
    }
}
