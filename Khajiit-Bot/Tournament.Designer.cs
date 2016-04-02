namespace Khajiit_Bot
{
    partial class Tournament
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
            this.btn_catculate = new System.Windows.Forms.Button();
            this.lbl_nameHeader = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_roundHeader = new System.Windows.Forms.Label();
            this.lbl_round = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.tb_pairings = new System.Windows.Forms.TextBox();
            this.lbl_eliminate = new System.Windows.Forms.Label();
            this.tb_eliminate = new System.Windows.Forms.TextBox();
            this.lbl_eliminateInfo = new System.Windows.Forms.Label();
            this.btn_execute = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_catculate
            // 
            this.btn_catculate.Location = new System.Drawing.Point(16, 61);
            this.btn_catculate.Name = "btn_catculate";
            this.btn_catculate.Size = new System.Drawing.Size(127, 23);
            this.btn_catculate.TabIndex = 0;
            this.btn_catculate.Text = "Catculate Pairings";
            this.btn_catculate.UseVisualStyleBackColor = true;
            this.btn_catculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_nameHeader
            // 
            this.lbl_nameHeader.AutoSize = true;
            this.lbl_nameHeader.Location = new System.Drawing.Point(13, 13);
            this.lbl_nameHeader.Name = "lbl_nameHeader";
            this.lbl_nameHeader.Size = new System.Drawing.Size(101, 13);
            this.lbl_nameHeader.TabIndex = 1;
            this.lbl_nameHeader.Text = "Tournament Name: ";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(120, 13);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 13);
            this.lbl_name.TabIndex = 2;
            // 
            // lbl_roundHeader
            // 
            this.lbl_roundHeader.AutoSize = true;
            this.lbl_roundHeader.Location = new System.Drawing.Point(69, 35);
            this.lbl_roundHeader.Name = "lbl_roundHeader";
            this.lbl_roundHeader.Size = new System.Drawing.Size(45, 13);
            this.lbl_roundHeader.TabIndex = 3;
            this.lbl_roundHeader.Text = "Round: ";
            // 
            // lbl_round
            // 
            this.lbl_round.AutoSize = true;
            this.lbl_round.Location = new System.Drawing.Point(120, 35);
            this.lbl_round.Name = "lbl_round";
            this.lbl_round.Size = new System.Drawing.Size(13, 13);
            this.lbl_round.TabIndex = 4;
            this.lbl_round.Text = "0";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(149, 61);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(126, 23);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = "Next Round";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // tb_pairings
            // 
            this.tb_pairings.Location = new System.Drawing.Point(16, 91);
            this.tb_pairings.Multiline = true;
            this.tb_pairings.Name = "tb_pairings";
            this.tb_pairings.ReadOnly = true;
            this.tb_pairings.Size = new System.Drawing.Size(356, 270);
            this.tb_pairings.TabIndex = 6;
            // 
            // lbl_eliminate
            // 
            this.lbl_eliminate.AutoSize = true;
            this.lbl_eliminate.Location = new System.Drawing.Point(22, 374);
            this.lbl_eliminate.Name = "lbl_eliminate";
            this.lbl_eliminate.Size = new System.Drawing.Size(87, 13);
            this.lbl_eliminate.TabIndex = 7;
            this.lbl_eliminate.Text = "Eliminate Player: ";
            // 
            // tb_eliminate
            // 
            this.tb_eliminate.Location = new System.Drawing.Point(115, 371);
            this.tb_eliminate.Name = "tb_eliminate";
            this.tb_eliminate.Size = new System.Drawing.Size(249, 20);
            this.tb_eliminate.TabIndex = 8;
            // 
            // lbl_eliminateInfo
            // 
            this.lbl_eliminateInfo.AutoSize = true;
            this.lbl_eliminateInfo.Location = new System.Drawing.Point(22, 394);
            this.lbl_eliminateInfo.Name = "lbl_eliminateInfo";
            this.lbl_eliminateInfo.Size = new System.Drawing.Size(350, 13);
            this.lbl_eliminateInfo.TabIndex = 9;
            this.lbl_eliminateInfo.Text = "Type a name into the textbox to eliminate the player from the Tournament";
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(115, 410);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(249, 23);
            this.btn_execute.TabIndex = 10;
            this.btn_execute.Text = "Eliminate!";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(112, 440);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 11;
            // 
            // Tournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.lbl_eliminateInfo);
            this.Controls.Add(this.tb_eliminate);
            this.Controls.Add(this.lbl_eliminate);
            this.Controls.Add(this.tb_pairings);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_round);
            this.Controls.Add(this.lbl_roundHeader);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_nameHeader);
            this.Controls.Add(this.btn_catculate);
            this.Name = "Tournament";
            this.Text = "Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_catculate;
        private System.Windows.Forms.Label lbl_nameHeader;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_roundHeader;
        private System.Windows.Forms.Label lbl_round;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.TextBox tb_pairings;
        private System.Windows.Forms.Label lbl_eliminate;
        private System.Windows.Forms.TextBox tb_eliminate;
        private System.Windows.Forms.Label lbl_eliminateInfo;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.Label lbl_error;
    }
}