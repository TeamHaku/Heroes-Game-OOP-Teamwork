namespace Game.Player
{
    class LivePlayer : Player
    {
        public LivePlayer(Faction faction, Hero hero)
        {
            this.Faction = faction;
            this.Hero = hero;
        }

        public Faction Faction { get; private set; }

        public Hero Hero { get; private set; }

        public Castle Castle { get; set; }
    }
}
