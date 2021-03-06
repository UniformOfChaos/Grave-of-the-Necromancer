﻿namespace GameWindow
{
    partial class GameWindow
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.playerInfoPanel = new System.Windows.Forms.Panel();
            this.levelLabel = new System.Windows.Forms.Label();
            this.mindLabel = new System.Windows.Forms.Label();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.manaLabel = new System.Windows.Forms.Label();
            this.levelNumber = new System.Windows.Forms.Label();
            this.mindNumber = new System.Windows.Forms.Label();
            this.bodyNumber = new System.Windows.Forms.Label();
            this.manaNumber = new System.Windows.Forms.Label();
            this.healthNumber = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.textInfoPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.infoText = new System.Windows.Forms.TextBox();
            this.dungeonInfoPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.playerInfoPanel.SuspendLayout();
            this.textInfoPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(4, 32);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(578, 267);
            this.mainPanel.TabIndex = 0;
            // 
            // playerInfoPanel
            // 
            this.playerInfoPanel.BackColor = System.Drawing.Color.BurlyWood;
            this.playerInfoPanel.Controls.Add(this.levelLabel);
            this.playerInfoPanel.Controls.Add(this.mindLabel);
            this.playerInfoPanel.Controls.Add(this.bodyLabel);
            this.playerInfoPanel.Controls.Add(this.manaLabel);
            this.playerInfoPanel.Controls.Add(this.levelNumber);
            this.playerInfoPanel.Controls.Add(this.mindNumber);
            this.playerInfoPanel.Controls.Add(this.bodyNumber);
            this.playerInfoPanel.Controls.Add(this.manaNumber);
            this.playerInfoPanel.Controls.Add(this.healthNumber);
            this.playerInfoPanel.Controls.Add(this.healthLabel);
            this.playerInfoPanel.Location = new System.Drawing.Point(4, 305);
            this.playerInfoPanel.Name = "playerInfoPanel";
            this.playerInfoPanel.Size = new System.Drawing.Size(170, 170);
            this.playerInfoPanel.TabIndex = 1;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.Location = new System.Drawing.Point(20, 134);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(65, 20);
            this.levelLabel.TabIndex = 0;
            this.levelLabel.Text = "LEVEL";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mindLabel
            // 
            this.mindLabel.AutoSize = true;
            this.mindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mindLabel.Location = new System.Drawing.Point(20, 101);
            this.mindLabel.Name = "mindLabel";
            this.mindLabel.Size = new System.Drawing.Size(54, 20);
            this.mindLabel.TabIndex = 0;
            this.mindLabel.Text = "MIND";
            this.mindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyLabel.Location = new System.Drawing.Point(20, 68);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(59, 20);
            this.bodyLabel.TabIndex = 0;
            this.bodyLabel.Text = "BODY";
            this.bodyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bodyLabel.Click += new System.EventHandler(this.bodyLabel_Click);
            // 
            // manaLabel
            // 
            this.manaLabel.AutoSize = true;
            this.manaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manaLabel.Location = new System.Drawing.Point(20, 38);
            this.manaLabel.Name = "manaLabel";
            this.manaLabel.Size = new System.Drawing.Size(59, 20);
            this.manaLabel.TabIndex = 0;
            this.manaLabel.Text = "MANA";
            this.manaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manaLabel.Click += new System.EventHandler(this.manaLabel_Click);
            // 
            // levelNumber
            // 
            this.levelNumber.AutoSize = true;
            this.levelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelNumber.Location = new System.Drawing.Point(105, 134);
            this.levelNumber.Name = "levelNumber";
            this.levelNumber.Size = new System.Drawing.Size(19, 20);
            this.levelNumber.TabIndex = 0;
            this.levelNumber.Text = "1";
            this.levelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.levelNumber.Click += new System.EventHandler(this.healthLabel_Click);
            // 
            // mindNumber
            // 
            this.mindNumber.AutoSize = true;
            this.mindNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mindNumber.Location = new System.Drawing.Point(105, 101);
            this.mindNumber.Name = "mindNumber";
            this.mindNumber.Size = new System.Drawing.Size(29, 20);
            this.mindNumber.TabIndex = 0;
            this.mindNumber.Text = "10";
            this.mindNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mindNumber.Click += new System.EventHandler(this.healthLabel_Click);
            // 
            // bodyNumber
            // 
            this.bodyNumber.AutoSize = true;
            this.bodyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyNumber.Location = new System.Drawing.Point(105, 68);
            this.bodyNumber.Name = "bodyNumber";
            this.bodyNumber.Size = new System.Drawing.Size(29, 20);
            this.bodyNumber.TabIndex = 0;
            this.bodyNumber.Text = "10";
            this.bodyNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bodyNumber.Click += new System.EventHandler(this.healthLabel_Click);
            // 
            // manaNumber
            // 
            this.manaNumber.AutoSize = true;
            this.manaNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manaNumber.Location = new System.Drawing.Point(105, 38);
            this.manaNumber.Name = "manaNumber";
            this.manaNumber.Size = new System.Drawing.Size(39, 20);
            this.manaNumber.TabIndex = 0;
            this.manaNumber.Text = "100";
            this.manaNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manaNumber.Click += new System.EventHandler(this.healthLabel_Click);
            // 
            // healthNumber
            // 
            this.healthNumber.AutoSize = true;
            this.healthNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthNumber.Location = new System.Drawing.Point(105, 9);
            this.healthNumber.Name = "healthNumber";
            this.healthNumber.Size = new System.Drawing.Size(39, 20);
            this.healthNumber.TabIndex = 0;
            this.healthNumber.Text = "100";
            this.healthNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.healthNumber.Click += new System.EventHandler(this.healthLabel_Click);
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(20, 9);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(79, 20);
            this.healthLabel.TabIndex = 0;
            this.healthLabel.Text = "HEALTH";
            this.healthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.healthLabel.Click += new System.EventHandler(this.healthLabel_Click);
            // 
            // textInfoPanel
            // 
            this.textInfoPanel.BackColor = System.Drawing.Color.BurlyWood;
            this.textInfoPanel.Controls.Add(this.textBox1);
            this.textInfoPanel.Controls.Add(this.infoText);
            this.textInfoPanel.Location = new System.Drawing.Point(180, 305);
            this.textInfoPanel.Name = "textInfoPanel";
            this.textInfoPanel.Size = new System.Drawing.Size(226, 170);
            this.textInfoPanel.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 1;
            // 
            // infoText
            // 
            this.infoText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.infoText.Location = new System.Drawing.Point(4, 5);
            this.infoText.Multiline = true;
            this.infoText.Name = "infoText";
            this.infoText.ReadOnly = true;
            this.infoText.Size = new System.Drawing.Size(219, 135);
            this.infoText.TabIndex = 0;
            // 
            // dungeonInfoPanel
            // 
            this.dungeonInfoPanel.BackColor = System.Drawing.Color.BurlyWood;
            this.dungeonInfoPanel.Location = new System.Drawing.Point(412, 305);
            this.dungeonInfoPanel.Name = "dungeonInfoPanel";
            this.dungeonInfoPanel.Size = new System.Drawing.Size(170, 170);
            this.dungeonInfoPanel.TabIndex = 3;
            // 
            // menuPanel
            // 
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuPanel.Controls.Add(this.menuStrip);
            this.menuPanel.Location = new System.Drawing.Point(3, 3);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(579, 23);
            this.menuPanel.TabIndex = 4;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(579, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsMenu
            // 
            this.tsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNewGame,
            this.saveGameToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.quitToolStripMenuItem1});
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(50, 20);
            this.tsMenu.Text = "Menu";
            // 
            // tsNewGame
            // 
            this.tsNewGame.Name = "tsNewGame";
            this.tsNewGame.Size = new System.Drawing.Size(152, 22);
            this.tsNewGame.Text = "New Game";
            this.tsNewGame.Click += new System.EventHandler(this.tsNewGame_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "Load Game";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Options";
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem1.Text = "Quit";
            // 
            // GameWindow
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(588, 481);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.dungeonInfoPanel);
            this.Controls.Add(this.textInfoPanel);
            this.Controls.Add(this.playerInfoPanel);
            this.Controls.Add(this.mainPanel);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "GameWindow";
            this.Text = "Grave of the Necromancer";
            this.Load += new System.EventHandler(this.GOTN_GameWindow_Load);
            this.playerInfoPanel.ResumeLayout(false);
            this.playerInfoPanel.PerformLayout();
            this.textInfoPanel.ResumeLayout(false);
            this.textInfoPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel playerInfoPanel;
        private System.Windows.Forms.Panel textInfoPanel;
        private System.Windows.Forms.Panel dungeonInfoPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox infoText;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label mindLabel;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.Label manaLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label levelNumber;
        private System.Windows.Forms.Label mindNumber;
        private System.Windows.Forms.Label bodyNumber;
        private System.Windows.Forms.Label manaNumber;
        private System.Windows.Forms.Label healthNumber;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsNewGame;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
    }
}

