namespace TestForm.Units
{
    using System.Collections.Generic;

    using TestForm.Properties;

    public static class InfernoCreatures
    {
        private static Unit maniac = new Unit(
                   attackPoints: new PointsRange(3, 6),
                   defence: new PointsRange(6, 14),
                   healthPoints: 23,
                   squareMovements: 5,
                   cost: new Cost(95),
                   image: Resources.Maniac,
                   name: "Mainac");

        private static Unit cerberus = new Unit(
                   attackPoints: new PointsRange(5, 10),
                   defence: new PointsRange(5, 11),
                   healthPoints: 32,
                   squareMovements: 5,
                   cost: new Cost(205),
                   image: Resources.Cerberus,
                   name: "Cerberus");

        private static Unit lilim = new Unit(
                   attackPoints: new PointsRange(2, 4),
                   defence: new PointsRange(7, 16),
                   healthPoints: 24,
                   squareMovements: 5,
                   cost: new Cost(150),
                   image: Resources.Lilim,
                   name: "Lilim");

        private static Unit lacerator = new Unit(
                   attackPoints: new PointsRange(17, 22),
                   defence: new PointsRange(14, 28),
                   healthPoints: 80,
                   squareMovements: 6,
                   cost: new Cost(615),
                   image: Resources.Lacerator,
                   name: "Lacerator");

        private static Unit pitLord = new Unit(
                   attackPoints: new PointsRange(57, 66),
                   defence: new PointsRange(31, 69),
                   healthPoints: 290,
                   squareMovements: 6,
                   cost: new Cost(2195),
                   image: Resources.PitLord,
                   name: "Pitlord");

        private static Dictionary<Unit, int> deffaultUnits = new Dictionary<Unit, int>
            {
                { Maniac, 20 },                                                   
                { Cerberus, 20 }                                                    
            };

        static InfernoCreatures()
        {
            Maniac = maniac;
            Cerberus = cerberus;
            Lilim = lilim;
            Lacerator = lacerator;
            PitLord = pitLord;
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

    }
}

