using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Form1 : Form
    {
        string player1;
        string player2;
        public Form1()
        {
            InitializeComponent();
        }

        private void GetPlayers(object sender, EventArgs e)
        {
            if (!playersPanel.Visible)
            {
                playersPanel.Visible = true;

                foreach (Control control in playersPanel.Controls.OfType<TextBox>())
                {
                    control.Enabled = true;
                }

            }
            else 
            { 
                playersPanel.Visible = false;

                foreach (Control control in playersPanel.Controls.OfType<TextBox>())
                {
                    control.Enabled = false;
                }

            }
        }

        private void ThemeClick(object sender, EventArgs e)
        {
            ToolStripMenuItem theme = sender as ToolStripMenuItem;

            mapPb.Image = Image.FromFile($@"{Directory.GetCurrentDirectory()}\images\{theme.Text.ToLower()}.png");

            themeSelectorMs.Enabled = false;

            statusLabel.Text = "Adja meg a neveket!";

            playersMenuStrip.Enabled = true;
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
            else if (player1tB.Text.ToLower() == player2tB.Text.ToLower())
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
        private void MovePlayer(object sender, EventArgs e)
        {
            PictureBox clickedPicture = sender as PictureBox;

            switch (directionsPanel.Controls.OfType<RadioButton>().Where(rb => rb.Checked).Single().Text)
                {
                    case "Fel":
                        clickedPicture.Location = new Point(clickedPicture.Location.X, clickedPicture.Location.Y - 125);
                        break;

                    case "Le":
                        clickedPicture.Location = new Point(clickedPicture.Location.X, clickedPicture.Location.Y + 125);
                        break;

                    case "Balra":
                        clickedPicture.Location = new Point(clickedPicture.Location.X - 150, clickedPicture.Location.Y);
                        break;

                    case "Jobbra":
                        clickedPicture.Location = new Point(clickedPicture.Location.X + 150, clickedPicture.Location.Y);
                        break;
                }
        }

        private bool IsPossibleMove()
        {
            bool possible = true;



            return possible;
        }
    }
}
