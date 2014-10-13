using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    using Game.Interfaces;

    public abstract class Unit : GameObject, IUnit
    {
        private int attack;
        private int defense;
        private int healthPoints;
        private int squareMovements;

        public Cost Cost { get; set; }

        public int Defence
        {
            get { return this.defense; }
            set { this.defense = value; }
        }

        public int Attack
        {
            get { return this.attack; }
            set { this.attack = value; }
        }

        public int HealthPoints
        {
            get { return this.healthPoints; }
            private set { this.healthPoints = value; }
        }


        public int SquareMovements
        {
            get
            {
                return this.squareMovements;
            }

            private set
            {
                this.squareMovements = value;
            }
        }
    }
}
