using HotelManagementSystem.Business.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelManagementSystem.Presentation
{
    public partial class ChangePasswordScreen : Form
    {
        #region Datamembers
        private bool _formClosed = false;
        private string _emp_ID;
        private AccountControll _ac;
        #endregion

        #region Mutators
        public bool formClosed { get => _formClosed; }
        #endregion

        #region Constructors
        public ChangePasswordScreen(string emp)
        {
            _ac = new AccountControll();
            InitializeComponent();
            _emp_ID = emp;
        }
        #endregion

        #region Buttons
        private void btn_ok_Click(object sender, EventArgs e)
        {
            Account a = _ac.Find(_emp_ID);
            if (a.password == CreateHash(mtb_old.Text))
            {
                if (mtb_new.Text == mtb_c_new.Text)
                {
                    a.password = CreateHash(mtb_new.Text);
                    _ac.UpdateDataSet(a, 1);
                    _ac.UpdateDataSource();
                    MessageBox.Show("Password changed succesfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The new password does not match the confirm new password.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password!");
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Utility
        private string CreateHash(string s)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Compute the hash as a byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(s));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                string p = builder.ToString();
                return p;
            }
        }
        #endregion

        #region Events



        private void ChangePasswordScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            _formClosed = true;
        }
        #endregion

        
    }
}
