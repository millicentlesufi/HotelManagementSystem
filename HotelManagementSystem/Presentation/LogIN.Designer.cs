namespace HotelManagementSystem.Presentation
{
    partial class LogIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIN));
            this.lbl_empID = new System.Windows.Forms.Label();
            this.lbl_pw = new System.Windows.Forms.Label();
            this.tb_userID = new System.Windows.Forms.TextBox();
            this.mtb_pw = new System.Windows.Forms.MaskedTextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_invalid = new System.Windows.Forms.Label();
            this.lbl_instuction = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_empID
            // 
            this.lbl_empID.AutoSize = true;
            this.lbl_empID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empID.Location = new System.Drawing.Point(36, 52);
            this.lbl_empID.Name = "lbl_empID";
            this.lbl_empID.Size = new System.Drawing.Size(96, 16);
            this.lbl_empID.TabIndex = 0;
            this.lbl_empID.Text = "Employee ID";
            // 
            // lbl_pw
            // 
            this.lbl_pw.AutoSize = true;
            this.lbl_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pw.Location = new System.Drawing.Point(54, 80);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(75, 16);
            this.lbl_pw.TabIndex = 1;
            this.lbl_pw.Text = "Password";
            // 
            // tb_userID
            // 
            this.tb_userID.Location = new System.Drawing.Point(156, 49);
            this.tb_userID.Name = "tb_userID";
            this.tb_userID.Size = new System.Drawing.Size(195, 22);
            this.tb_userID.TabIndex = 2;
            // 
            // mtb_pw
            // 
            this.mtb_pw.Location = new System.Drawing.Point(156, 77);
            this.mtb_pw.Name = "mtb_pw";
            this.mtb_pw.PasswordChar = '*';
            this.mtb_pw.Size = new System.Drawing.Size(195, 22);
            this.mtb_pw.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ok.Location = new System.Drawing.Point(39, 119);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(133, 47);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Cancel.Location = new System.Drawing.Point(238, 119);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(133, 47);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_invalid
            // 
            this.lbl_invalid.AutoSize = true;
            this.lbl_invalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invalid.ForeColor = System.Drawing.Color.Red;
            this.lbl_invalid.Location = new System.Drawing.Point(35, 8);
            this.lbl_invalid.Name = "lbl_invalid";
            this.lbl_invalid.Size = new System.Drawing.Size(336, 24);
            this.lbl_invalid.TabIndex = 6;
            this.lbl_invalid.Text = "Incorrect employee ID or Password";
            this.lbl_invalid.Visible = false;
            // 
            // lbl_instuction
            // 
            this.lbl_instuction.AutoSize = true;
            this.lbl_instuction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instuction.Location = new System.Drawing.Point(167, 8);
            this.lbl_instuction.Name = "lbl_instuction";
            this.lbl_instuction.Size = new System.Drawing.Size(173, 24);
            this.lbl_instuction.TabIndex = 7;
            this.lbl_instuction.Text = "Please enter details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lbl_invalid);
            this.panel1.Controls.Add(this.lbl_instuction);
            this.panel1.Controls.Add(this.lbl_empID);
            this.panel1.Controls.Add(this.lbl_pw);
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.tb_userID);
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Controls.Add(this.mtb_pw);
            this.panel1.Location = new System.Drawing.Point(329, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 178);
            this.panel1.TabIndex = 8;
            // 
            // LogIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 521);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "LogIN";
            this.Text = "Access Control";
            this.Activated += new System.EventHandler(this.LogIN_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIN_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogIN_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_empID;
        private System.Windows.Forms.Label lbl_pw;
        private System.Windows.Forms.TextBox tb_userID;
        private System.Windows.Forms.MaskedTextBox mtb_pw;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_invalid;
        private System.Windows.Forms.Label lbl_instuction;
        private System.Windows.Forms.Panel panel1;
    }
}