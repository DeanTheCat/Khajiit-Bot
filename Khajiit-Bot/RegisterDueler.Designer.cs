namespace Khajiit_Bot
{
    partial class RegisterDueler
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_class = new System.Windows.Forms.Label();
            this.lbl_gear = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.lbl_lvl = new System.Windows.Forms.Label();
            this.tb_lvl = new System.Windows.Forms.TextBox();
            this.cb_VR = new System.Windows.Forms.CheckBox();
            this.ddl_class = new System.Windows.Forms.ComboBox();
            this.ddl_gear = new System.Windows.Forms.ComboBox();
            this.ddl_type = new System.Windows.Forms.ComboBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_factionHeader = new System.Windows.Forms.Label();
            this.ddl_faction = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(39, 25);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(41, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name: ";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(85, 22);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(216, 20);
            this.tb_name.TabIndex = 1;
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Location = new System.Drawing.Point(42, 50);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(38, 13);
            this.lbl_class.TabIndex = 2;
            this.lbl_class.Text = "Class: ";
            // 
            // lbl_gear
            // 
            this.lbl_gear.AutoSize = true;
            this.lbl_gear.Location = new System.Drawing.Point(12, 78);
            this.lbl_gear.Name = "lbl_gear";
            this.lbl_gear.Size = new System.Drawing.Size(68, 13);
            this.lbl_gear.TabIndex = 4;
            this.lbl_gear.Text = "Gear Quality:";
            this.lbl_gear.Click += new System.EventHandler(this.lbl_gear_Click);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(20, 103);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(60, 13);
            this.lbl_type.TabIndex = 6;
            this.lbl_type.Text = "Build Type:";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(85, 129);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(119, 23);
            this.btn_register.TabIndex = 8;
            this.btn_register.Text = "Register Dueler";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lbl_lvl
            // 
            this.lbl_lvl.AutoSize = true;
            this.lbl_lvl.Location = new System.Drawing.Point(218, 51);
            this.lbl_lvl.Name = "lbl_lvl";
            this.lbl_lvl.Size = new System.Drawing.Size(39, 13);
            this.lbl_lvl.TabIndex = 9;
            this.lbl_lvl.Text = "Level: ";
            // 
            // tb_lvl
            // 
            this.tb_lvl.Location = new System.Drawing.Point(263, 48);
            this.tb_lvl.Name = "tb_lvl";
            this.tb_lvl.Size = new System.Drawing.Size(39, 20);
            this.tb_lvl.TabIndex = 10;
            // 
            // cb_VR
            // 
            this.cb_VR.AutoSize = true;
            this.cb_VR.Checked = true;
            this.cb_VR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_VR.Location = new System.Drawing.Point(221, 74);
            this.cb_VR.Name = "cb_VR";
            this.cb_VR.Size = new System.Drawing.Size(104, 17);
            this.cb_VR.TabIndex = 11;
            this.cb_VR.Text = "Veteran Ranked";
            this.cb_VR.UseVisualStyleBackColor = true;
            // 
            // ddl_class
            // 
            this.ddl_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_class.FormattingEnabled = true;
            this.ddl_class.Items.AddRange(new object[] {
            "Nightblade",
            "Templar",
            "Sorcerer",
            "Dragonknight"});
            this.ddl_class.Location = new System.Drawing.Point(85, 47);
            this.ddl_class.Name = "ddl_class";
            this.ddl_class.Size = new System.Drawing.Size(121, 21);
            this.ddl_class.TabIndex = 12;
            // 
            // ddl_gear
            // 
            this.ddl_gear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_gear.FormattingEnabled = true;
            this.ddl_gear.Items.AddRange(new object[] {
            "Blue",
            "Purple",
            "Gold"});
            this.ddl_gear.Location = new System.Drawing.Point(85, 75);
            this.ddl_gear.Name = "ddl_gear";
            this.ddl_gear.Size = new System.Drawing.Size(121, 21);
            this.ddl_gear.TabIndex = 13;
            // 
            // ddl_type
            // 
            this.ddl_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_type.FormattingEnabled = true;
            this.ddl_type.Items.AddRange(new object[] {
            "Magicka",
            "Stamina"});
            this.ddl_type.Location = new System.Drawing.Point(85, 102);
            this.ddl_type.Name = "ddl_type";
            this.ddl_type.Size = new System.Drawing.Size(121, 21);
            this.ddl_type.TabIndex = 14;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(85, 170);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 15;
            // 
            // lbl_factionHeader
            // 
            this.lbl_factionHeader.AutoSize = true;
            this.lbl_factionHeader.Location = new System.Drawing.Point(218, 105);
            this.lbl_factionHeader.Name = "lbl_factionHeader";
            this.lbl_factionHeader.Size = new System.Drawing.Size(48, 13);
            this.lbl_factionHeader.TabIndex = 16;
            this.lbl_factionHeader.Text = "Faction: ";
            // 
            // ddl_faction
            // 
            this.ddl_faction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_faction.FormattingEnabled = true;
            this.ddl_faction.Items.AddRange(new object[] {
            "EP",
            "AD",
            "DC"});
            this.ddl_faction.Location = new System.Drawing.Point(263, 102);
            this.ddl_faction.Name = "ddl_faction";
            this.ddl_faction.Size = new System.Drawing.Size(39, 21);
            this.ddl_faction.TabIndex = 17;
            // 
            // RegisterDueler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.ddl_faction);
            this.Controls.Add(this.lbl_factionHeader);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.ddl_type);
            this.Controls.Add(this.ddl_gear);
            this.Controls.Add(this.ddl_class);
            this.Controls.Add(this.cb_VR);
            this.Controls.Add(this.tb_lvl);
            this.Controls.Add(this.lbl_lvl);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_gear);
            this.Controls.Add(this.lbl_class);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_name);
            this.Name = "RegisterDueler";
            this.Text = "RegisterDueler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Label lbl_gear;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lbl_lvl;
        private System.Windows.Forms.TextBox tb_lvl;
        private System.Windows.Forms.CheckBox cb_VR;
        private System.Windows.Forms.ComboBox ddl_class;
        private System.Windows.Forms.ComboBox ddl_gear;
        private System.Windows.Forms.ComboBox ddl_type;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_factionHeader;
        private System.Windows.Forms.ComboBox ddl_faction;
    }
}