namespace Game.Player
{
    class LivePlayer : Player
    {
        public LivePlayer(Faction faction, Hero hero, Castle castle)
            : base(faction)
        {
            this.Hero = hero;
        }

        public Hero Hero { get; private set; }

        public Castle Castle { get; set; }
    }
}
