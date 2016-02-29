using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace bernieSays
{
    public partial class playScreen : UserControl
    {
        int listNum = 0;
        int randNum;
        List<int> pattern = new List<int>();
        Random choose = new Random();
        public playScreen()
        {
            InitializeComponent();
        }

        private void playScreen_Load(object sender, EventArgs e)
        {
            pattern.Clear();
            Refresh();
            Thread.Sleep(500);
            computerTurn();
        }
        public void computerTurn()
        {
            randNum = choose.Next(0, 4);
            pattern.Add(randNum);
            
                }

        private void buttonChoose0_Click(object sender, EventArgs e)
        {
            buttonChoose0.BackgroundImage = Properties.Resources.bernie0;
            buttonChoose0.Text = "";
            Refresh();
            Thread.Sleep(1000);
            buttonChoose0.BackgroundImage = null;
            buttonChoose0.Text = "Save the Enviroment";
        }

        private void buttonChoose1_Click(object sender, EventArgs e)
        {
            buttonChoose1.BackgroundImage = Properties.Resources.bernie1;
            buttonChoose1.Text = "";
            Refresh();
            Thread.Sleep(1000);
            buttonChoose1.BackgroundImage = null;
            buttonChoose1.Text = "Fight Against the Richest One Percent";

        }

        private void buttonChoose2_Click(object sender, EventArgs e)
        {
            buttonChoose2.BackgroundImage = Properties.Resources.bernie2;
            buttonChoose2.Text = "";
            Refresh();
            Thread.Sleep(1000);
            buttonChoose2.BackgroundImage = null;
            buttonChoose2.Text = "Socialized Medicare";
        }

        private void buttonChoose3_Click(object sender, EventArgs e)
        {
            buttonChoose3.BackgroundImage = Properties.Resources.bernie3;
            buttonChoose3.Text = "";
            Refresh();
            Thread.Sleep(1000);
            buttonChoose3.BackgroundImage = null;
            buttonChoose3.Text = "Social Justice";
        }
    }
}
