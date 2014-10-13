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
            this.DrawButtons();   
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
                    //butt.Image = global::TestForm.Properties.Resources.Marksman_s;
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

    }
}
