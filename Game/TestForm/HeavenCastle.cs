﻿using System;
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

    public partial class HeavenCastle : Form
    {
        public HeavenCastle(int gold)
        {
            InitializeComponent();
            textBox6.Text = gold.ToString();
            DisplayUnits();
        }

        private void DisplayUnits()
        {

            foreach (var key in GameWindow.Player.WarUnits.Keys)
            {
                
            }
        }



    }
}
