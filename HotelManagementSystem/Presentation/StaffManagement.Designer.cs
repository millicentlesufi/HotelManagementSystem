namespace HotelManagementSystem.Presentation
{
    partial class StaffManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffManagement));
            this.lstv_Staff = new System.Windows.Forms.ListView();
            this.gb_Options = new System.Windows.Forms.GroupBox();
            this.rb_GM = new System.Windows.Forms.RadioButton();
            this.rb_Manager = new System.Windows.Forms.RadioButton();
            this.rb_Receptionist = new System.Windows.Forms.RadioButton();
            this.gb_Details = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tb_address = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_sName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_fName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_eID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_actions = new System.Windows.Forms.GroupBox();
            this.btn_removeStaff = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.gb_staff_members = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.gb_Options.SuspendLayout();
            this.gb_Details.SuspendLayout();
            this.gb_actions.SuspendLayout();
            this.gb_staff_members.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstv_Staff
            // 
            this.lstv_Staff.HideSelection = false;
            this.lstv_Staff.Location = new System.Drawing.Point(6, 28);
            this.lstv_Staff.Name = "lstv_Staff";
            this.lstv_Staff.Size = new System.Drawing.Size(613, 287);
            this.lstv_Staff.TabIndex = 0;
            this.lstv_Staff.UseCompatibleStateImageBehavior = false;
            this.lstv_Staff.SelectedIndexChanged += new System.EventHandler(this.lstv_Staff_SelectedIndexChanged);
            // 
            // gb_Options
            // 
            this.gb_Options.Controls.Add(this.rb_GM);
            this.gb_Options.Controls.Add(this.rb_Manager);
            this.gb_Options.Controls.Add(this.rb_Receptionist);
            this.gb_Options.Location = new System.Drawing.Point(12, 12);
            this.gb_Options.Name = "gb_Options";
            this.gb_Options.Size = new System.Drawing.Size(339, 59);
            this.gb_Options.TabIndex = 1;
            this.gb_Options.TabStop = false;
            this.gb_Options.Text = "Staff Role";
            // 
            // rb_GM
            // 
            this.rb_GM.AutoSize = true;
            this.rb_GM.Location = new System.Drawing.Point(204, 21);
            this.rb_GM.Name = "rb_GM";
            this.rb_GM.Size = new System.Drawing.Size(133, 20);
            this.rb_GM.TabIndex = 2;
            this.rb_GM.TabStop = true;
            this.rb_GM.Text = "General Manager";
            this.rb_GM.UseVisualStyleBackColor = true;
            this.rb_GM.CheckedChanged += new System.EventHandler(this.rb_GM_CheckedChanged);
            // 
            // rb_Manager
            // 
            this.rb_Manager.AutoSize = true;
            this.rb_Manager.Location = new System.Drawing.Point(116, 21);
            this.rb_Manager.Name = "rb_Manager";
            this.rb_Manager.Size = new System.Drawing.Size(82, 20);
            this.rb_Manager.TabIndex = 1;
            this.rb_Manager.TabStop = true;
            this.rb_Manager.Text = "Manager";
            this.rb_Manager.UseVisualStyleBackColor = true;
            this.rb_Manager.CheckedChanged += new System.EventHandler(this.rb_Manager_CheckedChanged);
            // 
            // rb_Receptionist
            // 
            this.rb_Receptionist.AutoSize = true;
            this.rb_Receptionist.Location = new System.Drawing.Point(7, 22);
            this.rb_Receptionist.Name = "rb_Receptionist";
            this.rb_Receptionist.Size = new System.Drawing.Size(103, 20);
            this.rb_Receptionist.TabIndex = 0;
            this.rb_Receptionist.TabStop = true;
            this.rb_Receptionist.Text = "Receptionist";
            this.rb_Receptionist.UseVisualStyleBackColor = true;
            this.rb_Receptionist.CheckedChanged += new System.EventHandler(this.rb_Receptionist_CheckedChanged);
            // 
            // gb_Details
            // 
            this.gb_Details.Controls.Add(this.btn_cancel);
            this.gb_Details.Controls.Add(this.btn_Submit);
            this.gb_Details.Controls.Add(this.tb_address);
            this.gb_Details.Controls.Add(this.label7);
            this.gb_Details.Controls.Add(this.tb_email);
            this.gb_Details.Controls.Add(this.label5);
            this.gb_Details.Controls.Add(this.tb_phone);
            this.gb_Details.Controls.Add(this.label6);
            this.gb_Details.Controls.Add(this.tb_sName);
            this.gb_Details.Controls.Add(this.label3);
            this.gb_Details.Controls.Add(this.tb_fName);
            this.gb_Details.Controls.Add(this.label4);
            this.gb_Details.Controls.Add(this.tb_ID);
            this.gb_Details.Controls.Add(this.label2);
            this.gb_Details.Controls.Add(this.tb_eID);
            this.gb_Details.Controls.Add(this.label1);
            this.gb_Details.Location = new System.Drawing.Point(643, 12);
            this.gb_Details.Name = "gb_Details";
            this.gb_Details.Size = new System.Drawing.Size(279, 326);
            this.gb_Details.TabIndex = 2;
            this.gb_Details.TabStop = false;
            this.gb_Details.Text = "Staff Details";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(144, 284);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(125, 31);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(9, 284);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(125, 31);
            this.btn_Submit.TabIndex = 14;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(102, 195);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(167, 68);
            this.tb_address.TabIndex = 13;
            this.tb_address.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(102, 167);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(140, 22);
            this.tb_email.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(102, 139);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(140, 22);
            this.tb_phone.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phone";
            // 
            // tb_sName
            // 
            this.tb_sName.Location = new System.Drawing.Point(102, 111);
            this.tb_sName.Name = "tb_sName";
            this.tb_sName.Size = new System.Drawing.Size(140, 22);
            this.tb_sName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname";
            // 
            // tb_fName
            // 
            this.tb_fName.Location = new System.Drawing.Point(102, 83);
            this.tb_fName.Name = "tb_fName";
            this.tb_fName.Size = new System.Drawing.Size(140, 22);
            this.tb_fName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "First Name";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(102, 55);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(140, 22);
            this.tb_ID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID number";
            // 
            // tb_eID
            // 
            this.tb_eID.Enabled = false;
            this.tb_eID.Location = new System.Drawing.Point(102, 27);
            this.tb_eID.Name = "tb_eID";
            this.tb_eID.Size = new System.Drawing.Size(140, 22);
            this.tb_eID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee_ID";
            // 
            // gb_actions
            // 
            this.gb_actions.Controls.Add(this.btn_removeStaff);
            this.gb_actions.Controls.Add(this.btn_new);
            this.gb_actions.Location = new System.Drawing.Point(357, 12);
            this.gb_actions.Name = "gb_actions";
            this.gb_actions.Size = new System.Drawing.Size(268, 59);
            this.gb_actions.TabIndex = 3;
            this.gb_actions.TabStop = false;
            this.gb_actions.Text = "Options ";
            // 
            // btn_removeStaff
            // 
            this.btn_removeStaff.Location = new System.Drawing.Point(137, 21);
            this.btn_removeStaff.Name = "btn_removeStaff";
            this.btn_removeStaff.Size = new System.Drawing.Size(125, 31);
            this.btn_removeStaff.TabIndex = 17;
            this.btn_removeStaff.Text = "Remove";
            this.btn_removeStaff.UseVisualStyleBackColor = true;
            this.btn_removeStaff.Click += new System.EventHandler(this.btn_removeStaff_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(6, 21);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(125, 31);
            this.btn_new.TabIndex = 16;
            this.btn_new.Text = "Add new staff";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // gb_staff_members
            // 
            this.gb_staff_members.Controls.Add(this.lstv_Staff);
            this.gb_staff_members.Location = new System.Drawing.Point(12, 77);
            this.gb_staff_members.Name = "gb_staff_members";
            this.gb_staff_members.Size = new System.Drawing.Size(625, 321);
            this.gb_staff_members.TabIndex = 4;
            this.gb_staff_members.TabStop = false;
            this.gb_staff_members.Text = "Staff Details";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(652, 367);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(125, 31);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "Update Database";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(797, 367);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(125, 31);
            this.btn_Close.TabIndex = 17;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 421);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.gb_staff_members);
            this.Controls.Add(this.gb_actions);
            this.Controls.Add(this.gb_Details);
            this.Controls.Add(this.gb_Options);
            this.DoubleBuffered = true;
            this.Name = "StaffManagement";
            this.Text = "StaffManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffManagement_FormClosing);
            this.gb_Options.ResumeLayout(false);
            this.gb_Options.PerformLayout();
            this.gb_Details.ResumeLayout(false);
            this.gb_Details.PerformLayout();
            this.gb_actions.ResumeLayout(false);
            this.gb_staff_members.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstv_Staff;
        private System.Windows.Forms.GroupBox gb_Options;
        private System.Windows.Forms.RadioButton rb_GM;
        private System.Windows.Forms.RadioButton rb_Manager;
        private System.Windows.Forms.RadioButton rb_Receptionist;
        private System.Windows.Forms.GroupBox gb_Details;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_sName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_fName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_eID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.RichTextBox tb_address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.GroupBox gb_actions;
        private System.Windows.Forms.GroupBox gb_staff_members;
        private System.Windows.Forms.Button btn_removeStaff;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Close;
    }
}