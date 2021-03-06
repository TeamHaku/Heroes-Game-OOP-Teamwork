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
    using TestForm.Field;
    using TestForm.Properties;

    public partial class BattlefieldForm : Form
    {
        public BattlefieldForm()
        {
            this.InitializeComponent();
            this.DrawBattlefiled();
            this.StartBattle();
        }

        private void StartBattle()
        {

        }

        public void DrawBattlefiled()
        {
            BattleField battleField = this.InitBattleField();

            for (int row = 0; row < battleField.BattlefieldCells.GetLength(0); row++)
            {
                for (int col = 0; col < battleField.BattlefieldCells.GetLength(1); col++)
                {
                    Button butt = new Button
                    {
                        BackColor = Color.White,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        BackgroundImage = Resources.grass,
                        Location = new Point(col * 75, row * 75),
                        Name = string.Format("{0}-{1}", row, col),
                        Size = new Size(75, 75)
                    };

                    if (battleField.BattlefieldCells[row, col].CellUnit != null)
                    {
                        butt.BackgroundImage = battleField.BattlefieldCells[row, col].CellUnit.Image;
                        butt.Text = battleField.BattlefieldCells[row, col].CellUnit.Count.ToString();
                        butt.ForeColor = Color.Red;
                        butt.FlatStyle = 0;
                        butt.TextAlign = ContentAlignment.BottomRight;
                    }

                    this.Controls.Add(butt);
                }
            }
        }

        private BattleField InitBattleField()
        {
            BattleField battleField = new BattleField(new BattlefieldCell[9, 10]);

            for (int row = 0; row < battleField.BattlefieldCells.GetLength(0); row++)
            {
                for (int col = 0; col < battleField.BattlefieldCells.GetLength(1); col++)
                {
                    battleField.BattlefieldCells[row, col] = new BattlefieldCell(row, col);
                }
            }

            int i = 0;
            foreach (var warUnit in GameWindow.Player.Units)
            {
                if (warUnit.Count > 0)
                {
                    battleField.BattlefieldCells[i, 0].CellUnit = warUnit;
                }
                i += 2;
            }

            i = 0;
            foreach (var warUnit in GameWindow.Enemies[0].Units)
            {
                if (warUnit.Count > 0) 
                {
                    battleField.BattlefieldCells[i, 9].CellUnit = warUnit;
                }
                i += 2;
            }

            return battleField;
        }
    }
}
