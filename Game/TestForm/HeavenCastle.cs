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

    public partial class HeavenCastle : Form
    {
        public HeavenCastle()
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

            textBox1.Text = HeavenUnits.Sentinel.Count.ToString();
            textBox2.Text = HeavenUnits.Crossbowman.Count.ToString();
            textBox3.Text = HeavenUnits.Sister.Count.ToString();
            textBox4.Text = HeavenUnits.Griffin.Count.ToString();
            textBox5.Text = HeavenUnits.Celestial.Count.ToString();

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

            textBox1.Text = InfernoCreatures.Maniac.Count.ToString();
            textBox2.Text = InfernoCreatures.Cerberus.Count.ToString();
            textBox3.Text = InfernoCreatures.Lilim.Count.ToString();
            textBox4.Text = InfernoCreatures.Lacerator.Count.ToString();
            textBox5.Text = InfernoCreatures.PitLord.Count.ToString();

            textBox6.Text = GameWindow.Player.Gold.ToString();
        }
        
        private void InsertHeavenUnit(object sender, MouseEventArgs e)
        {
            if (sender == button1)
            {
                AddUnit(textBox1, HeavenUnits.Sentinel);
            }
            else if (sender == button4)
            {
                AddUnit(textBox2, HeavenUnits.Crossbowman);
            }
            else if (sender == button6)
            {
                AddUnit(textBox3, HeavenUnits.Sister);
            }
            else if (sender == button8)
            {
                AddUnit(textBox4, HeavenUnits.Griffin);
            }
            else if (sender == button10)
            {
                AddUnit(textBox5, HeavenUnits.Celestial);
            }
        }

        private void InsertInfernoUnit(object sender, MouseEventArgs e)
        {
            if (sender == button1)
            {
                AddUnit(textBox1, InfernoCreatures.Maniac);
            }
            else if (sender == button4)
            {
                AddUnit(textBox2, InfernoCreatures.Cerberus);
            }
            else if (sender == button6)
            {
                AddUnit(textBox3, InfernoCreatures.Lilim);
            }
            else if (sender == button8)
            {
                AddUnit(textBox4, InfernoCreatures.Lacerator);
            }
            else if (sender == button10)
            {
                AddUnit(textBox5, InfernoCreatures.PitLord);
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
