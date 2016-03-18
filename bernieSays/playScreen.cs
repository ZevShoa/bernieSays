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
        int randNum;
        int patternSpot =0 ;
       
        //The only thing I needed public was my list
        public static List<int> pattern = new List<int>();
        Button[] buttons = new Button[4];
        
        Image[] bernies = { Properties.Resources.bernie0, Properties.Resources.bernie1, 
        Properties.Resources.bernie2,Properties.Resources.bernie3};
        string[] phrases = { "Save the Environment!", "Fight Against the Richest One Percent!",
         "Socialized Medicare!","Social Justice!"};

        SoundPlayer player = new SoundPlayer(Properties.Resources.bing);

        Random choose = new Random();
        public playScreen()
        {
           
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
            randNum = choose.Next(0, 4);
            pattern.Add(randNum);
            
            
            for (int i =0;i < pattern.Count(); i++)
            {
                player.Play();
                buttons[pattern[i]].BackgroundImage = bernies[pattern[i]];
                buttons[pattern[i]].Text = "";
                Refresh();
                Thread.Sleep(500);
                buttons[pattern[i]].BackgroundImage = null;
                buttons[pattern[i]].Text = phrases[pattern[i]];
                patternSpot++;
                Thread.Sleep(500);
                Refresh();
            }
            
            //resets the random number for next time
            randNum = 0;
            patternSpot = 0;
        }
        public void buttonsClicks(int buttonNum)
        {
            if (pattern.Count() > patternSpot)
            {
                if (pattern[patternSpot] == buttonNum)
                {
                    player.Play();
                    buttons[pattern[patternSpot]].BackgroundImage = bernies[pattern[patternSpot]];
                    buttons[pattern[patternSpot]].Text = "";
                    Refresh();
                    Thread.Sleep(500);
                    buttons[pattern[patternSpot]].BackgroundImage = null;
                    buttons[pattern[patternSpot]].Text = phrases[pattern[patternSpot]];
                    Thread.Sleep(500);
                    Refresh();
                }
                else if (pattern.Count() > patternSpot)
                {
                    loose();
                }
                patternSpot++;
            }
            if (pattern.Count <= patternSpot)
            {
                computerTurn();
            }
        }
        public void loose()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.loose);
            player.Play();
            Form f = this.FindForm();
            f.Controls.Remove(this);

            endScreen es = new endScreen();
            f.Controls.Add(es);

        }

        private void buttonChoose0_Click(object sender, EventArgs e)
        {
           
            // when the user chooses one of the buttons this sees if it is the right button
                buttonsClicks(0);             
        }

        private void buttonChoose1_Click(object sender, EventArgs e)
        {
            // when the user chooses one of the buttons this sees if it is the right button
                buttonsClicks(1);

        }

        private void buttonChoose2_Click(object sender, EventArgs e)
        {
            // when the user chooses one of the buttons this sees if it is the right button
                buttonsClicks(2);

        }

        private void buttonChoose3_Click(object sender, EventArgs e)
        {
            
            // when the user chooses one of the buttons this sees if it is the right button
                buttonsClicks(3);
        }
    }
}
