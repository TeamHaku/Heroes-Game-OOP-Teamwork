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
    public partial class CastleView : Form
    {
        public CastleView(int gold)
        {
            InitializeComponent();
            goldBox.Text = gold.ToString();
        }

        private void u1plus_Click(object sender, EventArgs e)
        {
            var gold = int.Parse(goldBox.Text);
            if (gold >= 100)
            {
                gold -= 100;
                goldBox.Text = gold.ToString();
            }
            
        }

        private void u1minus_Click(object sender, EventArgs e)
        {
            var gold = int.Parse(goldBox.Text);
            gold += 100;
            goldBox.Text = gold.ToString();
            
        }
    }
}
