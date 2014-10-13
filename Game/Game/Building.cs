using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    using System.Net.Mime;

    abstract class Building : GameObject
    {
        private bool isBuilt = false;

        public Cost Cost { get; set; }

        // property Image
        public string ImagePath { get; private set; }

        public void Build()
        {
            this.isBuilt = true;
        }

    }
}
