namespace Game.Units
{
    using TestForm.Properties;

    public static class InfernoCreatures
    {
        private static Unit maniac;
        private static Unit cerberus;
        private static Unit lilim;
        private static Unit lacerator;
        private static Unit pitLord;

        public static Unit Maniac
        {
            get
            {
                return maniac;
            }

            private set
            {
                maniac = new Unit(
                   attackPoints: new PointsRange(3, 6),
                   defence: new PointsRange(6, 14),
                   healthPoints: 23,
                   squareMovements: 5,
                   cost: new Cost(95),
                   image: Resources.Maniac);
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
                cerberus = new Unit(
                   attackPoints: new PointsRange(5, 10),
                   defence: new PointsRange(5, 11),
                   healthPoints: 32,
                   squareMovements: 5,
                   cost: new Cost(205),
                   image: Resources.Cerberus);
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
                lilim = new Unit(
                   attackPoints: new PointsRange(2, 4),
                   defence: new PointsRange(7, 16),
                   healthPoints: 24,
                   squareMovements: 5,
                   cost: new Cost(150),
                   image: Resources.Lilim);
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
                lacerator = new Unit(
                   attackPoints: new PointsRange(17, 22),
                   defence: new PointsRange(14, 28),
                   healthPoints: 80,
                   squareMovements: 6,
                   cost: new Cost(615),
                   image: Resources.Lacerator);
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
                pitLord = new Unit(
                   attackPoints: new PointsRange(57, 66),
                   defence: new PointsRange(31, 69),
                   healthPoints: 290,
                   squareMovements: 6,
                   cost: new Cost(2195),
                   image: Resources.PitLord);
            }
        }

    }
}

