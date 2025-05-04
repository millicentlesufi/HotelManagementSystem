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

namespace HotelManagementSystem.Presentation
{
    public partial class LogIN : Form
    {
        #region Data Members
        private int _role;
        private string _EmpID;
        private bool _valid = false;
        private bool _Login_formClosed;
        private AccountControll _ac;
        #endregion

        #region Mutators
        public bool validate { get => _valid; }
        public bool loginFormClosed { get => _Login_formClosed; }
        public string empID { get => _EmpID; }
        public int role { get => _role; }
        #endregion

        #region Constructors
        public LogIN()
        {
            _ac = new AccountControll();
            InitializeComponent();
            this.Load += LogIN_Load;
            this.FormClosed += LogIN_FormClosed;
            this.Activated += LogIN_Activated;
        }

        private void LogIN_Load(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Events
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //bool valid = false;
            string userName = tb_userID.Text;
            Account a = _ac.Find(userName);
            if (a != null) 
            {
                if (a.password == CreateHash(mtb_pw.Text))
                {
                    _valid = true;
                    _role = a.role;
                    _EmpID = a.empID;
                }
            }

            if (_valid) { this.Close(); }
            else 
            { 
                lbl_instuction.Visible = false;
                lbl_invalid.Visible = true; 
            }
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
                string p =builder.ToString();
                return p;
            }
        }
        #endregion

        private void LogIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Login_formClosed = true;
        }

        private void LogIN_Activated(object sender, EventArgs e)
        {

        }

        private void LogIN_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
