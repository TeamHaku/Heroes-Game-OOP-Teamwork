using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestForm
{
    public class Cost
    {
        public Cost(int priceInGold)
        {
            this.PriceInGold = priceInGold;
        }

        public int PriceInGold { get; set; }
    }
}
