#define DEBUG
//#undef DEBUG
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    using TestForm;
    using TestForm.Field;
    using TestForm.Player;
    using TestForm.Units;
    using TestForm.Properties;
    
    public partial class GameWindow : Form
    {
        public static LivePlayer player;

        public GameWindow()
        {
            this.InitializeComponent();
            this.InitializeGame();
            this.DrawMap();
        }

        private void InitializeGame()
        {
            if (MainMenu.ChosenFaction == Faction.Inferno)
            {
                player = new LivePlayer(MainMenu.ChosenFaction, InfernoCreatures.DeffaultUnits, 1000);
            }
            else
            {
                player = new LivePlayer(MainMenu.ChosenFaction, HeavenUnits.DeffaultUnits, 1000);
            }
        }

        public void DrawMap()
        {
            using (StreamReader sr = new StreamReader("../../../map.txt"))
            {
                for (int row = 0; row < 20; row++)
                {
                    String line = sr.ReadLine();
                    for (int col = 0; col < 20; col++)
                    {
                        MapCell cell = new MapCell(row, col, Resources.earth);
                        string name = "not recognized";

                        switch (line[col])
                        {
                            case 'W':
                                cell.Image = Resources.tree;
                                name = "tree";
                                break;
                            case 'S':
                                cell.Image = Resources.stone;
                                name = "stone";
                                break;
                            case 'C':
                                cell.Image = Resources.castle;
                                name = "castle";
                                break;
                            case 'H':
                                cell.Image = Resources.player;
                                name = "player";
                                break;
                            case 'X':
                                cell.Image = Resources.enemy;
                                name = "enemy";
                                break;
                            case 'E':
                                name = "earth";
                                break;
                            case 'T':
                                cell.Image = Resources.chest;
                                name = "chest";
                                break;
                        }

                        this.Controls.Add(generateButton(cell, name));
                    }
                }
            }
        }

        private Button generateButton(MapCell cell, string name)
        {
            Button butt = new Button();
            butt.BackColor = Color.Transparent;
            butt.FlatStyle = 0;
            butt.BackgroundImageLayout = ImageLayout.Stretch;
            butt.BackgroundImage = cell.Image;
            butt.Location = new Point(cell.Y*30, cell.X*30);
            butt.Name = name;
            butt.Size = new Size(30, 30);
            butt.Click += new EventHandler(this.button_Clicked);
            return butt;
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            Button triggeredButton = (Button)sender;
            int x = triggeredButton.Location.X/30;
            int y = triggeredButton.Location.Y/30;
            string type = triggeredButton.Name;

            Button playerPosition = (Button)this.Controls.Find("player", false)[0];

            if (type == "earth")
            {
                this.Controls.Remove(triggeredButton);
                this.Controls.Remove(playerPosition);
                Point playerLocation = playerPosition.Location;
                playerPosition.Location = triggeredButton.Location;
                triggeredButton.Location = playerLocation;
                this.Controls.Add(playerPosition);
                this.Controls.Add(triggeredButton);
            }
            else if (type == "enemy")
            {
                // fight
            }
            else if (type == "castle")
            {
                if (MainMenu.ChosenFaction == Faction.Inferno)
                {
                    var inferno = new InfernoCastle();

                    inferno.Show();
                }
                else
                {
                    var heaven = new HeavenCastle();

                    heaven.Show();
                }
            }
            else if (type == "chest")
            {
                this.Controls.Remove(triggeredButton);
                this.Controls.Remove(playerPosition);
                triggeredButton.Name = "earth";
                triggeredButton.BackgroundImage = Resources.earth;
                Point playerLocation = playerPosition.Location;
                playerPosition.Location = triggeredButton.Location;
                triggeredButton.Location = playerLocation;
                this.Controls.Add(playerPosition);
                this.Controls.Add(triggeredButton);

                player.Gold += 1000;

                MessageBox.Show("You earned 1000 gold!");
            }
        }
    }
}
