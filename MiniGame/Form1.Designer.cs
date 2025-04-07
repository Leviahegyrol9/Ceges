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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.themeSelectorTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.kékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sárgaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zöldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersPanel = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.player2tB = new System.Windows.Forms.TextBox();
            this.player1tB = new System.Windows.Forms.TextBox();
            this.movementscB = new System.Windows.Forms.ComboBox();
            this.Player2Pb = new System.Windows.Forms.PictureBox();
            this.Player1Pb = new System.Windows.Forms.PictureBox();
            this.mapPb = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.playersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapPb)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(910, 22);
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
            this.themeSelectorTSM,
            this.playersMenuStrip,
            this.névjegyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // themeSelectorTSM
            // 
            this.themeSelectorTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kékToolStripMenuItem,
            this.sárgaToolStripMenuItem,
            this.zöldToolStripMenuItem});
            this.themeSelectorTSM.Name = "themeSelectorTSM";
            this.themeSelectorTSM.Size = new System.Drawing.Size(92, 20);
            this.themeSelectorTSM.Text = "Téma választó";
            // 
            // kékToolStripMenuItem
            // 
            this.kékToolStripMenuItem.Name = "kékToolStripMenuItem";
            this.kékToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.kékToolStripMenuItem.Text = "Kék";
            this.kékToolStripMenuItem.Click += new System.EventHandler(this.ThemeClick);
            // 
            // sárgaToolStripMenuItem
            // 
            this.sárgaToolStripMenuItem.Name = "sárgaToolStripMenuItem";
            this.sárgaToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.sárgaToolStripMenuItem.Text = "Sárga";
            this.sárgaToolStripMenuItem.Click += new System.EventHandler(this.ThemeClick);
            // 
            // zöldToolStripMenuItem
            // 
            this.zöldToolStripMenuItem.Name = "zöldToolStripMenuItem";
            this.zöldToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.zöldToolStripMenuItem.Text = "Zöld";
            this.zöldToolStripMenuItem.Click += new System.EventHandler(this.ThemeClick);
            // 
            // playersMenuStrip
            // 
            this.playersMenuStrip.Enabled = false;
            this.playersMenuStrip.Name = "playersMenuStrip";
            this.playersMenuStrip.Size = new System.Drawing.Size(127, 20);
            this.playersMenuStrip.Text = "Játékosok megadása";
            this.playersMenuStrip.Click += new System.EventHandler(this.GetPlayers);
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.névjegyToolStripMenuItem.Text = "Névjegy";
            this.névjegyToolStripMenuItem.Click += new System.EventHandler(this.ShowMakers);
            // 
            // playersPanel
            // 
            this.playersPanel.Controls.Add(this.SaveBtn);
            this.playersPanel.Controls.Add(this.label2);
            this.playersPanel.Controls.Add(this.label1);
            this.playersPanel.Controls.Add(this.player2tB);
            this.playersPanel.Controls.Add(this.player1tB);
            this.playersPanel.Location = new System.Drawing.Point(0, 237);
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
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
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
            // player2tB
            // 
            this.player2tB.Location = new System.Drawing.Point(88, 49);
            this.player2tB.Name = "player2tB";
            this.player2tB.Size = new System.Drawing.Size(100, 20);
            this.player2tB.TabIndex = 4;
            // 
            // player1tB
            // 
            this.player1tB.Location = new System.Drawing.Point(88, 14);
            this.player1tB.Name = "player1tB";
            this.player1tB.Size = new System.Drawing.Size(100, 20);
            this.player1tB.TabIndex = 3;
            // 
            // movementscB
            // 
            this.movementscB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.movementscB.FormattingEnabled = true;
            this.movementscB.Items.AddRange(new object[] {
            "Bal",
            "Jobb",
            "Fel",
            "Le"});
            this.movementscB.Location = new System.Drawing.Point(17, 62);
            this.movementscB.Name = "movementscB";
            this.movementscB.Size = new System.Drawing.Size(217, 21);
            this.movementscB.TabIndex = 7;
            this.movementscB.Visible = false;
            // 
            // Player2Pb
            // 
            this.Player2Pb.Image = ((System.Drawing.Image)(resources.GetObject("Player2Pb.Image")));
            this.Player2Pb.Location = new System.Drawing.Point(263, 146);
            this.Player2Pb.Name = "Player2Pb";
            this.Player2Pb.Size = new System.Drawing.Size(150, 125);
            this.Player2Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player2Pb.TabIndex = 8;
            this.Player2Pb.TabStop = false;
            this.Player2Pb.Tag = "2";
            this.Player2Pb.Visible = false;
            this.Player2Pb.Click += new System.EventHandler(this.MovePb);
            // 
            // Player1Pb
            // 
            this.Player1Pb.Image = ((System.Drawing.Image)(resources.GetObject("Player1Pb.Image")));
            this.Player1Pb.Location = new System.Drawing.Point(263, 31);
            this.Player1Pb.Name = "Player1Pb";
            this.Player1Pb.Size = new System.Drawing.Size(150, 125);
            this.Player1Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player1Pb.TabIndex = 6;
            this.Player1Pb.TabStop = false;
            this.Player1Pb.Tag = "1";
            this.Player1Pb.Visible = false;
            this.Player1Pb.Click += new System.EventHandler(this.MovePb);
            // 
            // mapPb
            // 
            this.mapPb.Image = global::MiniGame.Properties.Resources.kék;
            this.mapPb.Location = new System.Drawing.Point(263, 31);
            this.mapPb.Name = "mapPb";
            this.mapPb.Size = new System.Drawing.Size(600, 500);
            this.mapPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPb.TabIndex = 3;
            this.mapPb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 589);
            this.Controls.Add(this.Player2Pb);
            this.Controls.Add(this.movementscB);
            this.Controls.Add(this.Player1Pb);
            this.Controls.Add(this.mapPb);
            this.Controls.Add(this.playersPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kincskereső 2025";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.playersPanel.ResumeLayout(false);
            this.playersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themeSelectorTSM;
        private System.Windows.Forms.ToolStripMenuItem playersMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        private System.Windows.Forms.Panel playersPanel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox player2tB;
        private System.Windows.Forms.TextBox player1tB;
        private System.Windows.Forms.ToolStripMenuItem kékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sárgaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zöldToolStripMenuItem;
        private System.Windows.Forms.PictureBox mapPb;
        private System.Windows.Forms.PictureBox Player1Pb;
        private System.Windows.Forms.ComboBox movementscB;
        private System.Windows.Forms.PictureBox Player2Pb;
    }
}

