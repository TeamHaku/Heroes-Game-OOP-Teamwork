using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    using System.Drawing;

    using Game.Interfaces;
    using Game.Units;

    public class Unit : GameObject, IUnit
    {
        private PointsRange attackPoints;
        private PointsRange defence;
        private int healthPoints;
        private int squareMovements;

        public Unit(PointsRange attackPoints, PointsRange defence, int healthPoints, int squareMovements, Cost cost, Image image)
        {
            this.AttackPoints = attackPoints;
            this.Defence = defence;
            this.HealthPoints = healthPoints;
            this.SquareMovements = squareMovements;
            this.Cost = cost;
            this.Image = image;
        }

        public Cost Cost { get; set; }

        public PointsRange Defence
        {
            get { return this.defence; }
            set { this.defence = value; }
        }

        public PointsRange AttackPoints
        {
            get { return this.attackPoints; }
            set { this.attackPoints = value; }
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

        public Image Image { get; set; }

        public void Attack()
        {
            
        }
    }
}
