using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viragrendeles
{
    public partial class Form1 : Form
    {
        int orangeRose = 50;
        int redRose = 32;
        int geranium = 20;
        int dirt = 10;
        public Form1()
        {
            InitializeComponent();
            label1.Text = $"Sárga rózsa (0-{orangeRose})";
            label2.Text = $"Piros rózsa (0-{redRose})";
            label3.Text = $"Muskátli (0-{geranium})";
            label4.Text = $"Virágföld (0-{dirt})";
            label5.Text = $"Szállítás (házhoz, áruházban)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBox1.Text, out int orangeRoseInput) || !int.TryParse(textBox2.Text, out int redRoseInput) || !int.TryParse(textBox3.Text, out int geraniumInput) || !int.TryParse(textBox4.Text, out int dirtInput))
            {
                MessageBox.Show("Nem számot adott meg");
            }
            else if(textBox5.Text != "házhoz" && textBox5.Text != "áruházban")
            {
                MessageBox.Show("Nem jó szállítási helyet adott meg");
            }
            else if(orangeRose < orangeRoseInput ||
            redRose < redRoseInput ||
            geranium < geraniumInput ||
            dirt < dirtInput)
            {
                MessageBox.Show("Nem lehet ennyit venni.");
            }
            else
            {
                orangeRose -= orangeRoseInput;
                redRose -= redRoseInput;
                geranium -= geraniumInput;
                dirt -= dirtInput;

                label1.Text = $"Sárga rózsa (0-{orangeRose})";
                label2.Text = $"Piros rózsa (0-{redRose})";
                label3.Text = $"Muskátli (0-{geranium})";
                label4.Text = $"Virágföld (0-{dirt})";
                label5.Text = $"Szállítás (házhoz, áruházban)";

                listBox1.Items.Add($"Sárga rózsa: {orangeRoseInput}\tPiros rózsa: {redRoseInput}\tMuskátli: {geraniumInput}\tVirágföld: {dirtInput}\tSzállítás: {textBox5.Text}");
            }

            
        }
    }
}
