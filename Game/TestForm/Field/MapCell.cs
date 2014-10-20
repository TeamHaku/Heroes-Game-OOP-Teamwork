
namespace TestForm.Field
{
    using System.Drawing;

    public class MapCell : Cell
    {
        public MapCell(int x, int y, Image image)
            : base(x, y)
        {
            this.Image = image;
        }

        public Image Image { get; set; }    

    }
}
