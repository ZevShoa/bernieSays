﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bernieSays
{
    public partial class endScreen : UserControl
    {

        int patternCount;
        public endScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            startScreen ss = new startScreen();
            f.Controls.Add(ss);
        }

        private void endScreen_Load(object sender, EventArgs e)
        {
            patternCount = playScreen.pattern.Count;
            patternLabel.Text = "You got to " + Convert.ToString(patternCount);
        }
    }
}
