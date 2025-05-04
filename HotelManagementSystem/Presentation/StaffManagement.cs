using HotelManagementSystem.Business.Accounts;
using HotelManagementSystem.Business.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography;
using Org.BouncyCastle.Asn1.Pkcs;

namespace HotelManagementSystem.Presentation
{
    public partial class StaffManagement : Form
    {
        private StaffControll _sc;
        private Staff _staff;
        private Account account;
        private AccountControll _ac;
        private int _role;
        private bool _newStaff = false;

        public StaffManagement()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(StaffManagement_FormClosing);

            _sc = new StaffControll();
            _ac = new AccountControll();
            account = new Account();
            _role = 1;
            SetUpView();
        }

        #region Buttons
        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearAll();
            int role = 1;
            string empID = "";
            List<int> usedIds = new List<int>();
            if (rb_Receptionist.Checked)
            {
                role = 1;
                empID += "R-";
            }
            else if (rb_Manager.Checked)
            {
                role = 2;
                empID = "M-";
            }
            else if (rb_GM.Checked)
            {
                role = 3;
                empID = "GM-";
            }
            //For other roles

            foreach (Staff s in _sc.allStaff)
            {
                if (s.role == role)
                {
                    string[] newId = s.empID.Split('-');
                    usedIds.Add(Convert.ToInt32(newId[1]));
                }
            }

            if (usedIds.Count == 0)
            {
                empID += 1;
            }
            else
            {
                empID += usedIds.Max() + 1;
            }
            tb_eID.Text = empID;
            btn_Submit.Visible = true;
            btn_cancel.Visible = true;
            gb_Details.Visible = true;
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (AllValuesValid())
            {
                Staff staff = new Staff();
                staff.empID = tb_eID.Text;
                staff.ID = tb_ID.Text;
                staff.fName = tb_fName.Text;
                staff.sName = tb_sName.Text;
                staff.phone = tb_phone.Text;
                staff.email = tb_email.Text;
                staff.address = tb_address.Text;
                staff.role = _role;

                account = new Account();
                account.empID = staff.empID;
                account.password = CreateHash(staff.empID);
                account.role = _role;
                _ac.UpdateDataSet(account,2);

                _sc.ModifyStaff(staff, 2);
                _newStaff = true;
                ClearAll();
                SetUpView();
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateDatabase();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearAll();
            SetUpView();
        }
        private void btn_removeStaff_Click(object sender, EventArgs e)
        {
            _sc.ModifyStaff(_staff, 3);
            _newStaff = true;
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
                return builder.ToString();
            }
        }
        private void ClearAll()
        {
            tb_ID.Text = "";
            tb_fName.Text = "";
            tb_sName.Text = "";
            tb_phone.Text = "";
            tb_email.Text = "";
            tb_address.Text = "";
        }
        private void PopulateBoxes(Staff s)
        {
            tb_eID.Text = s.empID;
            tb_ID.Text = s.ID;
            tb_fName.Text = s.fName;
            tb_sName.Text = s.sName;
            tb_phone.Text = s.phone;
            tb_email.Text = s.email;
            tb_address.Text = s.address;

        }
        private void UpdateDatabase()
        {
            _sc.UpdateDateSource();
            _ac.UpdateDataSource();
            MessageBox.Show("Database updated.");
            _newStaff = false;
        }
        #endregion

        #region Validation
        private bool ValidValue(string input, int mode)
        {
            Regex pattern = new Regex("");

            switch (mode)
            {
                case 0:
                    pattern = new Regex("^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$");
                    break;
                case 1:
                    pattern = new Regex(@"^([\+]?[0-9]{1,2}[-]?|[0])?[1-9][0-9]{8}$");
                    break;
                case 2:
                    pattern = new Regex("^(1298|1267|4512|4567|8901|8933)([\\-\\s]?[0-9]{4}){3}$"); //validate credit card format
                    break;
                case 3:
                    pattern = new Regex("[0-9]+|[!@#$%^&*()_\\-+={}<>,.?\\/\"\':;|\\\\\\[\\]~`]+");
                    break;
                default:
                    break;
            }
            return pattern.IsMatch(input);
        }
        private bool AllValuesValid()
        {
            bool result = true;
            long i;
            if (!long.TryParse(tb_ID.Text, out i))
            {
                MessageBox.Show("Staff's ID number is in an invalid format!");
                tb_ID.Focus();
                result = false;
            }

            else if (ValidValue(tb_fName.Text,3))
            {
                MessageBox.Show("Staff's First name is in an invalid format!");
                tb_fName.Focus();
                result = false;
            }

            else if (ValidValue(tb_sName.Text,3))
            {
                MessageBox.Show("Staff's Surname is in an invalid format!");
                tb_sName.Focus();
                result = false;
            }

            else if (!ValidValue(tb_email.Text, 0))
            {
                MessageBox.Show("Staff's Email is in an invalid format!");
                tb_email.Focus();
                result = false;
            }

            else if (!ValidValue(tb_phone.Text, 1))
            {
                MessageBox.Show("Staff's Phone number is in an invalid format!");
                tb_phone.Focus();
                result = false;
            }

            else if (tb_address.Text == "")
            {
                MessageBox.Show("Staff's address is in an invalid format!");
                tb_address.Focus();
                result = false;
            }


            return result;
        }
        #endregion

        #region Events
        private void rb_Receptionist_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Receptionist.Checked) { _role = 1; }
            SetUpView();
        }
        private void rb_Manager_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Manager.Checked) { _role = 2; }
            SetUpView();
        }

        private void rb_GM_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_GM.Checked) { _role = 3; }
            SetUpView();
        }
        private void lstv_Staff_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Submit.Visible = false;
            btn_cancel.Visible = false;

            if (lstv_Staff.SelectedItems.Count > 0)
            {
                _staff = _sc.Find(lstv_Staff.SelectedItems[0].Text);
                PopulateBoxes(_staff);
            }

        }

        private void StaffManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel) return;
            if (_newStaff)
            {
                DialogResult dr =MessageBox.Show("There are unsaved changes to the database!\nDo you want to update the database?", "Warning",  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    UpdateDatabase();
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region Setup View
        private void SetUpView()
        {
            gb_Details.Visible = false;
            ListViewItem detail;
            lstv_Staff.Clear();
            lstv_Staff.View = View.Details;
            lstv_Staff.GridLines = true;
            lstv_Staff.Columns.Insert(0, "Employee ID", 100, HorizontalAlignment.Center);
            lstv_Staff.Columns.Insert(1, "ID number", 100, HorizontalAlignment.Center);
            lstv_Staff.Columns.Insert(2, "First Name", 100, HorizontalAlignment.Center);
            lstv_Staff.Columns.Insert(3, "Last Name", 100, HorizontalAlignment.Center);


            foreach (Staff s in _sc.allStaff)
            {
                if (s.role == _role)
                {
                    detail = new ListViewItem();
                    detail.Text = s.empID;
                    detail.SubItems.Add(s.ID);
                    detail.SubItems.Add(s.fName);
                    detail.SubItems.Add(s.sName);
                    lstv_Staff.Items.Add(detail);
                    lstv_Staff.Refresh();
                }
            }
        }








        #endregion

        
    }
}
