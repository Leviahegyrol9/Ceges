using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Form1 : Form
    {
        string player1;
        string player2;
        int activePlayer = 1;
        Point anotherLocation = new Point(0,0);
        Point treasure = new Point(713, 406);
        public Form1()
        {
            InitializeComponent();

            List<Point> pointsToWin2 = new List<Point>
            {
                new Point(413,406),
                new Point(563, 281),
                new Point(713, 156)
            };

            List<Point> pointsToWin3 = new List<Point>
            {
                new Point(263, 406),
                new Point(413, 281),
                new Point(563, 156),
                new Point(713, 31)
            };

            List<Point> pointsToWin4 = new List<Point>
            {
                new Point(263,281),
                new Point(413, 156),
                new Point(563, 31)
            };

            List<Point> pointsToWin5 = new List<Point>
            {
                new Point(263, 156),
                new Point(413, 31)
            };

            List<List<Point>> pointLists = new List<List<Point>> { pointsToWin2, pointsToWin3, pointsToWin4, pointsToWin5 };

            Random rnd = new Random();

            List<Point> choosenList = pointLists[rnd.Next(pointLists.Count)];

            int choosenListIndex1 = rnd.Next(choosenList.Count);
            int choosenListIndex2;

            do
            {
                choosenListIndex2 = rnd.Next(choosenList.Count);
            } while (choosenListIndex2 == choosenListIndex1);

            Player1Pb.Location = choosenList[choosenListIndex1];
            Player2Pb.Location = choosenList[choosenListIndex2];
        }
        private void ThemeClick(object sender, EventArgs e)
        {
            ToolStripMenuItem theme = sender as ToolStripMenuItem;

            mapPb.Image = Image.FromFile($@"{Directory.GetCurrentDirectory()}\images\{theme.Text.ToLower()}.png");

            themeSelectorTSM.Enabled = false;

            statusLabel.Text = "Adja meg a neveket.";

            playersMenuStrip.Enabled = true;
        }
        private void GetPlayers(object sender, EventArgs e)
        {
            if (!playersPanel.Visible) playersPanel.Visible = true;          
        }    
        private void ShowMakers(object sender, EventArgs e)
        {
            MessageBox.Show("Készítette:\nÁbrahám-Fúrús Csaba\nPaplukács Levente\n2025-26", "Névjegy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (playersPanel.Controls.OfType<TextBox>().Any(tB => tB.Text == string.Empty))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Töltse ki a mezőket!";
            }
            else if(player1tB.Text.ToLower() == player2tB.Text.ToLower())
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "A két név nem lehet ugyan az.";
            }
            else if (playersPanel.Controls.OfType<TextBox>().Any(tB => tB.Text.Length > 20))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Túl hosszú név";
            }
            else
            {
                foreach (PictureBox pB in this.Controls.OfType<PictureBox>())
                {
                    pB.Visible = true;
                }

                playersMenuStrip.Enabled = false;
                playersPanel.Visible = false;
                directionsPanel.Visible = true;

                player1 = player1tB.Text.Trim();
                player2 = player2tB.Text.Trim();

                statusLabel.ForeColor = Color.Black;
                statusLabel.Text = $"A játék elkezdőtött. {player1} lép";
            }

        }
        private void MovePb(object sender, EventArgs e)
        {
            PictureBox currentPicture = sender as PictureBox;

            if (activePlayer == int.Parse(currentPicture.Tag.ToString()))
            {
                if (IsMove(statusLabel, directionsPanel.Controls.OfType<RadioButton>().Where(rB => rB.Checked).Single().Text, currentPicture, anotherLocation))
                {
                    statusLabel.ForeColor = Color.Black;
                    anotherLocation = currentPicture.Location;
                    if (currentPicture.Location == treasure)
                    {
                        MessageBox.Show($"Gratulálok {(activePlayer == 1 ? player1 : player2)}, Ön nyert.");
                        statusLabel.Text = $"{(activePlayer == 1 ? player1 : player2)} megnyerte a játékot.";
                        Player1Pb.Enabled = false;
                        Player2Pb.Enabled = false;
                        directionsPanel.Enabled = false;
                    }
                    else if (activePlayer == 1)
                    {                      
                        statusLabel.Text = $"{player2} lép";
                        Player1Pb.Enabled = false;
                        Player2Pb.Enabled = true;
                        Player2Pb.BorderStyle = BorderStyle.Fixed3D;
                        Player1Pb.BorderStyle = BorderStyle.None;
                        activePlayer = 2;
                    }
                    else
                    {
                        statusLabel.Text = $"{player1} lép";
                        Player2Pb.Enabled = false;
                        Player1Pb.Enabled = true;
                        Player1Pb.BorderStyle = BorderStyle.Fixed3D;
                        Player2Pb.BorderStyle = BorderStyle.None;
                        activePlayer = 1;
                    }                 
                }
            }           
        }
        private bool IsMove(ToolStripStatusLabel statusLabel, string direction, PictureBox currentPicture, Point anotherLocation)
        {
            statusLabel.ForeColor = Color.Red;

            switch (direction)
            {
                case "Fel":
                    if (currentPicture.Location.Y == 31)
                    {
                        statusLabel.Text = "Érvénytelen lépés!";
                        return false;
                    }
                    else if(currentPicture.Location.Y - 125 == anotherLocation.Y && currentPicture.Location.X == anotherLocation.X)
                    {                      
                        statusLabel.Text = "Az a mező már foglalt!";
                        return false;
                    }
                    else
                    {
                        currentPicture.Location = new Point(currentPicture.Location.X, currentPicture.Location.Y - 125);
                        return true;
                    }

                case "Le":
                    if (currentPicture.Location.Y == 406)
                    {
                        statusLabel.Text = "Érvénytelen lépés!";
                        return false;
                    }
                    else if (currentPicture.Location.Y + 125 == anotherLocation.Y && currentPicture.Location.X == anotherLocation.X)
                    {
                        statusLabel.Text = "Az a mező már foglalt!";
                        return false;
                    }
                    else
                    {
                        currentPicture.Location = new Point(currentPicture.Location.X, currentPicture.Location.Y + 125);
                        return true;
                    }

                case "Balra":
                    if (currentPicture.Location.X == 263)
                    {
                        statusLabel.Text = "Érvénytelen lépés!";
                        return false;
                    }
                    else if (currentPicture.Location.X - 150 == anotherLocation.X && currentPicture.Location.Y == anotherLocation.Y)
                    {
                        statusLabel.Text = "Az a mező már foglalt!";
                        return false;
                    }
                    else
                    {
                        currentPicture.Location = new Point(currentPicture.Location.X - 150, currentPicture.Location.Y);
                        return true;
                    }

                case "Jobbra":
                    if (currentPicture.Location.X == 713)
                    {
                        statusLabel.Text = "Érvénytelen lépés!";
                        return false;
                    }
                    else if (currentPicture.Location.X + 150 == anotherLocation.X && currentPicture.Location.Y == anotherLocation.Y)
                    {
                        statusLabel.Text = "Az a mező már foglalt!";
                        return false;
                    }
                    else
                    {
                        currentPicture.Location = new Point(currentPicture.Location.X + 150, currentPicture.Location.Y);
                        return true;
                    }
            }
            return false;
        }

        private void Restart(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Biztosan újra akarod kezdeni?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void gitHubClick(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Leviahegyrol9/Ceges");
        }
    }
}
