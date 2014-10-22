﻿
namespace TestForm.Interfaces
{
    using TestForm.Units;

    interface IUnit
    {
        Cost Cost { get; set; }

        PointsRange Defence { get; set; }

        PointsRange AttackPoints { get; set; }

        int HealthPoints { get; }

        int SquareMovements { get; }

        // Method Move

        // Method Attack
        void Attack();

    }
}
