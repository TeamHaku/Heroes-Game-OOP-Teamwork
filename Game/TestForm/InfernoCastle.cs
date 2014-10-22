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
        public InfernoCastle(int gold)
        {
            InitializeComponent();
            UnitsCount();

            textBox6.Text = gold.ToString();
        }

        private void UnitsCount()
        {
            textBox1.Text = InfernoCreatures.Maniac.Count.ToString();
            textBox2.Text = InfernoCreatures.Cerberus.Count.ToString();
            textBox3.Text = InfernoCreatures.Lilim.Count.ToString();
            textBox4.Text = InfernoCreatures.Lacerator.Count.ToString();
            textBox5.Text = InfernoCreatures.PitLord.Count.ToString();
        }
    }
}
