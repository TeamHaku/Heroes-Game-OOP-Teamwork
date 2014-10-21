#define DEBUG
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TestForm
{
    using TestForm.Field;
    using TestForm.Player;
    using TestForm.Properties;
    using TestForm.Units;
    
    public partial class GameWindow : Form
    {
        public static LivePlayer Player { get; set; }

        public static List<EnemyPlayer> Enemies { get; set; }

        public GameWindow()
        {
            this.InitializeComponent();
            this.InitializeGame();
            this.DrawMap();
        }

        private void InitializeGame()
        {
            this.InitPlayer();
            this.InitEnemyies();
            //player.Hero.Name = MainMenu.Nickname;
        }

        private void InitEnemyies()
        {
            Enemies = new List<EnemyPlayer>
            {
                new EnemyPlayer(Faction.Inferno, InfernoCreatures.DeffaultUnits)   
            };
        }

        private void InitPlayer()
        {
            Dictionary<Unit, int> units = new Dictionary<Unit, int>();
            switch (MainMenu.ChosenFaction)
            {
                case Faction.Heaven:
                    units = HeavenUnits.DeffaultUnits;
                    break;
                case Faction.Inferno:
                    units = InfernoCreatures.DeffaultUnits;
                    break;
            }

            Player = new LivePlayer(
                MainMenu.ChosenFaction,
                Hero.DeffaultHero,
                units,
                10000);
        }

        

        public void DrawMap()
        {
            try
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
                                    cell.Image = Resources.earth;
                                    name = "earth";
                                    break;
                                case 'T':
                                    cell.Image = Resources.chest;
                                    name = "chest"; //tresure
                                    break;
                            }

                            this.Controls.Add(this.generateButton(cell, name));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                this.textBoxType.Text = "The file could not be read:";
                this.gameLog.Text = e.Message;
            }

        }

        private Button generateButton(MapCell cell, string name)
        {
            Button butt = new Button();
            butt.BackColor = Color.White;
            butt.FlatStyle = 0;
            butt.BackgroundImageLayout = ImageLayout.Stretch;
            butt.Image = cell.Image;
            butt.Location = new Point(cell.Y * 30, cell.X * 30);
            butt.Name = name; //string.Format("{0}-{1}", cell.Y, cell.X);
            butt.Size = new Size(30, 30);
            butt.Click += new EventHandler(this.button_Clicked);
            return butt;
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            Button triggeredButton = (Button) sender;
            int x = triggeredButton.Location.X/30;
            int y = triggeredButton.Location.Y/30;
            string type = triggeredButton.Name;
            string log = "nothing";

     
#if (DEBUG)
            this.textBoxX.Text = x + " " + this.textBoxX.Text;
            this.textBoxY.Text = y + " " + this.textBoxY.Text;
            this.textBoxType.Text = type;
#endif

            if (type == "earth") //Cell is empty
            {
                Button player = (Button) this.Controls.Find("player", false)[0];
                this.Controls.Remove(triggeredButton);
                this.Controls.Remove(player);
                Point playerLocation = player.Location;
                player.Location = triggeredButton.Location;
                triggeredButton.Location = playerLocation;
                this.Controls.Add(player);
                this.Controls.Add(triggeredButton);
                log = "Walk";
            }
            else if (type == "tree") //Or other element you cannot walk on
            {
                log = "Can't walk here, sorry";
            }
            else if (type == "enemy") //Or other enemy
            {
                log = "fight";
                var battlefield = new BattlfieldForm();
                battlefield.Show();
                this.WindowState = FormWindowState.Minimized;


            }
            else if (type == "castle")
            {
                if (MainMenu.ChosenFaction == Faction.Inferno)
                {
                    var inferno = new InfernoCastle(Player.Gold);
                    inferno.Show();
                }
                else
                {
                    var heaven = new HeavenCastle(Player.Gold);
                    heaven.Show();
                }

                log = "enter your castle";
            }
            else if (type == "chest")
            {
                log = "collect tresure if path available";
                Player.Gold += 1000;
                textBox1.Text = Player.Gold.ToString();
            }

            this.gameLog.Text = log + Environment.NewLine + this.gameLog.Text;
        }
    }
}
