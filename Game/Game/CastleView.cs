using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class CastleView : Form
    {
        public CastleView()
        {
            InitializeComponent();
        }

        private void CastleView_Load(object sender, EventArgs e)
        {

        }

        private void CastleView_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //private void u1plus_Click(object sender, EventArgs e)
        //{
        //    this.firstUnit.Text += 1;
        //    log = firstUnit.Text;
        //}

        private void u1minus_Click(object sender, EventArgs e)
        {
            this.firstUnit.Text += -1;
        }
    }
}
