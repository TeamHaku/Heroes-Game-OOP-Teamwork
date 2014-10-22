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
    using TestForm.Player;
    using TestForm.Units;

    public partial class InfernoCastle : Form
    {
        public InfernoCastle()
        {
            InitializeComponent();
            UnitsCount();

            textBox6.Text = GameWindow.Player.Gold.ToString();
        }

        private void UnitsCount()
        {
            textBox1.Text = InfernoCreatures.Maniac.Count.ToString();
            textBox2.Text = InfernoCreatures.Cerberus.Count.ToString();
            textBox3.Text = InfernoCreatures.Lilim.Count.ToString();
            textBox4.Text = InfernoCreatures.Lacerator.Count.ToString();
            textBox5.Text = InfernoCreatures.PitLord.Count.ToString();
        }

        private void InsertUnit(object sender, MouseEventArgs e)
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
