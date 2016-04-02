namespace Khajiit_Bot
{
    partial class CreateTournament
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
            this.lbl_tName = new System.Windows.Forms.Label();
            this.tb_tName = new System.Windows.Forms.TextBox();
            this.lbl_tRounds = new System.Windows.Forms.Label();
            this.trb_rounds = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tRating = new System.Windows.Forms.CheckBox();
            this.btn_tCreate = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trb_rounds)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tName
            // 
            this.lbl_tName.AutoSize = true;
            this.lbl_tName.Location = new System.Drawing.Point(12, 26);
            this.lbl_tName.Name = "lbl_tName";
            this.lbl_tName.Size = new System.Drawing.Size(98, 13);
            this.lbl_tName.TabIndex = 0;
            this.lbl_tName.Text = "Tournament Name:";
            // 
            // tb_tName
            // 
            this.tb_tName.Location = new System.Drawing.Point(116, 23);
            this.tb_tName.Name = "tb_tName";
            this.tb_tName.Size = new System.Drawing.Size(195, 20);
            this.tb_tName.TabIndex = 1;
            // 
            // lbl_tRounds
            // 
            this.lbl_tRounds.AutoSize = true;
            this.lbl_tRounds.Location = new System.Drawing.Point(12, 61);
            this.lbl_tRounds.Name = "lbl_tRounds";
            this.lbl_tRounds.Size = new System.Drawing.Size(155, 13);
            this.lbl_tRounds.TabIndex = 2;
            this.lbl_tRounds.Text = "Number of Elimination Rounds: ";
            this.lbl_tRounds.Visible = false;
            // 
            // trb_rounds
            // 
            this.trb_rounds.Location = new System.Drawing.Point(174, 61);
            this.trb_rounds.Maximum = 5;
            this.trb_rounds.Minimum = 1;
            this.trb_rounds.Name = "trb_rounds";
            this.trb_rounds.Size = new System.Drawing.Size(104, 45);
            this.trb_rounds.TabIndex = 3;
            this.trb_rounds.Value = 1;
            this.trb_rounds.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Note: Elimination Rounds will stop once a faction has less then 4 combatants";
            this.label1.Visible = false;
            // 
            // cb_tRating
            // 
            this.cb_tRating.AutoSize = true;
            this.cb_tRating.Checked = true;
            this.cb_tRating.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_tRating.Location = new System.Drawing.Point(15, 125);
            this.cb_tRating.Name = "cb_tRating";
            this.cb_tRating.Size = new System.Drawing.Size(150, 17);
            this.cb_tRating.TabIndex = 5;
            this.cb_tRating.Text = "Use Dueler Rating System";
            this.cb_tRating.UseVisualStyleBackColor = true;
            // 
            // btn_tCreate
            // 
            this.btn_tCreate.Location = new System.Drawing.Point(15, 149);
            this.btn_tCreate.Name = "btn_tCreate";
            this.btn_tCreate.Size = new System.Drawing.Size(116, 23);
            this.btn_tCreate.TabIndex = 6;
            this.btn_tCreate.Text = "Create Tournament";
            this.btn_tCreate.UseVisualStyleBackColor = true;
            this.btn_tCreate.Click += new System.EventHandler(this.btn_tCreate_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(30, 201);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 16;
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_tCreate);
            this.Controls.Add(this.cb_tRating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trb_rounds);
            this.Controls.Add(this.lbl_tRounds);
            this.Controls.Add(this.tb_tName);
            this.Controls.Add(this.lbl_tName);
            this.Name = "CreateTournament";
            this.Text = "CreateTournament";
            ((System.ComponentModel.ISupportInitialize)(this.trb_rounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tName;
        private System.Windows.Forms.TextBox tb_tName;
        private System.Windows.Forms.Label lbl_tRounds;
        private System.Windows.Forms.TrackBar trb_rounds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_tRating;
        private System.Windows.Forms.Button btn_tCreate;
        private System.Windows.Forms.Label lbl_error;
    }
}