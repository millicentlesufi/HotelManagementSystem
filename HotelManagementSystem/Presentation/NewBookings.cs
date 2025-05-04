using HotelManagementSystem.Business;
using HotelManagementSystem.Business.Clients;
using HotelManagementSystem.Business.Staff;
using HotelManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace HotelManagementSystem.Presentation
{
    public partial class NewBookings : Form
    {
        #region Data Members
        private const int ROOMS = 5;
        private int state = 0;
        private bool _bookings_added = false;
        private string _empID;
        private bool _sendingEmails;
        private byte[] _KEY = Encoding.UTF8.GetBytes("aWsc@lFcOwHq31Nq");
        private byte[] _vector = Encoding.UTF8.GetBytes("pKnc.qwsX5OpwMhQ");

        private BookingControll bc;
        private AgentController ac;
        private GuestControll gc;
        private BlockBookingControl bbc;
        private CanceledBookingControll cbc;
        private ReportControl _rc;

        private Booking booking;
        private Agent agent = new Agent();
        private BlockBooking blockBooking;

        #region Collections
        private Collection<Agent> agents;
        private Collection<Booking> bookings;
        private Collection<Guest> guests;
        private Collection<BlockBooking> blockBookings;
        #endregion

        private DateTime check_in, check_out, depDate;


        private decimal _price;
        private decimal _deposit;
        private bool _returning_guest, _newBookingFormClosed;
        #endregion

        #region Mutators
        public bool newBookingFormClosed { get => _newBookingFormClosed; set => _newBookingFormClosed = value; }
        #endregion

        #region Constructors
        public NewBookings(string empID)
        {
            InitializeComponent();
            this.Load += NewBookings_Load;
            this.Activated += NewBookings_Activated;
            this.FormClosing += new FormClosingEventHandler(NewBookings_FormClosing);
            this.FormClosed += new FormClosedEventHandler(NewBookings_FormClosed);

            _empID = empID;
            bookings = new Collection<Booking>();
            guests = new Collection<Guest>();
            blockBookings = new Collection<BlockBooking>();
            _rc = new ReportControl();
        }
        #endregion

        #region Event Listeners
        private void NewBookings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MdiParent.Enabled = true;
            _newBookingFormClosed = true;
        }
        private async void NewBookings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel) return;

            if (_bookings_added)
            {
                DialogResult dr = MessageBox.Show("There are unsaved changes! Do you want to save?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    e.Cancel = true;
                    await FinalizeChanges();
                    e.Cancel = false;
                    this.Close();

                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    _bookings_added = false;
                }
            }
        }
        private void tb_GID_Leave(object sender, EventArgs e)
        {
            if (tb_GID.Text != "")
            {
                Guest temp = gc.Find(tb_GID.Text);
                if (temp == null)
                {
                    int index = FindLocalGuest(tb_GID.Text);
                    if (index != -1 && index < guests.Count)
                    {
                        temp = guests[index];
                    }
                }

                if (temp != null)
                {
                    tb_FName.Text = temp.fName;
                    tb_SName.Text = temp.sName;
                    tb_phone.Text = temp.phone;
                    tb_Email.Text = DecryptData(temp.email, _KEY, _vector);
                    tb_Address.Text = DecryptData(temp.address, _KEY, _vector);
                    tb_CCNum.Text = DecryptData(temp.ccNumber, _KEY, _vector);
                    _returning_guest = true;
                }
                else
                {
                    string ID = tb_GID.Text;
                    ClearAll();
                    tb_GID.Text = ID;
                    _returning_guest = false;
                }
            }

        }
        private void NewBookings_Load(object sender, EventArgs e)
        {
            DTP_CheckIn.MinDate = DateTime.Now.Date;
            bbc = new BlockBookingControl();

            bc = new BookingControll();
            agents = new Collection<Agent>();
            ac = new AgentController();
            gc = new GuestControll();
            cbc = new CanceledBookingControll();
            check_in = DTP_CheckIn.Value.Date;
            DTP_CheckOut.Value = DTP_CheckIn.Value.Date.AddDays(1);
            check_out = DTP_CheckOut.Value.Date;
        }
        private void rb_Agent_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Agent.Checked)
            {
                gb_agent.Visible = true;

                if (ac.agents == null)
                {
                    ac.GetAgents();
                }
                foreach (Agent a in ac.agents)
                {
                    cb_Agents.Items.Add(a.company);
                }


                cb_Agents.SelectedIndex = 0;
                rb_snglBooking.Checked = true;
            }
            else
            {
                gb_agent.Visible = false;
                cb_Agents.Items.Clear();
            }
        }
        private void cb_Agents_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Agent a in ac.agents)
            {
                if (cb_Agents.SelectedItem.Equals(a.company))
                {
                    agent = a;
                    break;
                }
            }

            SetEdit();
        }
        private void rb_blkBook_CheckedChanged(object sender, EventArgs e)
        {
            SetEdit();
            if (!rb_blkBook.Checked)
            {
                ClearAll();
            }
        }
        private void NewBookings_Activated(object sender, EventArgs e)
        {


        }
        private void lstV_New_Bookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstV_New_Bookings.SelectedItems.Count > 0)
            {
                booking = bc.Find(Convert.ToInt32(lstV_New_Bookings.SelectedItems[0].Text));
                ClearAll();
                resetData();
                btn_delete_new_booking.Visible = true;
                btn_Edit_Booking.Visible = true;
                gb_CType.Visible = false;
                gb_Guest_Details.Visible = false;
                gb_Dates.Visible = true;
            }
        }
        private void lstv_New_Block_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstv_New_Block.SelectedItems.Count > 0)
            {
                blockBooking = bbc.Find(Convert.ToInt32(lstv_New_Block.SelectedItems[0].Text));
                ClearAll();
                resetData();
                btn_Edit_Block.Visible = true;
                btn_Block_delete.Visible = true;
                gb_CType.Visible = false;
                gb_Guest_Details.Visible = false;

                gb_Dates.Visible = true;
            }
        }
        private void gb_NewBookings_Leave(object sender, EventArgs e)
        {
            btn_delete_new_booking.Visible = false;
            btn_Edit_Booking.Visible = false;
            //gb_Dates.Visible = true;
        }
        private void gb_new_BlockBooki_Leave(object sender, EventArgs e)
        {
            btn_Block_delete.Visible = false;
            btn_Edit_Block.Visible = false;
            //gb_Dates.Visible = true;
            //ClearAll();
            //resetData();
        }
        private void dtp_ci_edit_ValueChanged(object sender, EventArgs e)
        {
            dtp_co_edit.MinDate = dtp_ci_edit.Value.AddDays(1);
        }
        #endregion

        #region Input Validation Methods
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
            if (!long.TryParse(tb_GID.Text, out i))
            {
                MessageBox.Show("Guest's ID number is in an invalid format!");
                tb_GID.Focus();
                result = false;
            }

            else if (ValidValue(tb_FName.Text, 3))
            {
                MessageBox.Show("Guest's First name is in an invalid format!");
                tb_FName.Focus();
                result = false;
            }

            else if (ValidValue(tb_SName.Text, 3))
            {
                MessageBox.Show("Guest's Surname is in an invalid format!");
                tb_SName.Focus();
                result = false;
            }

            else if (!ValidValue(tb_phone.Text, 1))
            {
                MessageBox.Show("Guest's Phone number is in an invalid format!");
                tb_phone.Focus();
                result = false;
            }

            else if (!ValidValue(tb_CCNum.Text, 2))
            {
                MessageBox.Show("Guest's Credit card number is in an invalid format!");
                tb_CCNum.Focus();
                result = false;
            }

            else if (!ValidValue(tb_Email.Text, 0))
            {
                MessageBox.Show("Guest's email is in an invalid format!");
                tb_Email.Focus();
                result = false;
            }


            else if (tb_Address.Text == "")
            {
                MessageBox.Show("Guest's address is in an invalid format!");
                tb_Address.Focus();
                result = false;
            }

            return result;
        }
        private void nTB_numRooms_ValueChanged(object sender, EventArgs e)
        {
            nTB_numRooms.Value = (int)Math.Round(nTB_numRooms.Value);
            if (nTB_numRooms.Value < 1)
            {
                nTB_numRooms.Value = 1;
            }
        }
        private void nTb_People_ValueChanged(object sender, EventArgs e)
        {
            nTb_People.Value = (int)Math.Round(nTb_People.Value);
            if (nTb_People.Value < 1)
            {
                nTB_numRooms.Value = 1;
            }
        }
        private void ntb_edit_rooms_ValueChanged(object sender, EventArgs e)
        {
            ntb_edit_rooms.Value = (int)Math.Round(ntb_edit_rooms.Value);
            if (ntb_edit_rooms.Value < 1)
            {
                ntb_edit_rooms.Value = 1;
            }
        }
        private void DTP_CheckOut_ValueChanged(object sender, EventArgs e)
        {
            DTP_CheckOut.MinDate = DTP_CheckIn.Value.Date.AddDays(1);
            if (DTP_CheckOut.Value < DTP_CheckIn.Value)
            {
                MessageBox.Show("Check out date must be greater than check in date!");
                DTP_CheckOut.Value = check_out;
            }
            else
            {
                check_out = DTP_CheckOut.Value.Date;
            }
        }
        private void DTP_CheckIn_ValueChanged(object sender, EventArgs e)
        {
            if (DTP_CheckIn.Value > DTP_CheckOut.Value)
            {
                check_in = DTP_CheckIn.Value.Date.AddDays(1);
                DTP_CheckOut.Value = check_in;
            }
            else
            {
                check_in = DTP_CheckIn.Value.Date;
                DTP_CheckOut.MinDate = check_in.AddDays(1);
            }
        }
        #endregion

        #region Utility Methods
        private async Task FinalizeChanges()
        {
            lbl_sending_emails.Visible = true;
            pb_Email_Progress.Visible = true;
            await SendEmails();

            SaveToDatabase();
            lbl_sending_emails.Visible = false;
            lbl_sending_emails.Text = "Sending Confirmation Emails";
            pb_Email_Progress.Visible = false;

        }
        private async Task SendEmails()
        {
            string staffName = "";
            int total = bookings.Count + blockBookings.Count;
            int count = 0;
            var progress = new Progress<int>(percent => pb_Email_Progress.Value = percent);
            string subject = "Booking confirmation";
            StaffControll sc = new StaffControll();
            foreach (var s in sc.allStaff)
            {
                if (s.empID == _empID)
                {
                    staffName = $"{s.fName} {s.sName}";
                }
            }

            lbl_sending_emails.Text = "Sending confirmation emails to guests";
            foreach (Booking booking in bookings)
            {
                Guest guest = gc.Find(booking.customer_ID);
                string body = $"Dear {guest.fName} {guest.sName}\nThis email is to confirm your booking for the period of {booking.check_In.ToShortDateString()} to {booking.check_out.ToShortDateString()}.\nBooking Number:\t{booking.bookingNumber}" +
                $"\nRooms:\t{booking.numRooms}\nDeposit paid:\tR{Math.Round(booking.deposit)}\nAmount outstanding:\tR{Math.Round(booking.price - booking.deposit)}\nWe look forward to seeing you soon.\nSincerly\n{staffName}";
                count++;
                guest.email = DecryptData(guest.email, _KEY, _vector);
                await _rc.SendConfirmationEmailGuest(_empID, guest, progress, total, count, subject, body);


                //pb_Email_Progress.Value = (count / total) * 100;
            }
            lbl_sending_emails.Text = "Sending emails to travel agents";
            foreach (BlockBooking bb in blockBookings)
            {
                string body = $"To {agent.company} \nThis email is to confirm your block booking for the period of {bb.start_date.ToShortDateString()} to {bb.end_date.ToShortDateString()}.\nBooking Number:\t{bb.block_booking_id}" +
               $"\nRooms:\t{bb.num_rooms}\nDeposit paid:\tR{Math.Round(bb.deposit_amount)}\nAmount outstanding:\tR{Math.Round(bb.price - bb.deposit_amount)}\nPlease inform us when you wish to assign guests.\nSincerly\n{staffName}";
                count++;
                Agent temp = ac.Find(bb.agent_ID);
                await _rc.SendConfirmationEmailAgent(_empID, temp, progress, total, count, subject, body);
            }
            lbl_sending_emails.Text = "DONE";
        }
        public void SaveToDatabase()
        {
            int numchanges;
            numchanges = gc.UpdateDataSource();
            string message = $"{numchanges} guests added/modified in database.\n";
            numchanges = bc.UpdateDataSource();
            message += $"{numchanges} bookings added to database\n";
            numchanges = bbc.UpdateDataSource();
            message += $"{numchanges} block bookings added to database";

            MessageBox.Show(message);
            guests.Clear();
            bookings.Clear();
            blockBookings.Clear();
            _bookings_added = false;
            SetupView();
        }
        public int FindLocalGuest(string id)
        {
            int index = -1;

            foreach (Guest g in guests)
            {
                index++;
                if (g.ID == id)
                {
                    return index;
                }

            }
            return -1;
        }
        private Agent GetAgent()
        {
            foreach (Agent a in ac.agents)
            {
                if (cb_Agents.SelectedItem.Equals(a.company))
                {
                    return a;
                }
            }
            return null;
        }
        private void ClearAll()
        {
            tb_Address.Text = "";
            tb_CCNum.Text = "";
            tb_Email.Text = "";
            tb_FName.Text = "";
            tb_SName.Text = "";
            tb_GID.Text = "";
            tb_phone.Text = "";

        }
        private void SetEdit()
        {
            if (rb_blkBook.Checked)
            {
                tb_FName.Enabled = false;
                tb_SName.Enabled = false;
                tb_GID.Enabled = false;
                tb_phone.Enabled = false;
                tb_Email.Enabled = false;
                tb_Address.Enabled = false;
                tb_CCNum.Enabled = false;
                //_agent_ID = agent.agentID;
                tb_FName.Text = agent.company;
                tb_SName.Text = "N/A";
                tb_phone.Text = agent.phone;
                tb_Email.Text = agent.email;
                tb_Address.Text = agent.address;
                tb_CCNum.Text = "N/A";
            }
            else
            {
                tb_GID.Enabled = true;
                tb_FName.Enabled = true;
                tb_SName.Enabled = true;
                tb_phone.Enabled = true;
                tb_Email.Enabled = true;
                tb_Address.Enabled = true;
                tb_CCNum.Enabled = true;
            }

        }
        private void resetData()
        {
            btn_changeDates.Visible = false;
            btn_Check_Dates.Visible = true;
            DTP_CheckIn.Enabled = true;
            DTP_CheckOut.Enabled = true;
            nTB_numRooms.Enabled = true;
            btn_Check_Dates.Visible = true;
            gb_CType.Visible = false;
            gb_Guest_Details.Visible = false;
            rb_Person.Checked = true;
            rb_snglBooking.Checked = true;
            gb_Dates.Visible = true;
            rb_blkBook.Enabled = true;
            rb_snglBooking.Enabled = true;
            lbl_ci_edit.Visible = false;
            lbl_co_edit.Visible = false;
            lbl_new_rooms.Visible = false;
            dtp_ci_edit.Visible = false;
            dtp_co_edit.Visible = false;
            ntb_edit_rooms.Visible = false;
        }
        private int FindLocalBooking(int id)
        {
            int index = -1;
            foreach (Booking b in bookings)
            {
                index++;
                if (b.bookingNumber == id)
                {
                    return index;
                }

            }
            return index;
        }
        private int FindLocalBlockBooking(int id)
        {
            int index = -1;
            foreach (BlockBooking b in blockBookings)
            {
                index++;
                if (b.block_booking_id == id)
                {
                    return index;
                }
            }
            return -1;
        }
        private void PopulateTextBoxes(Booking b)
        {

            tb_BN.Text = b.bookingNumber.ToString();
            dtp_ci_edit.MinDate = DateTime.Now.Date;
            dtp_ci_edit.Value = b.check_In;
            dtp_co_edit.MinDate = dtp_ci_edit.Value.Date.AddDays(1);
            dtp_co_edit.Value = b.check_out;
            ntb_edit_rooms.Value = b.numRooms;

            tb_GID.Enabled = true;
            tb_GID.Text = b.customer_ID.ToString();

            Guest tempGuest = gc.Find(b.customer_ID);
            if (tempGuest == null)
            {
                int index = FindLocalGuest(b.customer_ID);
                if (index != -1 && index < guests.Count)
                {
                    tempGuest = guests[index];
                }
            }
            if (tempGuest != null)
            {
                tb_FName.Text = tempGuest.fName;
                tb_SName.Text = tempGuest.sName;
                tb_phone.Text = tempGuest.phone;
                tb_Email.Text = DecryptData(tempGuest.email, _KEY, _vector);
                tb_CCNum.Text = DecryptData(tempGuest.ccNumber, _KEY, _vector);
                tb_Address.Text = DecryptData(tempGuest.address, _KEY, _vector); 
            }
            else
            {
                Agent tempAgent = ac.Find(b.agent_ID);

                tb_FName.Text = tempAgent.company;
                tb_SName.Text = "N/A";
                tb_phone.Text = tempAgent.phone;
                tb_Email.Text = tempAgent.email;
                tb_Address.Text = tempAgent.address;
                tb_CCNum.Text = "N/A";
            }

        }
        private void ShowConflicts()
        {
            lsv_conflicts.Items.Clear();
            lsv_conflicts.View = View.Details;
            lsv_conflicts.GridLines = true;
            lsv_conflicts.Columns.Insert(0, "Date", 120, HorizontalAlignment.Left);
            lsv_conflicts.Columns.Insert(1, "Rooms Available", 120, HorizontalAlignment.Center);
            lsv_conflicts.Columns.Insert(2, "Rooms Required", 120, HorizontalAlignment.Center);

            DateTime start, end;

            if (DTP_CheckIn.Value.Date.AddDays(-5) > DateTime.Now.Date)
            {
                start = (DTP_CheckIn.Value.Date.AddDays(-5));
            }
            else
            {
                start = DateTime.Now.Date;
            }
            int requiredRooms = (int)nTB_numRooms.Value;
            for (DateTime day = start; day < DTP_CheckOut.Value.Date.AddDays(5); day = day.AddDays(1))
            {
                int booked = bc.CheckOccupencyLevel(day, false, null);
                int block = bbc.GetOccupancyLevel(day, false, null);
                ListViewItem detail = new ListViewItem();
                detail.Text = day.ToShortDateString();
                int value = ROOMS - (booked + block);
                detail.SubItems.Add(Convert.ToString(value));
                detail.SubItems.Add(Convert.ToString(requiredRooms));
                if (value < requiredRooms)
                {
                    detail.BackColor = Color.Red;
                }
                else
                {
                    detail.BackColor = Color.Green;
                }
                lsv_conflicts.Items.Add(detail);
            }
            lsv_conflicts.Refresh();
        }

        private string EncryptData(string data, byte[] key, byte[] vector)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = vector;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(data);
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
        }

        private string DecryptData(string data, byte[] key, byte[] vector)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = vector;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(data)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    

        #endregion

        #region Buttons
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            lbl_ci_edit.Visible = false;
            lbl_co_edit.Visible = false;
            dtp_ci_edit.Visible = false;
            dtp_co_edit.Visible = false;
            lbl_new_rooms.Visible = false;
            ntb_edit_rooms.Visible = false;
            btn_confirm_edit.Visible = false;
            btn_add_booking.Visible = true;
            ntb_edit_rooms.Visible = false;
            gb_Dates.Visible = true;
            rb_snglBooking.Enabled = true;
            rb_Person.Enabled = true;
            ClearAll();
            resetData();
        }
        private void btn_delete_new_booking_Click(object sender, EventArgs e)
        {
            int index = FindLocalBooking(booking.bookingNumber);
            bc.UpdateDataSet(booking, 3);
            foreach (Booking b in bookings)
            {
                if (b.bookingNumber > booking.bookingNumber)  // Looking for new bookings where the booking number is greater than the booking that has been deleted
                {
                    bc.UpdateDataSet(b, 3); //removing the booking from the data set
                    b.bookingNumber -= 1;   //reducing the booking number by one
                    bc.UpdateDataSet(b, 2); //Adding the booking with the new booking number to the dataset
                }
            }
            foreach (BlockBooking b in blockBookings)
            {
                if (b.block_booking_id > booking.bookingNumber)
                {
                    bbc.UpdateDataSet(b, 3);
                    b.block_booking_id -= 1;
                    bbc.UpdateDataSet(b, 2);
                }
            }
            bookings.RemoveAt(index);
            btn_delete_new_booking.Visible = false;
            btn_Edit_Booking.Visible = false;
            SetupView();
        }
        private void btn_Block_delete_Click(object sender, EventArgs e)
        {
            int index = FindLocalBlockBooking(blockBooking.block_booking_id);
            bbc.UpdateDataSet(blockBooking, 3);
            foreach (Booking b in bookings)
            {
                if (b.bookingNumber > blockBooking.block_booking_id)  // Looking for new bookings where the booking number is greater than the booking that has been deleted
                {
                    bc.UpdateDataSet(b, 3); //removing the booking from the data set
                    b.bookingNumber -= 1;   //reducing the booking number by one
                    bc.UpdateDataSet(b, 2); //Adding the booking with the new booking number to the dataset
                }
            }
            foreach (BlockBooking b in blockBookings)
            {
                if (b.block_booking_id > blockBooking.block_booking_id)
                {
                    bbc.UpdateDataSet(b, 3);
                    b.block_booking_id -= 1;
                    bbc.UpdateDataSet(b, 2);
                }
            }
            blockBookings.RemoveAt(index);
            btn_Block_delete.Visible = false;
            btn_Edit_Block.Visible = false;
            SetupView();
        }
        private void btn_changeDates_Click(object sender, EventArgs e)
        {
            resetData();
        }
        private void btn_Check_Dates_Click(object sender, EventArgs e)
        {
            resetData();
            SetEdit();
            rb_Person.Enabled = true;
            rb_Agent.Enabled = true;
            int bN = 0;
            int cBN = 0;
            int bBN = 0;
            check_in = DTP_CheckIn.Value.Date;
            check_out = DTP_CheckOut.Value.Date;
            int req_Rooms = (int)nTB_numRooms.Value;
            bool space = true;



            for (DateTime d = check_in.Date; d <= check_out.Date; d = d.AddDays(1))
            {
                int bookedRooms = bc.CheckOccupencyLevel(d, false, null);
                int blockBookedRooms = bbc.GetOccupancyLevel(d, false, null);

                if (bookedRooms + blockBookedRooms + req_Rooms > ROOMS)
                {
                    space = false;
                }

            }


            _price = 0;

            if (!space)
            {
                gb_conflict.Text = "Insufficient Rooms!";
                gb_conflict.Visible = true;
                ShowConflicts();
            }
            else
            {
                gb_conflict.Visible = false;
                gb_CType.Visible = true;
                gb_Guest_Details.Visible = true;
                btn_changeDates.Visible = true;
                DTP_CheckIn.Enabled = false;
                DTP_CheckOut.Enabled = false;
                nTB_numRooms.Enabled = false;
                btn_Check_Dates.Visible = false;


                if (bc.bookings.Count != 0)
                {
                    bN = bc.bookings.Last().bookingNumber + 1;
                }

                if (cbc.canceledBookings.Count != 0)
                {
                    cBN = cbc.canceledBookings.Last().id + 1;
                }

                if (bbc.bBookings.Count != 0)
                {
                    bBN = bbc.bBookings.Last().block_booking_id + 1;
                }

                int newBN = Math.Max(bN, cBN);
                newBN = Math.Max(newBN, bBN);

                tb_BN.Text = Convert.ToString(newBN);


                _price = bc.CalculatePrice(check_in, check_out, req_Rooms);
                _deposit = _price * (decimal)0.1;
                tb_Deposit.Text = Convert.ToString(_deposit);
                tb_price.Text = Convert.ToString(_price);
                if (DTP_CheckIn.Value.Date > DateTime.Now.Date)
                {
                    depDate = check_in.Date.AddDays(-14);
                }
                else
                {
                    depDate = DateTime.Now.Date;
                }
                string depDue = $"{depDate.Year}/{depDate.Month}/{depDate.Day}";
                tb_depDue.Text = depDue;
            }

        }
        private void btn_add_booking_Click(object sender, EventArgs e)
        {
            bool infoRequired = true;

            int type = 0;
            Agent temp = new Agent();

            if (!rb_blkBook.Checked)
            {
                infoRequired = AllValuesValid();
            }

            if (infoRequired)
            {
                if (rb_Person.Checked)
                {
                    temp.agentID = "N/A";
                    type = 0;
                }
                else if (rb_Agent.Checked)
                {
                    temp = GetAgent();

                    if (rb_snglBooking.Checked)
                    {
                        type = 2;
                    }
                    else if (rb_blkBook.Checked)
                    {
                        type = 1;
                    }
                }
                if (type == 1)
                {
                    BlockBooking newBlockBooking = new BlockBooking()
                    {
                        block_booking_id = Convert.ToInt32(tb_BN.Text),
                        agent_ID = temp.agentID,
                        start_date = DTP_CheckIn.Value.Date,
                        end_date = DTP_CheckOut.Value.Date,
                        dep_due = depDate,
                        deposit_amount = Convert.ToDecimal(tb_Deposit.Text),
                        num_rooms = (int)nTB_numRooms.Value,
                        price = Convert.ToDecimal(tb_price.Text),
                        added_by = _empID,
                        modified_by = ""
                    };
                    
                    
                    bbc.UpdateDataSet(newBlockBooking, 2);
                    blockBookings.Add(newBlockBooking);
                    SetupView();
                }
                else
                {
                    Booking newBooking = new Booking
                    {
                        bookingNumber = Convert.ToInt32(tb_BN.Text),
                        people = (int)nTB_numRooms.Value,
                        customer_ID = tb_GID.Text,
                        depDue = depDate,
                        deposit = Convert.ToDecimal(tb_Deposit.Text),
                        booking_type = type,
                        agent_ID = temp.agentID,
                        check_In = DTP_CheckIn.Value.Date,
                        check_out = DTP_CheckOut.Value.Date,
                        invoiceNumber = Convert.ToInt32(tb_BN.Text),
                        price = Convert.ToDecimal(tb_price.Text),
                        numRooms = (int)nTB_numRooms.Value,
                        block_booking_ID = -1,
                        confirmed = 1,
                        added_by = _empID,
                        modeified_by = ""
                    };

                    bc.UpdateDataSet(newBooking, 2);

                    Guest guest = new Guest
                    {
                        ID = tb_GID.Text,
                        fName = tb_FName.Text,
                        sName = tb_SName.Text,
                        bookingID = Convert.ToInt32(tb_BN.Text),
                        email = EncryptData(tb_Email.Text, _KEY, _vector),
                        phone = tb_phone.Text,
                        address = EncryptData(tb_Address.Text, _KEY, _vector),
                        ccNumber = EncryptData(tb_CCNum.Text, _KEY, _vector)
                    };

                    if (!rb_blkBook.Checked)
                    {
                        if (_returning_guest)
                        {
                            gc.ModifyGuest(guest, 1);
                        }
                        else
                        {
                            gc.ModifyGuest(guest, 2);
                        }
                    }
                    bookings.Add(newBooking);
                    guests.Add(guest);
                    SetupView();
                }

                _returning_guest = false;
                //_guest_Updated = false;
                rb_Person.Checked = true;
                rb_snglBooking.Checked = true;
                ClearAll();
                resetData();
                _bookings_added = true;
            }

        }
        private void btn_Edit_Booking_Click(object sender, EventArgs e)
        {
            
            state = 1;
            //Booking temp = bc.Find(booking.bookingNumber);
            gb_Guest_Details.Visible = true;
            dtp_ci_edit.Visible = true;
            dtp_co_edit.Visible = true;
            lbl_ci_edit.Visible = true;
            lbl_co_edit.Visible = true;
            ntb_edit_rooms.Visible = true;
            lbl_new_rooms.Visible = true;
            btn_confirm_edit.Visible = true;
            ntb_edit_rooms.Visible = true;
            gb_Dates.Visible = false;
            
            btn_add_booking.Visible = false;
            if (booking.booking_type == 2)
            {
                gb_CType.Visible = true;
                gb_agent.Visible = true;
                agent = ac.Find(booking.agent_ID);
                rb_Person.Enabled = true;
                rb_snglBooking.Enabled = true;
                rb_Agent.Checked = true;
                rb_snglBooking.Checked = true;
                rb_blkBook.Enabled = false;
                Agent temp = ac.Find(booking.agent_ID);
                string company = temp.company;
                for (int i = 0; i < cb_Agents.Items.Count; i++)
                {
                    if (cb_Agents.Items[i].Equals(company))
                    {
                        cb_Agents.SelectedIndex = i;
                        break;
                    }
                }
                
            }
            else
            {
                rb_Person.Checked = true;
                rb_blkBook.Checked = false;
            }
            PopulateTextBoxes(booking);
        }
        private void btn_Edit_Block_Click(object sender, EventArgs e)
        {
            state = 2;
            gb_Guest_Details.Visible = true;
            dtp_ci_edit.Visible = true;
            dtp_co_edit.Visible = true;
            lbl_ci_edit.Visible = true;
            lbl_co_edit.Visible = true;
            lbl_new_rooms.Visible = true;
            ntb_edit_rooms.Visible = true;
            gb_Dates.Visible = false;
            btn_confirm_edit.Visible = true;
            btn_add_booking.Visible = false;
            rb_Agent.Checked = true;
            agent = ac.Find(blockBooking.agent_ID);
            string company = agent.company;
            for (int i = 0; i < cb_Agents.Items.Count; i++)
            {
                if (cb_Agents.Items[i].Equals(company))
                {
                    cb_Agents.SelectedIndex = i;
                    break;
                }
            }

            Booking temp = new Booking()
            { 
                bookingNumber = blockBooking.block_booking_id,
                customer_ID = "",
                check_In = blockBooking.start_date,
                check_out = blockBooking.end_date,
                numRooms = blockBooking.num_rooms,
                agent_ID = blockBooking.agent_ID,


            };


            PopulateTextBoxes(temp);
            
            gb_CType.Visible = true;
            rb_Agent.Checked = true;
            rb_Person.Enabled = false;
            rb_blkBook.Checked = true;
            SetEdit();
            rb_snglBooking.Enabled = false;
        }
        private void btn_confirm_edit_Click(object sender, EventArgs e)
        {
            bool space = true;

            int req_rooms = (int)ntb_edit_rooms.Value;

            if (state == 1)
            {
                for (DateTime d = check_in.Date; d <= check_out.Date; d = d.AddDays(1))
                {
                    int bookedRooms = bc.CheckOccupencyLevel(d, true, booking);
                    int blockBookedRooms = bbc.GetOccupancyLevel(d, false, null);

                    if (bookedRooms + blockBookedRooms + req_rooms > ROOMS)
                    {
                        space = false;
                        break;
                    }
                }

                if (!space)
                {
                    MessageBox.Show("There is no space in available");
                }
                else
                {
                    decimal price = bc.CalculatePrice(dtp_ci_edit.Value, dtp_co_edit.Value, (int)nTB_numRooms.Value);
                    decimal deposit = price * (decimal)0.1;

                    booking.people = (int)nTB_numRooms.Value;
                    booking.customer_ID = tb_GID.Text;
                    booking.check_In = dtp_ci_edit.Value;
                    booking.check_out = dtp_co_edit.Value;
                    booking.price = price;
                    booking.deposit = deposit;
                    booking.agent_ID = agent.agentID;
                    if (dtp_ci_edit.Value.AddDays(-14) > DateTime.Now.Date)
                    {
                        booking.depDue = dtp_ci_edit.Value.AddDays(-14);
                    }
                    else
                    {
                        booking.depDue = DateTime.Now.Date;
                    }
                    booking.numRooms = (int)ntb_edit_rooms.Value;

                    bc.UpdateDataSet(booking, 1);

                    int index = FindLocalBooking(booking.bookingNumber);
                    bookings[index] = booking;

                    Guest guest = new Guest()
                    {
                        ID = tb_GID.Text,
                        fName = tb_FName.Text,
                        sName = tb_SName.Text,
                        email = EncryptData(tb_Email.Text, _KEY, _vector),
                        bookingID = booking.bookingNumber,
                        phone = tb_phone.Text,
                        address = EncryptData(tb_Address.Text, _KEY, _vector),
                        ccNumber = EncryptData(tb_CCNum.Text, _KEY, _vector)
                    };
                        gc.ModifyGuest(guest, 1);
                }
            }
            else if (state == 2)
            {
                for (DateTime d = check_in.Date; d <= check_out.Date; d = d.AddDays(1))
                {
                    int bookedRooms = bc.CheckOccupencyLevel(d, false, null);
                    int blockBookedRooms = bbc.GetOccupancyLevel(d, true, blockBooking);

                    if (bookedRooms + blockBookedRooms + req_rooms > ROOMS)
                    {
                        space = false;
                        break;
                    }
                }

                if (!space)
                {
                    MessageBox.Show("There is no space in available");
                }
                else
                {
                    decimal price = bc.CalculatePrice(dtp_ci_edit.Value, dtp_co_edit.Value, (int)nTB_numRooms.Value);
                    decimal deposit = price * (decimal)0.1;

                    blockBooking.agent_ID = agent.agentID;
                    blockBooking.start_date= dtp_ci_edit.Value;
                    blockBooking.end_date = dtp_co_edit.Value;
                    blockBooking.price = price;
                    blockBooking.deposit_amount = deposit;
                    //booking.agent_ID = agent.agentID;
                    if (dtp_ci_edit.Value.AddDays(-14) > DateTime.Now.Date)
                    {
                        blockBooking.dep_due = dtp_ci_edit.Value.AddDays(-14);
                    }
                    else
                    {
                        blockBooking.dep_due = DateTime.Now.Date;
                    }
                    blockBooking.num_rooms = (int)ntb_edit_rooms.Value;

                    bbc.UpdateDataSet(blockBooking, 1);

                    int index = FindLocalBlockBooking(blockBooking.block_booking_id);
                    if (index != -1 && index < blockBookings.Count)
                    {
                        blockBookings[index] = blockBooking;
                    }
                }
            }

            if (space)
            {
                resetData();
                SetupView();
                
                
                ClearAll();
                state = 0;
                btn_confirm_edit.Visible = false;
                btn_add_booking.Visible = true;
                ntb_edit_rooms.Visible = false;
                gb_Dates.Visible = true;
                rb_snglBooking.Enabled = true;
            }
        }
        private void btn_update_data_base_Click(object sender, EventArgs e)
        {
            _ = FinalizeChanges();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Setup View
        public void SetupView()
        {
            lstV_New_Bookings.Clear();
            lstV_New_Bookings.View = View.Details;
            lstV_New_Bookings.GridLines = true;
            lstV_New_Bookings.Columns.Insert(0, "Booking ID", 100, HorizontalAlignment.Center);
            lstV_New_Bookings.Columns.Insert(1, "Guest ID", 60, HorizontalAlignment.Center);
            lstV_New_Bookings.Columns.Insert(2, "Check in", 85, HorizontalAlignment.Center);
            lstV_New_Bookings.Columns.Insert(3, "Check out", 85, HorizontalAlignment.Center);
            lstV_New_Bookings.Columns.Insert(4, "Rooms", 50, HorizontalAlignment.Center);

            lstv_New_Block.Clear();
            lstv_New_Block.GridLines = true;
            lstv_New_Block.View = View.Details;
            lstv_New_Block.Columns.Insert(0, "Block Booking ID", 100, HorizontalAlignment.Center);
            lstv_New_Block.Columns.Insert(1, "Agent ID", 60, HorizontalAlignment.Center);
            lstv_New_Block.Columns.Insert(2, "Start Date", 85, HorizontalAlignment.Center);
            lstv_New_Block.Columns.Insert(3, "End Date", 85, HorizontalAlignment.Center);
            lstv_New_Block.Columns.Insert(4, "Rooms", 50, HorizontalAlignment.Center);


            ListViewItem bookingDetail;

            foreach (Booking b in bookings)
            {
                
                bookingDetail = new ListViewItem();
                bookingDetail.Text = b.bookingNumber.ToString();
                bookingDetail.SubItems.Add(b.customer_ID.ToString());
                bookingDetail.SubItems.Add(b.check_In.ToShortDateString());
                bookingDetail.SubItems.Add(b.check_out.ToShortDateString());
                bookingDetail.SubItems.Add(b.numRooms.ToString());

                lstV_New_Bookings.Items.Add(bookingDetail);
            }
            lstV_New_Bookings.Refresh();

            foreach (BlockBooking b in blockBookings) 
            {
                bookingDetail = new ListViewItem();
                bookingDetail.Text = b.block_booking_id.ToString();
                bookingDetail.SubItems.Add(b.agent_ID.ToString());
                bookingDetail.SubItems.Add(b.start_date.ToShortDateString());
                bookingDetail.SubItems.Add(b.end_date.ToShortDateString());
                bookingDetail.SubItems.Add(b.num_rooms.ToString());

                lstv_New_Block.Items.Add(bookingDetail);
            }
            lstv_New_Block.Refresh();
        }
        #endregion
    }
}
