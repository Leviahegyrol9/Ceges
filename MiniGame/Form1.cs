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
        public Form1()
        {
            InitializeComponent();
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
        }
    }
}
