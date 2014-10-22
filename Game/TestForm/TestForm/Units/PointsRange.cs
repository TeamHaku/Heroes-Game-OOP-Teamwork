using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm.Units
{
    public sealed class PointsRange
    {
        public PointsRange(int minPoints, int maxPoints)
        {
            this.MinPoints = minPoints;
            this.MaxPoints = maxPoints;
        }

        public int MinPoints { get; set; }

        public int MaxPoints { get; set; }

    }
}
