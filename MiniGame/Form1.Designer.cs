namespace MiniGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.témaVálasztóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.játákosokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersPanel = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sárgaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zöldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapPb = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.playersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPb)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.témaVálasztóToolStripMenuItem,
            this.játákosokToolStripMenuItem,
            this.névjegyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // témaVálasztóToolStripMenuItem
            // 
            this.témaVálasztóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kékToolStripMenuItem,
            this.sárgaToolStripMenuItem,
            this.zöldToolStripMenuItem});
            this.témaVálasztóToolStripMenuItem.Name = "témaVálasztóToolStripMenuItem";
            this.témaVálasztóToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.témaVálasztóToolStripMenuItem.Text = "Téma választó";
            // 
            // játákosokToolStripMenuItem
            // 
            this.játákosokToolStripMenuItem.Name = "játákosokToolStripMenuItem";
            this.játákosokToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.játákosokToolStripMenuItem.Text = "Játákosok megadása";
            this.játákosokToolStripMenuItem.Click += new System.EventHandler(this.GetPlayers);
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.névjegyToolStripMenuItem.Text = "Névjegy";
            // 
            // playersPanel
            // 
            this.playersPanel.Controls.Add(this.SaveBtn);
            this.playersPanel.Controls.Add(this.label2);
            this.playersPanel.Controls.Add(this.label1);
            this.playersPanel.Controls.Add(this.textBox2);
            this.playersPanel.Controls.Add(this.textBox1);
            this.playersPanel.Location = new System.Drawing.Point(12, 238);
            this.playersPanel.Name = "playersPanel";
            this.playersPanel.Size = new System.Drawing.Size(200, 123);
            this.playersPanel.TabIndex = 2;
            this.playersPanel.Visible = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(63, 86);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Mentés";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Játékos 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Játékos 1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // kékToolStripMenuItem
            // 
            this.kékToolStripMenuItem.Name = "kékToolStripMenuItem";
            this.kékToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kékToolStripMenuItem.Text = "Kék";
            this.kékToolStripMenuItem.Click += new System.EventHandler(this.ThemeClick);
            // 
            // sárgaToolStripMenuItem
            // 
            this.sárgaToolStripMenuItem.Name = "sárgaToolStripMenuItem";
            this.sárgaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sárgaToolStripMenuItem.Text = "Sárga";
            this.sárgaToolStripMenuItem.Click += new System.EventHandler(this.ThemeClick);
            // 
            // zöldToolStripMenuItem
            // 
            this.zöldToolStripMenuItem.Name = "zöldToolStripMenuItem";
            this.zöldToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zöldToolStripMenuItem.Text = "Zöld";
            this.zöldToolStripMenuItem.Click += new System.EventHandler(this.ThemeClick);
            // 
            // mapPb
            // 
            this.mapPb.Location = new System.Drawing.Point(218, 40);
            this.mapPb.Name = "mapPb";
            this.mapPb.Size = new System.Drawing.Size(582, 370);
            this.mapPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPb.TabIndex = 3;
            this.mapPb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mapPb);
            this.Controls.Add(this.playersPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.playersPanel.ResumeLayout(false);
            this.playersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem témaVálasztóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem játákosokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        private System.Windows.Forms.Panel playersPanel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem kékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sárgaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zöldToolStripMenuItem;
        private System.Windows.Forms.PictureBox mapPb;
    }
}

