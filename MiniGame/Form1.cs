using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string player1 = string.Empty;
        string player2 = string.Empty;
        public Form1()
        {
            InitializeComponent();
            statusBar.Text = "Válassza ki a témat.";
        }

        private void GetPlayers(object sender, EventArgs e)
        {
            if (!playersPanel.Visible)
            {
                playersPanel.Visible = true;

                foreach (Control control in playersPanel.Controls)
                {
                    control.Enabled = true;
                }

            }
            else 
            { 
                playersPanel.Visible = false;

                foreach (Control control in playersPanel.Controls)
                {
                    control.Enabled = false;
                }

            }
        }

        private void ThemeClick(object sender, EventArgs e)
        {
            ToolStripMenuItem theme = sender as ToolStripMenuItem;

            mapPb.Image = Image.FromFile($@"{Directory.GetCurrentDirectory()}\images\{theme.Text.ToLower()}.png");

            themeSelectorTSM.Enabled = false;

            statusBar.Text = "Adja meg a neveket.";

            playersMenuStrip.Enabled = true;
        }

        private void ShowMakers(object sender, EventArgs e)
        {
            MessageBox.Show("Készítette:\nÁbrahám-Fúrús Csaba\nPaplukács Levente\n2025-26", "Névjegy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(player1tB.Text == string.Empty || player2tB.Text == string.Empty)
            {
                statusBar.Text = "Töltse ki mind a kettő név mezőt.";
            }
            else if(player1tB.Text.ToLower() == player2tB.Text.ToLower())
            {
                statusBar.Text = "A két név nem lehet ugyan az.";
            }
            else
            {
                player1 = player1tB.Text;
                player2 = player2tB.Text;

                playersMenuStrip.Enabled = false;

                statusBar.Text = $"A játék elkezdőtött. {player1} lép";

                Player1Pb.Visible = true;
                Player2Pb.Visible = true;

                playersPanel.Visible = false;

                movementscB.Visible = true;
            }

        }
        private void MovePb(object sender, EventArgs e)
        {
            PictureBox CurrentPicture = sender as PictureBox;
            if(movementscB.SelectedItem != null)
            {
            switch(movementscB.SelectedItem.ToString())
                {
                    case "Fel":
                        CurrentPicture.Location = new Point(CurrentPicture.Location.X, CurrentPicture.Location.Y - 123);
                        break;
                    case "Le":
                        CurrentPicture.Location = new Point(CurrentPicture.Location.X, CurrentPicture.Location.Y + 125);
                        break;
                    case "Bal":
                        CurrentPicture.Location = new Point(CurrentPicture.Location.X - 150, CurrentPicture.Location.Y);
                        break;
                    case "Jobb":
                        CurrentPicture.Location = new Point(CurrentPicture.Location.X + 150, CurrentPicture.Location.Y);
                        break;
                }
            }
        }

        static private bool IsPossibleMove()
        {
            bool possible = true;



            return possible;
        }
    }
}
