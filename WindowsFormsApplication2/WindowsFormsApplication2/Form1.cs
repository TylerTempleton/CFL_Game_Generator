using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Created By Tyler Templeton Jan 18, 2017
        //This application attempts to simulate cfl games and show the winner and score 

        private void resetButton_Click(object sender, EventArgs e)
        {//reset button when click will clear off all selections, flags and labels and redisable play button
         //clear radio button selections in west team box
            westTeams.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);

            foreach (RadioButton radio in westTeams.Controls.OfType<RadioButton>().ToList())
            {
                if (radio.Checked == true)
                {
                    radio.Checked = false;
                    break;
                }

            }
            //clear radio button selections in east team box 
            eastTeams.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);

            foreach (RadioButton radio in eastTeams.Controls.OfType<RadioButton>().ToList())
            {
                if (radio.Checked == true)
                {
                    radio.Checked = false;
                    break;
                }

            }
            //Clear flag images and background images
            flagBox1.Image = null;
            flagBox2.Image = null;
          

           // reset play button to disabled
           playButton.Enabled = false;


            //reset labels and scores
            team1Label.Text = "Team 1";
            team2Label.Text = "Team 2";
            resetScores();
            
        }
        



        private void exitButton_Click(object sender, EventArgs e)
        {// onclick will close form application
            Close();

        }

        private void playButton_Click(object sender, EventArgs e)
        {// when enabled and clicked will randomly generate scores, determine winner and change the lables
            //gernerate score for team 1
            Random randTeam1 = new Random();

            int score1 = randTeam1.Next(5);
            score1 *= 7;
            teamScore1.Text = score1.ToString();

            //generate score for team 2
            Random randTeam2 = new Random(5);
            int score2 = randTeam1.Next(5);
            score2 *= 7;
            teamScore2.Text = score2.ToString();

            //winner determination and label updating
            

                if (score1 > score2)
            {
                winnerText.Text = team1Label.Text + " Wins!";
                BackgroundImage = flagBox1.Image;
            }
            else { 
                winnerText.Text = team2Label.Text + " Wins!";
                BackgroundImage = flagBox2.Image;
            }
            if (score1 == score2)
            {
                winnerText.Text = "It's a Tie!";
                BackgroundImage = null;
            }


        }

        private void westTeam1_CheckedChanged(object sender, EventArgs e)
        {// when press will show the teams flag and name on the left hand in the play area
            flagBox1.Image = Properties.Resources.lionslogo;
            team1Label.Text = "Lions";
            stuff();
        }

        private void WestTeam2_CheckedChanged(object sender, EventArgs e)
        {// when press will show the teams flag and name on the left hand in the play area
            flagBox1.Image = Properties.Resources.stamplogo;
            team1Label.Text = "Stampeders";
            stuff();
        }

        private void westTeam3_CheckedChanged(object sender, EventArgs e)
        {// when press will show the teams flag and name on the left hand in the play area
            flagBox1.Image = Properties.Resources.EElogo;
            team1Label.Text = "Eskimos";
            stuff();
        }

        private void westTeam4_CheckedChanged(object sender, EventArgs e)
        {// when press will show the teams flag and name on the left hand in the play area
            flagBox1.Image = Properties.Resources.bblogo;
            team1Label.Text = "Blue Bombers";
            stuff();
        }

        private void westTeam5_CheckedChanged(object sender, EventArgs e)
        {// when press will show the teams flag and name on the left hand in the play area
            flagBox1.Image = Properties.Resources.RRlogo;
            team1Label.Text = "RoughRiders";
            stuff();
        }

        private void eastTeam1_CheckedChanged(object sender, EventArgs e)
        {// when press will show the teams flag and name on the right hand in the play area
            flagBox2.Image = Properties.Resources.ticats;
            team2Label.Text = "TigerCats";
            stuff();
        }

        private void eastTeam2_CheckedChanged(object sender, EventArgs e)
        {// when press will show the teams flag and name on the right hand in the play area
            flagBox2.Image = Properties.Resources.alouetteslogo;
            team2Label.Text = "Alouettes";
            stuff();
        }

        private void eastTeam3_CheckedChanged(object sender, EventArgs e)
        {// when press will show the teams flag and name on the right hand in the play area
            flagBox2.Image = Properties.Resources.RBlogo;
            team2Label.Text = "Redblacks";
            stuff();
        }

        private void eastTeam4_CheckedChanged(object sender, EventArgs e)
        {// when press will show the teams flag and name on the right hand in the play area
            flagBox2.Image = Properties.Resources.argologo;
            team2Label.Text = "Argonaughts";
            stuff();


        }
        // resets scores
        private void resetScores() {
            BackgroundImage = null;
            winnerText.Text = "Winning Team";
            teamScore1.Text = null;
            teamScore2.Text = null;
        }
        //checks to see if 2 teams are selected to play
        private void timeToPlay(){
             if (flagBox1.Image != null && flagBox2.Image != null)
            {
                playButton.Enabled = true;
            }
            
        }
        private void stuff()
        {
            resetScores();
            timeToPlay();
        }
    }
}
