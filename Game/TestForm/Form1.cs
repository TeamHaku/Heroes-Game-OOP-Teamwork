using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            this.InitializeComponent();
            //this.DrawButtons();
            this.DrawPicture();
        }

        private void DrawPicture()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    PictureBox pictureBox1 = new PictureBox();
                    pictureBox1.BackgroundImage = global::TestForm.Properties.Resources.enemy;
                    pictureBox1.Location = new Point(col * 25, row * 25);
                    pictureBox1.Name = "pictureBox1";
                    pictureBox1.Size = new System.Drawing.Size(25, 25);
                    pictureBox1.TabIndex = 1;
                    pictureBox1.TabStop = false;
                    this.Controls.Add(pictureBox1);
                }
            }  
        }

        public void DrawButtons()
        {
            // draw hor
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    Button butt = new Button();
                    butt.BackColor = Color.White;
                    butt.Image = global::TestForm.Properties.Resources.earth;
                    butt.Location = new Point(col * 50, row * 50);
                    butt.Name = "button1";
                    butt.Size = new Size(50, 50);
                    butt.TabIndex = 1;
                    butt.TextAlign = ContentAlignment.TopLeft;
                    butt.UseVisualStyleBackColor = false;
                    this.Controls.Add(butt);
                }
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
