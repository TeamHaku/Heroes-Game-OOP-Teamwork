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

    public partial class HeavenCastle : Form
    {
        public HeavenCastle()
        {
            InitializeComponent();
            UnitsCount();

            textBox6.Text = GameWindow.player.Gold.ToString();
        }

        private void UnitsCount()
        {
            textBox1.Text = HeavenUnits.Sentinel.Count.ToString();
            textBox2.Text = HeavenUnits.Crossbowman.Count.ToString();
            textBox3.Text = HeavenUnits.Sister.Count.ToString();
            textBox4.Text = HeavenUnits.Griffin.Count.ToString();
            textBox5.Text = HeavenUnits.Celestial.Count.ToString();
        }

        private void InsertUnit(object sender, MouseEventArgs e)
        {
            if (sender == button1)
            {
                AddUnit(textBox1, HeavenUnits.Sentinel);
            }
            else if (sender == button4)
            {
                AddUnit(textBox2, HeavenUnits.Crossbowman);
                HeavenUnits.Crossbowman.Count++;
                GameWindow.player.Gold -= HeavenUnits.Crossbowman.Cost.PriceInGold;
            }
            else if (sender == button6)
            {
                AddUnit(textBox3, HeavenUnits.Sister);
                HeavenUnits.Sister.Count++;
                GameWindow.player.Gold -= HeavenUnits.Sister.Cost.PriceInGold;
            }
            else if (sender == button8)
            {
                AddUnit(textBox4, HeavenUnits.Griffin);
                HeavenUnits.Griffin.Count++;
                GameWindow.player.Gold -= HeavenUnits.Griffin.Cost.PriceInGold;
            }
            else if (sender == button10)
            {
                AddUnit(textBox5, HeavenUnits.Celestial);
                HeavenUnits.Celestial.Count++;
                GameWindow.player.Gold -= HeavenUnits.Celestial.Cost.PriceInGold;
            }
        }

        private void AddUnit(TextBox textbox, Unit unit)
        {
            if (GameWindow.player.Gold >= unit.Cost.PriceInGold)
            {
                textbox.Text = (int.Parse(textbox.Text) + 1).ToString();
                textBox6.Text = (int.Parse(textBox6.Text) - unit.Cost.PriceInGold).ToString();
                unit.Count++;
                GameWindow.player.Gold -= unit.Cost.PriceInGold;
            }
            else
            {
                MessageBox.Show("Not enough gold!");
            }
        }
    }
}
