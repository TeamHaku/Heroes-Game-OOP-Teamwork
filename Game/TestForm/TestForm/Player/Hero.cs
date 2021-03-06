﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
    public class Hero : GameObject
    {
        private const string DeffaultHeroName = "Pesho";
        private static Hero deffalutHero;

        public Hero(string name = DeffaultHeroName)
            : base(name, 0, 0)
        {
            DeffaultHero = deffalutHero;
        }

        public static Hero DeffaultHero
        {
            get
            {
                return deffalutHero;
            }

            set
            {
                deffalutHero = new Hero();
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
