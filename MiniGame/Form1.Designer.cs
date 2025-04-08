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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playersPanel = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.player2tB = new System.Windows.Forms.TextBox();
            this.player1tB = new System.Windows.Forms.TextBox();
            this.Player2Pb = new System.Windows.Forms.PictureBox();
            this.Player1Pb = new System.Windows.Forms.PictureBox();
            this.mapPb = new System.Windows.Forms.PictureBox();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.themeSelectorMs = new System.Windows.Forms.ToolStripMenuItem();
            this.kékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sárgaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zöldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.directionsPanel = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.playersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapPb)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.directionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playersPanel
            // 
            this.playersPanel.Controls.Add(this.SaveBtn);
            this.playersPanel.Controls.Add(this.label2);
            this.playersPanel.Controls.Add(this.label1);
            this.playersPanel.Controls.Add(this.player2tB);
            this.playersPanel.Controls.Add(this.player1tB);
            this.playersPanel.Location = new System.Drawing.Point(38, 268);
            this.playersPanel.Margin = new System.Windows.Forms.Padding(4);
            this.playersPanel.Name = "playersPanel";
            this.playersPanel.Size = new System.Drawing.Size(267, 151);
            this.playersPanel.TabIndex = 2;
            this.playersPanel.Visible = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(84, 106);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(100, 28);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Mentés";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Játékos 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Játékos 1";
            // 
            // player2tB
            // 
            this.player2tB.Location = new System.Drawing.Point(117, 60);
            this.player2tB.Margin = new System.Windows.Forms.Padding(4);
            this.player2tB.Name = "player2tB";
            this.player2tB.Size = new System.Drawing.Size(132, 22);
            this.player2tB.TabIndex = 4;
            // 
            // player1tB
            // 
            this.player1tB.Location = new System.Drawing.Point(117, 17);
            this.player1tB.Margin = new System.Windows.Forms.Padding(4);
            this.player1tB.Name = "player1tB";
            this.player1tB.Size = new System.Drawing.Size(132, 22);
            this.player1tB.TabIndex = 3;
            // 
            // Player2Pb
            // 
            this.Player2Pb.Image = ((System.Drawing.Image)(resources.GetObject("Player2Pb.Image")));
            this.Player2Pb.Location = new System.Drawing.Point(351, 500);
            this.Player2Pb.Margin = new System.Windows.Forms.Padding(4);
            this.Player2Pb.Name = "Player2Pb";
            this.Player2Pb.Size = new System.Drawing.Size(200, 154);
            this.Player2Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player2Pb.TabIndex = 8;
            this.Player2Pb.TabStop = false;
            this.Player2Pb.Tag = "";
            this.Player2Pb.Visible = false;
            this.Player2Pb.Click += new System.EventHandler(this.MovePlayer);
            // 
            // Player1Pb
            // 
            this.Player1Pb.Image = ((System.Drawing.Image)(resources.GetObject("Player1Pb.Image")));
            this.Player1Pb.Location = new System.Drawing.Point(351, 38);
            this.Player1Pb.Margin = new System.Windows.Forms.Padding(4);
            this.Player1Pb.Name = "Player1Pb";
            this.Player1Pb.Size = new System.Drawing.Size(200, 154);
            this.Player1Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player1Pb.TabIndex = 6;
            this.Player1Pb.TabStop = false;
            this.Player1Pb.Tag = "";
            this.Player1Pb.Visible = false;
            this.Player1Pb.Click += new System.EventHandler(this.MovePlayer);
            // 
            // mapPb
            // 
            this.mapPb.Image = global::MiniGame.Properties.Resources.kék;
            this.mapPb.Location = new System.Drawing.Point(351, 38);
            this.mapPb.Margin = new System.Windows.Forms.Padding(4);
            this.mapPb.Name = "mapPb";
            this.mapPb.Size = new System.Drawing.Size(800, 615);
            this.mapPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPb.TabIndex = 3;
            this.mapPb.TabStop = false;
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(0, 20);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(138, 20);
            this.statusLabel.Text = "Válassza ki a témát!";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 699);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1213, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // themeSelectorMs
            // 
            this.themeSelectorMs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kékToolStripMenuItem,
            this.sárgaToolStripMenuItem,
            this.zöldToolStripMenuItem});
            this.themeSelectorMs.Name = "themeSelectorMs";
            this.themeSelectorMs.Size = new System.Drawing.Size(117, 24);
            this.themeSelectorMs.Text = "Téma választó";
            // 
            // kékToolStripMenuItem
            // 
            this.kékToolStripMenuItem.Name = "kékToolStripMenuItem";
            this.kékToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kékToolStripMenuItem.Text = "Kék";
            this.kékToolStripMenuItem.Click += new System.EventHandler(this.ThemeClick);
            // 
            // sárgaToolStripMenuItem
            // 
            this.sárgaToolStripMenuItem.Name = "sárgaToolStripMenuItem";
            this.sárgaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sárgaToolStripMenuItem.Text = "Sárga";
            this.sárgaToolStripMenuItem.Click += new System.EventHandler(this.ThemeClick);
            // 
            // zöldToolStripMenuItem
            // 
            this.zöldToolStripMenuItem.Name = "zöldToolStripMenuItem";
            this.zöldToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zöldToolStripMenuItem.Text = "Zöld";
            this.zöldToolStripMenuItem.Click += new System.EventHandler(this.ThemeClick);
            // 
            // playersMenuStrip
            // 
            this.playersMenuStrip.Enabled = false;
            this.playersMenuStrip.Name = "playersMenuStrip";
            this.playersMenuStrip.Size = new System.Drawing.Size(160, 24);
            this.playersMenuStrip.Text = "Játékosok megadása";
            this.playersMenuStrip.Click += new System.EventHandler(this.GetPlayers);
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.névjegyToolStripMenuItem.Text = "Névjegy";
            this.névjegyToolStripMenuItem.Click += new System.EventHandler(this.ShowMakers);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeSelectorMs,
            this.playersMenuStrip,
            this.névjegyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1213, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // directionsPanel
            // 
            this.directionsPanel.Controls.Add(this.radioButton4);
            this.directionsPanel.Controls.Add(this.radioButton3);
            this.directionsPanel.Controls.Add(this.radioButton2);
            this.directionsPanel.Controls.Add(this.radioButton1);
            this.directionsPanel.Location = new System.Drawing.Point(49, 261);
            this.directionsPanel.Name = "directionsPanel";
            this.directionsPanel.Size = new System.Drawing.Size(242, 163);
            this.directionsPanel.TabIndex = 9;
            this.directionsPanel.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(107, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fel";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 69);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(60, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Balra";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(107, 127);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Le";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(157, 69);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton4.Size = new System.Drawing.Size(71, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Jobbra";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 725);
            this.Controls.Add(this.directionsPanel);
            this.Controls.Add(this.Player2Pb);
            this.Controls.Add(this.Player1Pb);
            this.Controls.Add(this.mapPb);
            this.Controls.Add(this.playersPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Kincskereső 2025";
            this.playersPanel.ResumeLayout(false);
            this.playersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapPb)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.directionsPanel.ResumeLayout(false);
            this.directionsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel playersPanel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox player2tB;
        private System.Windows.Forms.TextBox player1tB;
        private System.Windows.Forms.PictureBox mapPb;
        private System.Windows.Forms.PictureBox Player1Pb;
        private System.Windows.Forms.PictureBox Player2Pb;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem themeSelectorMs;
        private System.Windows.Forms.ToolStripMenuItem kékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sárgaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zöldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel directionsPanel;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

