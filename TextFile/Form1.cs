using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace TextFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region colours

        //used to store all the colours from the list locally
        List<string> colours = new List<string>();

        private void loadColoursButton_Click(object sender, EventArgs e)
        {

            DisplayColours();
        }

        private void saveColoursButton_Click(object sender, EventArgs e)
        {

        }

        private void sortColoursButton_Click(object sender, EventArgs e)
        {

        }

        private void addColourButton_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        public void DisplayColours()
        {
            colourOutput.Text = "";

            foreach(string colour in colours)
            {
                colourOutput.Text += $"{colour}\n";
            }
        }

        #endregion


        #region scores

        List<HighScore> scores = new List<HighScore>();

        private void loadScoresButton_Click(object sender, EventArgs e)
        {

            DisplayScores();
        }

        private void saveScoresButton_Click(object sender, EventArgs e)
        {

        }

        private void sortScoresButton_Click(object sender, EventArgs e)
        {

        }

        private void addScoreButton_Click(object sender, EventArgs e)
        {

        }

        private void removeScoresButton_Click(object sender, EventArgs e)
        {

        }

        public void DisplayScores()
        {
            scoreOutput.Text = "";

            foreach (HighScore hs in scores)
            {
                scoreOutput.Text += $"{hs.name} {hs.score}\n";
            }
        }

        #endregion
    }
}
