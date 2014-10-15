
namespace Game
{
    public abstract class GameObject
    {
        private string name;

        public int X { get; set; }

        public int Y { get; set; }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        protected GameObject(string name, int x, int y)
        {
            this.name = name;
            this.X = x;
            this.Y = y;
        }
           
    }
}
