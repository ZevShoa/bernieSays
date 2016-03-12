///Zev Shoag 
/// March 7th
/// A Simon says game based around Bernie Sanders


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
using System.Media;

namespace bernieSays
{
    public partial class playScreen : UserControl
    {
        // created all my variables
        int listNum = 0;
        int randNum;
        int patternNum = -1;
        int patternSpot =0 ;
        int buttonWhere;
        //The only thing I needed public was my list
        public static List<int> pattern = new List<int>();
        Button[] buttons = new Button[4];

        Image[] bernies = { Properties.Resources.bernie0, Properties.Resources.bernie1, 
        Properties.Resources.bernie2,Properties.Resources.bernie3};
        string[] phrases = { "Save the Environment!", "Fight Against the Richest One Percent!",
         "Socialized Medicare!","Save the Environment!"};

        SoundPlayer player = new SoundPlayer(Properties.Resources.bing);

        Random choose = new Random();
        public playScreen()
        {
            buttons[0] = buttonChoose0;
            InitializeComponent();
            
        }
         
        private void playScreen_Load(object sender, EventArgs e)
        {
            //adds the buttons to the list
            buttons[0] = buttonChoose0;
            buttons[1] = buttonChoose1;
            buttons[2] = buttonChoose2;
            buttons[3] = buttonChoose3;
            //clear the pattern to start the new game
            pattern.Clear();
            Refresh();
            Thread.Sleep(500);
            computerTurn();
            

        }
        public void computerTurn()
        {
            //all this is the computer clicking the buttons
            patternSpot = 0;
            patternNum++;
            randNum = choose.Next(0, 4);
            pattern.Add(randNum);
            
            listNum = pattern.Count();
            for (int i =0;i <listNum; i++)
            {
                if (pattern[i] == 0)
                {
                  
                    buttonChoose0.BackgroundImage = Properties.Resources.bernie0;
                    buttonChoose0.Text = "";
                    player.Play();
                    Refresh();
                    Thread.Sleep(1000);
                    buttonChoose0.BackgroundImage = null;
                    buttonChoose0.Text = "Save the Environment";
                    Thread.Sleep(500);

                    Refresh();
                }
                else if (pattern[i] == 1)
                {
                   
                    buttonChoose1.BackgroundImage = Properties.Resources.bernie1;
                    buttonChoose1.Text = "";
                    player.Play();
                    Refresh();
                    Thread.Sleep(1000);
                    buttonChoose1.BackgroundImage = null;
                    buttonChoose1.Text = "Fight Against the Richest One Percent";
                    Thread.Sleep(500);
                    Refresh();

                }
                else if (pattern[i] == 2)
                {
              
                    buttonChoose2.BackgroundImage = Properties.Resources.bernie2;
                    buttonChoose2.Text = "";
                    player.Play();
                    Refresh();
                    Thread.Sleep(1000);
                    buttonChoose2.BackgroundImage = null;
                    buttonChoose2.Text = "Socialized Medicare";
                    Thread.Sleep(500);
                    Refresh();
                }
                else if (pattern[i] == 3)
                {
               
                    buttonChoose3.BackgroundImage = Properties.Resources.bernie3;
                    buttonChoose3.Text = "";
                    player.Play();
                    Refresh();
                    Thread.Sleep(1000);
                    buttonChoose3.BackgroundImage = null;
                    buttonChoose3.Text = "Social Justice";
                    Thread.Sleep(500);
                    Refresh();
                }

            }
            //resets the random number for next time
            randNum = 0;

        }
        public void buttonsClicks()
        {
           
            
        }

        private void buttonChoose0_Click(object sender, EventArgs e)
        {
           
            // when the user chooses one of the buttons this sees if it is the right button
            if (pattern[patternSpot] == 0)
            {
                player.Play();
                buttonChoose0.BackgroundImage = Properties.Resources.bernie0;
                buttonChoose0.Text = "";
                Refresh();
                Thread.Sleep(1000);
                buttonChoose0.BackgroundImage = null;
                buttonChoose0.Text = "Save the Environment";
                patternSpot++;
                
                if (patternSpot == pattern.Count)
                {
                    computerTurn();
                }
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.loose);
                player.Play();
                Form f = this.FindForm();
                f.Controls.Remove(this);

                endScreen es = new endScreen();
                f.Controls.Add(es);
            }
        }

        private void buttonChoose1_Click(object sender, EventArgs e)
        {
            // when the user chooses one of the buttons this sees if it is the right button
            if (pattern[patternSpot] == 1)
            {
                player.Play();
                buttonChoose1.BackgroundImage = Properties.Resources.bernie1;
                buttonChoose1.Text = "";
                Refresh();
                Thread.Sleep(1000);
                buttonChoose1.BackgroundImage = null;
                buttonChoose1.Text = "Fight Against the Richest One Percent";
                patternSpot++;
           
                if (patternSpot == pattern.Count)
                {
                    computerTurn();
                }
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.loose);
                player.Play();

                Form f = this.FindForm();
                f.Controls.Remove(this);

                endScreen es = new endScreen();
                f.Controls.Add(es);
            }

        }

        private void buttonChoose2_Click(object sender, EventArgs e)
        {
            // when the user chooses one of the buttons this sees if it is the right button
            if (pattern[patternSpot] == 2)
            {
                player.Play();  
                buttonChoose2.BackgroundImage = Properties.Resources.bernie2;
                buttonChoose2.Text = "";
                Refresh();
                Thread.Sleep(1000);
                buttonChoose2.BackgroundImage = null;
                buttonChoose2.Text = "Socialized Medicare";
                patternSpot++;
                
                if (patternSpot == pattern.Count)
                {
                    computerTurn();
                }
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.loose);
                player.Play();
                Form f = this.FindForm();
                f.Controls.Remove(this);

               endScreen es = new endScreen();
                f.Controls.Add(es);
            }
        }

        private void buttonChoose3_Click(object sender, EventArgs e)
        {
            
            // when the user chooses one of the buttons this sees if it is the right button
            if (pattern [patternSpot] == 3)
            {
                player.Play();
                buttonChoose3.BackgroundImage = Properties.Resources.bernie3;
                buttonChoose3.Text = "";
                Refresh();
                Thread.Sleep(1000);
                buttonChoose3.BackgroundImage = null;
                buttonChoose3.Text = "Social Justice";
                patternSpot++;
               
                if (patternSpot == pattern.Count)
                {
                    computerTurn();
                }
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.loose);
                player.Play();
                Form f = this.FindForm();
                f.Controls.Remove(this);

                endScreen es = new endScreen();
                f.Controls.Add(es);
            }
        }
    }
}
