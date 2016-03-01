using System;
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
    public partial class startScreen : UserControl
    {
        public startScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            playScreen ps = new playScreen();
            f.Controls.Add(ps);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
