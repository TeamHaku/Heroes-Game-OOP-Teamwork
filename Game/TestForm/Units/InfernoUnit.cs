namespace TestForm.Units
{
    using System.Collections.Generic;
    using System.Drawing;

    using TestForm.Properties;

    public class InfernoUnit : Unit
    {
        private static Unit maniac = new InfernoUnit(
            attackPoints: new PointsRange(3, 6),
            defence: new PointsRange(6, 14),
            healthPoints: 23,
            squareMovements: 5,
            cost: new Cost(95),
            image: Resources.Maniac,
            name: "Mainac",
            count: 20);

        private static Unit cerberus = new InfernoUnit(
            attackPoints: new PointsRange(5, 10),
            defence: new PointsRange(5, 11),
            healthPoints: 32,
            squareMovements: 5,
            cost: new Cost(205),
            image: Resources.Cerberus,
            name: "Cerberus",
            count: 20);

        private static Unit lilim = new InfernoUnit(
            attackPoints: new PointsRange(2, 4),
            defence: new PointsRange(7, 16),
            healthPoints: 24,
            squareMovements: 5,
            cost: new Cost(150),
            image: Resources.Lilim,
            name: "Lilim",
            count: 0);

        private static Unit lacerator = new InfernoUnit(
            attackPoints: new PointsRange(17, 22),
            defence: new PointsRange(14, 28),
            healthPoints: 80,
            squareMovements: 6,
            cost: new Cost(615),
            image: Resources.Lacerator,
            name: "Lacerator",
            count: 0);

        private static Unit pitLord = new InfernoUnit(
            attackPoints: new PointsRange(57, 66),
            defence: new PointsRange(31, 69),
            healthPoints: 290,
            squareMovements: 6,
            cost: new Cost(2195),
            image: Resources.PitLord,
            name: "Pitlord",
            count: 0);

        private static IList<Unit> deffaultUnits = new List<Unit>()
        {
            Maniac,
            Cerberus,
            Lilim,
            Lacerator,
            PitLord
        };

        static InfernoUnit()
        {
            Maniac = maniac;
            Cerberus = cerberus;
            Lilim = lilim;
            Lacerator = lacerator;
            PitLord = pitLord;
        }

        public InfernoUnit(PointsRange attackPoints, PointsRange defence, int healthPoints, int squareMovements, Cost cost, Image image, string name, int count)
            : base(attackPoints, defence, healthPoints, squareMovements, cost, image, name, count)
        {
        }

        public static Unit Maniac
        {
            get
            {
                return maniac;
            }

            private set
            {
                maniac = value;
            }
        }

        public static Unit Cerberus
        {
            get
            {
                return cerberus;
            }

            private set
            {
                cerberus = value;
            }
        }

        public static Unit Lilim
        {
            get
            {
                return lilim;
            }

            private set
            {
                lilim = value;
            }
        }

        public static Unit Lacerator
        {
            get
            {
                return lacerator;
            }

            private set
            {
                lacerator = value;
            }
        }

        public static Unit PitLord
        {
            get
            {
                return pitLord;
            }

            private set
            {
                pitLord = value;
            }
        }

        public static IList<Unit> DeffaultUnits
        {
            get
            {
                return deffaultUnits;
            }

            private set
            {
                deffaultUnits = value;
            }
        }
    }
}

