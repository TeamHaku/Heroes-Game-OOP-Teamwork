
namespace TestForm
{
    using TestForm.Interfaces;

    public abstract class GameObject : IGameObject
    {
        private string name;

        protected GameObject(string name, int x, int y)
        {
            this.name = name;
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }  
    }
}
