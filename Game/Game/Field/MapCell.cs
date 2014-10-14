﻿
namespace Game.Field
{
    public class MapCell : Cell
    {
        public int X { get; set; }

        public int Y { get; set; }

        public MapCell(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
