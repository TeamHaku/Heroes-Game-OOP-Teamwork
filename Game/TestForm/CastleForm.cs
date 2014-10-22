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
    using TestForm.Units;
    using TestForm.Player;
    using TestForm.Properties;

    public partial class CastleForm : Form
    {
        public CastleForm()
        {
            InitializeComponent();

            switch (MainMenu.ChosenFaction)
            {
                case Faction.Heaven: DrawHeavenCastle();
                    break;
                case Faction.Inferno: DrawInfernoCastle();
                    break;

            }
        }


        private void DrawHeavenCastle()
        {
            this.BackgroundImage = Resources.heavenCastle;
            pictureBox1.BackgroundImage = Resources.Sentinel;
            pictureBox2.BackgroundImage = Resources.Crossbowman;
            pictureBox3.BackgroundImage = Resources.Sister;
            pictureBox4.BackgroundImage = Resources.Griffin;
            pictureBox5.BackgroundImage = Resources.Celestial;

            textBox1.Text = HeavenUnit.Sentinel.Count.ToString();
            textBox2.Text = HeavenUnit.Crossbowman.Count.ToString();
            textBox3.Text = HeavenUnit.Sister.Count.ToString();
            textBox4.Text = HeavenUnit.Griffin.Count.ToString();
            textBox5.Text = HeavenUnit.Celestial.Count.ToString();

            textBox6.Text = GameWindow.Player.Gold.ToString();
        }

        private void DrawInfernoCastle()
        {
            this.BackgroundImage = Resources.internoTown;
            pictureBox1.BackgroundImage = Resources.Maniac;
            pictureBox2.BackgroundImage = Resources.Cerberus;
            pictureBox3.BackgroundImage = Resources.Lilim;
            pictureBox4.BackgroundImage = Resources.Lacerator;
            pictureBox5.BackgroundImage = Resources.PitLord;

            textBox1.Text = InfernoUnit.Maniac.Count.ToString();
            textBox2.Text = InfernoUnit.Cerberus.Count.ToString();
            textBox3.Text = InfernoUnit.Lilim.Count.ToString();
            textBox4.Text = InfernoUnit.Lacerator.Count.ToString();
            textBox5.Text = InfernoUnit.PitLord.Count.ToString();

            textBox6.Text = GameWindow.Player.Gold.ToString();
        }
        
        private void InsertHeavenUnit(object sender, MouseEventArgs e)
        {
            if (sender == button1)
            {
                AddUnit(textBox1, HeavenUnit.Sentinel);
            }
            else if (sender == button4)
            {
                AddUnit(textBox2, HeavenUnit.Crossbowman);
            }
            else if (sender == button6)
            {
                AddUnit(textBox3, HeavenUnit.Sister);
            }
            else if (sender == button8)
            {
                AddUnit(textBox4, HeavenUnit.Griffin);
            }
            else if (sender == button10)
            {
                AddUnit(textBox5, HeavenUnit.Celestial);
            }
        }

        private void InsertInfernoUnit(object sender, MouseEventArgs e)
        {
            if (sender == button1)
            {
                AddUnit(textBox1, InfernoUnit.Maniac);
            }
            else if (sender == button4)
            {
                AddUnit(textBox2, InfernoUnit.Cerberus);
            }
            else if (sender == button6)
            {
                AddUnit(textBox3, InfernoUnit.Lilim);
            }
            else if (sender == button8)
            {
                AddUnit(textBox4, InfernoUnit.Lacerator);
            }
            else if (sender == button10)
            {
                AddUnit(textBox5, InfernoUnit.PitLord);
            }
        }

        private void AddUnit(TextBox textbox, Unit unit)
        {
            if (GameWindow.Player.Gold >= unit.Cost.PriceInGold)
            {
                textbox.Text = (int.Parse(textbox.Text) + 1).ToString();
                textBox6.Text = (int.Parse(textBox6.Text) - unit.Cost.PriceInGold).ToString();
                unit.Count++;
                GameWindow.Player.Gold -= unit.Cost.PriceInGold;
            }
            else
            {
                MessageBox.Show("Not enough gold!");
            }
        }
    }
}
