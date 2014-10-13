using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interfaces
{
    interface IUnit
    {
        Cost Cost { get; set; }

        int Defence { get; set; }

        int Attack { get; set; }

        int HealthPoints { get; }

        int SquareMovements { get; }

        // Method Move

        // Method Attack
            
    }
}
