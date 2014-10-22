
namespace Game.Field
{
    using System.Drawing;

    public class MapCell : Cell
    {
        public MapCell(int x, int y, Image image)
        {
            this.X = x;
            this.Y = y;
            this.Image = image;
        }

        public Image Image { get; set; }    

        public int X { get; set; }

        public int Y { get; set; }
    }
}
