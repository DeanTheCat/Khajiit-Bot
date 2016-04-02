namespace Khajiit_Bot
{
    partial class KhajiitBot
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
            this.lbl_khajiitbotwelcome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerDuelersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pairingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_khajiitbotwelcome
            // 
            this.lbl_khajiitbotwelcome.AutoSize = true;
            this.lbl_khajiitbotwelcome.Location = new System.Drawing.Point(26, 52);
            this.lbl_khajiitbotwelcome.Name = "lbl_khajiitbotwelcome";
            this.lbl_khajiitbotwelcome.Size = new System.Drawing.Size(111, 13);
            this.lbl_khajiitbotwelcome.TabIndex = 0;
            this.lbl_khajiitbotwelcome.Text = "Welcome to KhajiitBot";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.createTournamentToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // createTournamentToolStripMenuItem
            // 
            this.createTournamentToolStripMenuItem.Name = "createTournamentToolStripMenuItem";
            this.createTournamentToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.createTournamentToolStripMenuItem.Text = "Create Tournament";
            this.createTournamentToolStripMenuItem.Click += new System.EventHandler(this.createTournamentToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTournamentToolStripMenuItem,
            this.registerDuelersToolStripMenuItem,
            this.pairingsToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // loadTournamentToolStripMenuItem
            // 
            this.loadTournamentToolStripMenuItem.Name = "loadTournamentToolStripMenuItem";
            this.loadTournamentToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.loadTournamentToolStripMenuItem.Text = "Load Tournament for use";
            this.loadTournamentToolStripMenuItem.Click += new System.EventHandler(this.loadTournamentToolStripMenuItem_Click);
            // 
            // registerDuelersToolStripMenuItem
            // 
            this.registerDuelersToolStripMenuItem.Name = "registerDuelersToolStripMenuItem";
            this.registerDuelersToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.registerDuelersToolStripMenuItem.Text = "Register Duelers";
            this.registerDuelersToolStripMenuItem.Click += new System.EventHandler(this.registerDuelersToolStripMenuItem_Click);
            // 
            // pairingsToolStripMenuItem
            // 
            this.pairingsToolStripMenuItem.Name = "pairingsToolStripMenuItem";
            this.pairingsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pairingsToolStripMenuItem.Text = "Pairings";
            this.pairingsToolStripMenuItem.Click += new System.EventHandler(this.pairingsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Note: Please load a tournament before Registering Duelers";
            // 
            // KhajiitBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_khajiitbotwelcome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KhajiitBot";
            this.Text = "KhajiitBot";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_khajiitbotwelcome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerDuelersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pairingsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

