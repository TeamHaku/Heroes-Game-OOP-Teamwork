using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Hero : GameObject
    {
        public static Hero DeffaultHero
        {
            get;
            set
            {
                 new Hero(deffaultHeroName)
            }
        }

        private const string deffaultHeroName = "Pesho";
        public string Name { get; set; }

        public Hero(string name)
        {
            this.Name = name;
        }

    }
}
