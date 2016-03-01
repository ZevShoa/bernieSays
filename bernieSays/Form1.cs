using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bernieSays
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            //goes to start screen
            startScreen ss = new startScreen();
            this.Controls.Add(ss);
        }
    }
}
