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
    public partial class MainMenu : Form
    {
        public static Faction ChosenFaction { get; set; }

        public static string Nickname { get; set; }

        public MainMenu()
        {
            InitializeComponent();
        }

        private void GameStart(object sender, MouseEventArgs e)
        {
            Nickname = textBox1.Text;

            switch (comboBox1.Text)
            {
                case "Heaven": ChosenFaction = Faction.Heaven; break;
                case "Inferno": ChosenFaction = Faction.Inferno; break;
            }

            var gameStart = new GameWindow();

            gameStart.Show();
        }
    }
}
