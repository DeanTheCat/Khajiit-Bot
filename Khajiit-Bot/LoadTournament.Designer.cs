namespace Khajiit_Bot
{
    partial class LoadTournament
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
            this.lbl_tournamentHeader = new System.Windows.Forms.Label();
            this.ddl_tournament = new System.Windows.Forms.ComboBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_tournamentHeader
            // 
            this.lbl_tournamentHeader.AutoSize = true;
            this.lbl_tournamentHeader.Location = new System.Drawing.Point(12, 21);
            this.lbl_tournamentHeader.Name = "lbl_tournamentHeader";
            this.lbl_tournamentHeader.Size = new System.Drawing.Size(94, 13);
            this.lbl_tournamentHeader.TabIndex = 0;
            this.lbl_tournamentHeader.Text = "Load Tournament:";
            // 
            // ddl_tournament
            // 
            this.ddl_tournament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_tournament.FormattingEnabled = true;
            this.ddl_tournament.Location = new System.Drawing.Point(112, 18);
            this.ddl_tournament.Name = "ddl_tournament";
            this.ddl_tournament.Size = new System.Drawing.Size(228, 21);
            this.ddl_tournament.TabIndex = 1;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(112, 58);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(114, 23);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "Load Tournament";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(112, 99);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 3;
            // 
            // LoadTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.ddl_tournament);
            this.Controls.Add(this.lbl_tournamentHeader);
            this.Name = "LoadTournament";
            this.Text = "LoadTournament";
            this.Load += new System.EventHandler(this.lbl_loadHeader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tournamentHeader;
        private System.Windows.Forms.ComboBox ddl_tournament;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label lbl_error;
    }
}