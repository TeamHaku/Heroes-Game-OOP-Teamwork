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
        public HeavenCastle(int gold)
        {
            InitializeComponent();
            UnitsCount();

            textBox6.Text = gold.ToString();
        }

        private void UnitsCount()
        {
            textBox1.Text = HeavenUnits.Sentinel.Count.ToString();
            textBox2.Text = HeavenUnits.Crossbowman.Count.ToString();
            textBox3.Text = HeavenUnits.Sister.Count.ToString();
            textBox4.Text = HeavenUnits.Griffin.Count.ToString();
            textBox5.Text = HeavenUnits.Celestial.Count.ToString();
        }

        private void AddUnit(object sender, MouseEventArgs e)
        {
            if (sender == button1)
            {
                textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
                textBox6.Text = (int.Parse(textBox6.Text) - HeavenUnits.Sentinel.Cost.PriceInGold).ToString();
                HeavenUnits.Sentinel.Count++;
                GameWindow.player.Gold -= HeavenUnits.Sentinel.Cost.PriceInGold;
            }
            else if (sender == button4)
            {
                textBox2.Text = (int.Parse(textBox2.Text) + 1).ToString();
                textBox6.Text = (int.Parse(textBox6.Text) - HeavenUnits.Crossbowman.Cost.PriceInGold).ToString();
                HeavenUnits.Crossbowman.Count++;
                GameWindow.player.Gold -= HeavenUnits.Crossbowman.Cost.PriceInGold;
            }
            else if (sender == button6)
            {
                textBox3.Text = (int.Parse(textBox3.Text) + 1).ToString();
                textBox6.Text = (int.Parse(textBox6.Text) - HeavenUnits.Sister.Cost.PriceInGold).ToString();
                HeavenUnits.Sister.Count++;
                GameWindow.player.Gold -= HeavenUnits.Sister.Cost.PriceInGold;
            }
            else if (sender == button8)
            {
                textBox4.Text = (int.Parse(textBox4.Text) + 1).ToString();
                textBox6.Text = (int.Parse(textBox6.Text) - HeavenUnits.Griffin.Cost.PriceInGold).ToString();
                HeavenUnits.Griffin.Count++;
                GameWindow.player.Gold -= HeavenUnits.Griffin.Cost.PriceInGold;
            }
            else if (sender == button10)
            {
                textBox5.Text = (int.Parse(textBox5.Text) + 1).ToString();
                textBox6.Text = (int.Parse(textBox6.Text) - HeavenUnits.Celestial.Cost.PriceInGold).ToString();
                HeavenUnits.Celestial.Count++;
                GameWindow.player.Gold -= HeavenUnits.Celestial.Cost.PriceInGold;
            }
        }

        //private void Shop()
        //{

        //}
    }
}
