namespace HotelManagementSystem.Presentation
{
    partial class ChangePasswordScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_old = new System.Windows.Forms.MaskedTextBox();
            this.mtb_new = new System.Windows.Forms.MaskedTextBox();
            this.mtb_c_new = new System.Windows.Forms.MaskedTextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm New Password";
            // 
            // mtb_old
            // 
            this.mtb_old.Location = new System.Drawing.Point(381, 96);
            this.mtb_old.Name = "mtb_old";
            this.mtb_old.PasswordChar = '*';
            this.mtb_old.Size = new System.Drawing.Size(223, 22);
            this.mtb_old.TabIndex = 3;
            // 
            // mtb_new
            // 
            this.mtb_new.Location = new System.Drawing.Point(381, 146);
            this.mtb_new.Name = "mtb_new";
            this.mtb_new.PasswordChar = '*';
            this.mtb_new.Size = new System.Drawing.Size(223, 22);
            this.mtb_new.TabIndex = 4;
            // 
            // mtb_c_new
            // 
            this.mtb_c_new.Location = new System.Drawing.Point(381, 200);
            this.mtb_c_new.Name = "mtb_c_new";
            this.mtb_c_new.PasswordChar = '*';
            this.mtb_c_new.Size = new System.Drawing.Size(223, 22);
            this.mtb_c_new.TabIndex = 5;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Cancel.Location = new System.Drawing.Point(445, 250);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(133, 47);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ok.Location = new System.Drawing.Point(246, 250);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(133, 47);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // ChangePasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.mtb_c_new);
            this.Controls.Add(this.mtb_new);
            this.Controls.Add(this.mtb_old);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ChangePasswordScreen";
            this.Text = "Change Password ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePasswordScreen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_old;
        private System.Windows.Forms.MaskedTextBox mtb_new;
        private System.Windows.Forms.MaskedTextBox mtb_c_new;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_ok;
    }
}