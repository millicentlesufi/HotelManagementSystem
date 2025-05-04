using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Presentation
{
    public partial class MDI_HomeScreen : Form
    {


        private NewBookings newBookings;
        private CurrentBookings currentBookings;
        private LogIN login;
        private OpperationReport oRForm;
        private StaffManagement sForm;
        private OccupancyReport ocRepForm;
        private ChangePasswordScreen cpwForm;
        
        private bool _logedIn;
        private int _role;
        private string _empID;
        public MDI_HomeScreen()
        {
            InitializeComponent();

            if (!_logedIn)
            {
                CheckAutherization();
            }

        }

        #region ToolStrip 
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void newBookingsOpen_Click(object sender, EventArgs e)
        {
            if (newBookings == null) 
            {
                CreateNewBookingForm();
            }
            if (newBookings.newBookingFormClosed)
            {
                CreateNewBookingForm();
            }
            newBookings.MdiParent = this;
            
            newBookings.FormClosed += (s, args) => this.menuStrip.Enabled = true;
            this.menuStrip.Enabled = false;
            newBookings.Show();
        }
        private void currentBookingsOpen_Click(object sender, EventArgs e)
        {
            if (currentBookings == null) 
            {
                CreateCurrentBookingForm();
            }
            if(currentBookings.currentBookingsClosed)
            {
                CreateCurrentBookingForm();
            }
            currentBookings.MdiParent = this;
            currentBookings.FormClosed += (s, args) => this.menuStrip.Enabled = true;
            this.menuStrip.Enabled = false;
            currentBookings.Show();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            CheckAutherization();
        }
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            _logedIn = false;
            btn_Login.Enabled = true;
            CheckAutherization();
        }
        private void btn_oReport_Click(object sender, EventArgs e)
        {
            if (oRForm == null)
            {
                CreateOpperationReportForm();
            }
            if (oRForm.occupancyReportFormClosed)
            {
                CreateOpperationReportForm();
            }
            oRForm.MdiParent = this;
            oRForm.FormClosed += (s, args) => this.menuStrip.Enabled = true;
            this.menuStrip.Enabled = false;
            oRForm.Show();
        }
        private void btn_changePW_Click(object sender, EventArgs e)
        {
            if (cpwForm == null)
            {
                CreateChangePasswordForm();
            }
            if (cpwForm.formClosed)
            {
                CreateChangePasswordForm();
            }
            cpwForm.MdiParent = this;
            cpwForm.FormClosed += (s, args) => this.menuStrip.Enabled = true;
            this.menuStrip.Enabled = false;
            cpwForm.Show();

        }
        private void btn_ManageStaff_Click(object sender, EventArgs e)
        {
            CreateStaffForm();
            sForm.MdiParent = this;
            sForm.FormClosed += (s, args) => this.menuStrip.Enabled = true;
            this.menuStrip.Enabled = false;
            sForm.Show();
        }
        private void btn_occupancyReport_Click(object sender, EventArgs e)
        {
            if (ocRepForm == null)
            {
                CreateOccupancyReportForm();
            }
            if (ocRepForm.formClosed)
            {
                CreateOccupancyReportForm();
            }
            ocRepForm.MdiParent = this;
            ocRepForm.FormClosed += (s, args) => this.menuStrip.Enabled = true;
            this.menuStrip.Enabled = false;
            ocRepForm.Show();
        }
        #endregion

        #region State Controlls
        private void ViewEnable()
        {
            this.btn_changePW.Enabled = true;
            switch (_role)
            {
                case 1:
                    this.BookingMenue.Enabled = true;
                    this.ReportMenu.Enabled = true;
                    this.btn_oReport.Enabled = false;
                    this.btn_oReport.Visible = false;
                    break;
                case 2:
                    this.ReportMenu.Enabled = true;
                    this.btn_oReport.Enabled = true;
                    this.btn_oReport.Visible = true;

                    this.BookingMenue.Enabled = true;
                    break;
                case 3:
                    this.StaffMenu.Enabled = true;
                    this.StaffMenu.Visible = true;
                    this.ReportMenu.Enabled = true;
                    this.btn_oReport.Enabled = true;
                    this.btn_oReport.Visible = true;
                    this.BookingMenue.Enabled = true;

                    break;
                default:
                    break;
            }
        }
        private void CheckAutherization()
        {
            if (!_logedIn)
            {
                this.ReportMenu.Enabled = false;
                this.StaffMenu.Enabled = false;
                this.StaffMenu.Visible = false;
                this.BookingMenue.Enabled = false;
                this.btn_LogOut.Enabled = false;
                this.btn_changePW.Enabled = false;
                if (login == null)
                {
                    CreateLogInForm();

                }
                if (login.loginFormClosed)
                {
                    CreateLogInForm();
                }
                login.MdiParent = this;
                login.FormClosed += (s, args) => Authenticate(login.validate); //this._logedIn = login.validate;
                login.FormClosing += (s, args) => _empID = login.empID;
                login.Show();
            }
        }
        private void Authenticate(bool valid)
        {
            if (valid)
            {

                this.btn_LogOut.Enabled = true;
                this.btn_Login.Enabled = false;
                _logedIn = true;

                _role = login.role;
                ViewEnable();
            }

        }
        #endregion

        #region Form Control methods

        private void CreateNewBookingForm()
        {
            newBookings = new NewBookings(_empID);
            newBookings.MdiParent = this;
            newBookings.StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateCurrentBookingForm()
        {
            currentBookings = new CurrentBookings(_empID);
            currentBookings.MdiParent = this;
            currentBookings.StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateLogInForm()
        {
            login = new LogIN();
            login.MdiParent = this;
            login.StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateOpperationReportForm()
        {
            oRForm = new OpperationReport(_empID);
            oRForm.MdiParent = this;
            oRForm.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateStaffForm()
        {
            sForm = new StaffManagement();
            sForm.MdiParent = this;
            sForm.StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateOccupancyReportForm()
        {
            ocRepForm = new OccupancyReport(_empID);
            ocRepForm.MdiParent = this;
            ocRepForm.StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateChangePasswordForm()
        {
            cpwForm = new ChangePasswordScreen(_empID);
            cpwForm.MdiParent = this;
            cpwForm.StartPosition = FormStartPosition.CenterScreen;
        }


        #endregion

        
    }
}
