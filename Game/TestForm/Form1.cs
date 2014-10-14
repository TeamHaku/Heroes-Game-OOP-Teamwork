﻿using System;
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
    using Game.Field;

    using TestForm.Properties;

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
                    //MapCell cell = new MapCell(2, 5, Resources.chest);
                    Button butt = new Button();
                    butt.BackColor = Color.White;
                    if (col == 1 && row == 1)
                    {
                        butt.Image = Resources.Marksman;
                        butt.Text = "12";
                        butt.ForeColor = Color.Red;
                        butt.TextAlign = ContentAlignment.BottomRight;
                    }
                    if (col == 1 && row == 3)
                    {
                        butt.Image = Resources.Marksman;
                    }
                    if (col == 1 && row == 5)
                    {
                        butt.Image = Resources.Marksman;
                    }
                    butt.BackgroundImageLayout = ImageLayout.Stretch;
                    butt.Location = new Point(col * 50, row * 50);
                    butt.Name = string.Format("{0}-{1}", row, col);
                    butt.Size = new Size(50, 50);
                    this.Controls.Add(butt);
                }
            }
        }

        public void DrawMap()
        {
            Map map = new Map(new MapCell[,]
            {
                {
                    new MapCell(0, 0, Resources.enemy), 
                    new MapCell(0, 1, Resources.enemy),
                    new MapCell(0, 3, Resources.enemy),
                    new MapCell(0, 4, Resources.enemy),
                    new MapCell(0, 5, Resources.enemy),
                    new MapCell(0, 6, Resources.enemy),
                    new MapCell(0, 7, Resources.enemy),
                    new MapCell(0, 8, Resources.enemy),
                    new MapCell(0, 9, Resources.enemy),
                    new MapCell(0, 10, Resources.enemy),
                    new MapCell(0, 11, Resources.enemy),
                    new MapCell(0, 12, Resources.enemy)
                },

                {
                    new MapCell(1, 0, Resources.enemy), 
                    new MapCell(1, 1, Resources.enemy),
                    new MapCell(1, 3, Resources.enemy),
                    new MapCell(1, 4, Resources.enemy),
                    new MapCell(1, 5, Resources.enemy),
                    new MapCell(1, 6, Resources.enemy),
                    new MapCell(1, 7, Resources.enemy),
                    new MapCell(1, 8, Resources.enemy),
                    new MapCell(1, 9, Resources.enemy),
                    new MapCell(1, 10, Resources.enemy),
                    new MapCell(1, 11, Resources.enemy),
                    new MapCell(1, 12, Resources.enemy)
                }
            });

            //for (int row = 0; row < map.MapCells[0].; row++)
            //{
            //    for (int i = 0; i < UPPER; i++)
            //    {
                    
            //    }
            //}

        }

    }
}
