using HotelManagementSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using HotelManagementSystem.Business.Clients;
using System.IO;
using System.Security.Cryptography;

namespace HotelManagementSystem.Presentation
{
    public partial class CurrentBookings : Form
    {
        #region Data Members
        private const int TOTALROOMS = 5;
        private bool _currentBookingsClosed;
        private string _empID;
        private byte[] _KEY = Encoding.UTF8.GetBytes("aWsc@lFcOwHq31Nq");
        private byte[] _vector = Encoding.UTF8.GetBytes("pKnc.qwsX5OpwMhQ");

        private BookingControll _bc;
        private GuestControll _gc;
        private AgentController _ac;
        private CanceledBookingControll _cbc;
        private BlockBookingControl _bbc;

        private Collection<Guest> _guests;
        private Collection<CanceledBooking> _canceledBookings;
        private Collection<BlockBooking> _blockBookings;
        private Collection<Booking> _bookings;
        private Collection<Agent> _agents;

        private Booking booking;
        private BlockBooking blockBooking;
        private Guest guest = new Guest();
        private Agent agent = new Agent();
        private CanceledBooking cb;

        private int _daysBooked;
        private bool _returning_guest = false;
        private bool _changes_made = false;
        #endregion

        #region Mutators
        public bool currentBookingsClosed { get => _currentBookingsClosed; set => _currentBookingsClosed = value; }
        #endregion

        #region Constructors
        public CurrentBookings(string emp)
        {
            InitializeComponent();
            _empID = emp;
            this.Load += CurrentBookings_Load;
            this.Activated += CurrentBookings_Activated;
            this.FormClosing += new FormClosingEventHandler(CurrentBookings_FormClosing);
            this.FormClosed += CurrentBookings_FormClosed;

            _bbc = new BlockBookingControl();
            _bc = new BookingControll();
            _gc = new GuestControll();
            _cbc = new CanceledBookingControll();
            _ac = new AgentController();
            _guests = new Collection<Guest>();
            _bookings = new Collection<Booking>();
            _canceledBookings = new Collection<CanceledBooking>();
            if (_bc.bookings != null) { _bookings = _bc.bookings; }
            if (_bbc.bBookings != null) { _blockBookings = _bbc.bBookings; }
            if (_gc.guests != null) { _guests = _gc.guests; }
            if (_ac.agents != null) { _agents = _ac.agents; }
            
        }
        #endregion

        #region Utility Methods
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
        public void SaveToDataBase()
        {
            bool proceed = true;
            if (_canceledBookings.Count > 0)
            {
                DialogResult dr = MessageBox.Show($"{_canceledBookings.Count} bookings will be permenantly deleted from database! \nDo you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    proceed = false;
                }
            }
            if(proceed)
            {
                int count;
                count = _gc.UpdateDataSource();
                string message = $"{count} guest records modified/added to database.\n";
                count = _bc.UpdateDataSource();
                _bbc.UpdateDataSource();
                message += $"{count} bookings modified/added to database.\n";
                count = _cbc.UpdateDataSource();
                message += $"{count} bookings canceled and deleted from database";

                MessageBox.Show(message);
            }
            _changes_made = false;
        }
        private void ResetDates()
        {
            dtp_check_in.MinDate = DateTime.Now.Date;
            dtp_check_in.MaxDate = Convert.ToDateTime("9992/12/30");
            dtp_check_out.MinDate = DateTime.Now.Date.AddDays(1);
            dtp_check_out.MaxDate = Convert.ToDateTime("9992/12/31");
        }
        private int GetNewKey()
        {
            int key = 0;
            int cKey, bKey, bbKey;
            if (_canceledBookings.Count != 0)
            { cKey = _canceledBookings.Last().id; }
            else
            { cKey = 0; }

            if (_bookings.Count != 0)
            { bKey = _bookings.Last().bookingNumber; }
            else
            { bKey = 0; }

            if (_blockBookings.Count != 0)
            { bbKey = _blockBookings.Last().block_booking_id; }
            else
            { bbKey = 0; }

            key = Math.Max(cKey, bKey);
            key = Math.Max(key, bbKey) + 1;

            return key;

        }
        private void SetEdit(bool value)
        {
            tb_g_address.Enabled = value;
            tb_g_cc_num.Enabled = value;
            tb_g_email.Enabled = value;
            tb_g_phone.Enabled = value;
            tb_g_s_name.Enabled = value;
            tb_g_f_name.Enabled = value;
            dtp_check_in.Enabled = value;
            dtp_check_out.Enabled = value;
            ntb_NumRooms.Enabled = value;
            gb_agent.Enabled = value;
            nTb_people.Enabled = value;
        }
        private void PopulateGuestDetails(Guest g)
        {
            tb_g_guest_id.Text = g.ID;
            tb_g_f_name.Text = g.fName;
            tb_g_s_name.Text = g.sName;
            tb_g_email.Text = DecryptData(g.email, _KEY, _vector);
            tb_g_cc_num.Text = DecryptData(g.ccNumber,_KEY,_vector);
            tb_g_address.Text = DecryptData(g.address, _KEY, _vector);
            tb_g_phone.Text = g.phone;
        }
        private void PopulateAgentDetails(Agent agent)
        {
            cb_agents.Items.Clear();
            foreach (Agent a in _agents)
            {
                cb_agents.Items.Add(a.company);
            }
            for (int i = 0; i < cb_agents.Items.Count; i++)
            {
                if (cb_agents.Items[i].Equals(agent.company))
                {
                    cb_agents.SelectedItem = cb_agents.Items[i];
                }
            }

        }
        private void PopulateBoxes(BlockBooking b, Agent a)
        {
            tb_booking_number.Text = Convert.ToString(b.block_booking_id);
            tb_deposit_amount.Text = Convert.ToString(Math.Round(b.deposit_amount, 2));
            dtp_dep_date.Value = b.dep_due;
            tb_price.Text = Convert.ToString(Math.Round(b.price, 2));
            dtp_check_out.Value = b.end_date;
            dtp_check_in.Value = b.start_date;

            ntb_NumRooms.Value = b.num_rooms;
            PopulateAgentDetails(a);
            ClearGuestBox();

        }
        private void PopulateBoxes(Booking b, Guest g, Agent a, int flag)
        {
            tb_booking_number.Text = Convert.ToString(b.bookingNumber);
            tb_deposit_amount.Text = Convert.ToString(Math.Round(b.deposit, 2));
            dtp_dep_date.Value = b.depDue;
            tb_price.Text = Convert.ToString(Math.Round(b.price, 2));
            dtp_check_in.Value = b.check_In;
            dtp_check_out.Value = b.check_out;
            nTb_people.Value = b.people;

            ntb_NumRooms.Value = b.numRooms;

            if (flag == 0)
            {
                PopulateGuestDetails(g);
            }

            if (flag == 1)
            {
                PopulateAgentDetails(a);
                ClearGuestBox();
            }
            else if (flag == 2)
            {
                PopulateGuestDetails(g);
                PopulateAgentDetails(a);
            }

        }
        private void ClearGuestBox()
        {
            tb_g_guest_id.Text = "";
            tb_g_f_name.Text = "";
            tb_g_s_name.Text = "";
            tb_g_email.Text = "";
            tb_g_cc_num.Text = "";
            tb_g_address.Text = "";
            tb_g_phone.Text = "";
        }
        private string FormatDate(DateTime d)
        {
            return $"{d.Year}/{d.Month}/{d.Day}";
        }
        private int GetViewState()
        {
            if (rb_Block_Bookings.Checked) { return 2; }
            else if (rb_Current_Bookings.Checked) { return 1; }
            else { return -1; }
        }
        private bool CheckAvailability(DateTime ci, DateTime co, int flag)
        {
            bool space = true;
            if (flag == 1) //checking if modifying an existing booking is possible with regards to occupency
            {
                for (DateTime day = ci; day < co; day = day.AddDays(1))
                {
                    int booked = _bc.CheckOccupencyLevel(day, true, booking);
                    int blockBookedRooms;
                    if (blockBooking == null)
                    {
                        blockBookedRooms = _bbc.GetOccupancyLevel(day, false, null);
                    }
                    else
                    {
                        blockBookedRooms = _bbc.GetOccupancyLevel(day, true, blockBooking);
                    }


                    int difference = (int)ntb_NumRooms.Value;
                    if (booked + blockBookedRooms + difference > TOTALROOMS)
                    {
                        return false;
                    }
                }
            }

            if (flag == 2)  //checking if block booking has enough rooms to assign rooms to guests
            {
                for (DateTime day = ci; day < co; day = day.AddDays(1))
                {
                    int available = blockBooking.num_rooms;
                    int assignedRooms = _bbc.GetBlockBookingRooms(_bookings, blockBooking.block_booking_id, day);
                    if (assignedRooms + (int)ntb_NumRooms.Value > available)
                    {
                        return false;
                    }
                }
            }

            return space;
        }
        private void Search()
        {
            bool found = false;
            foreach (Booking b in _bc.bookings)
            {
                if(b.customer_ID == tb_search.Text)
                {
                    int index = 0;
                    foreach (ListViewItem l in lstV_Bookings.Items)
                    {

                        lstV_Bookings.Items[index].BackColor = Color.White;
                        lstV_Bookings.Refresh();
                        if (l.Text == Convert.ToString(b.bookingNumber))
                        {
                            lstV_Bookings.Items[index].BackColor = Color.Aqua;
                            found = true;
                        }
                        index++;
                    }
                    if (found)
                    {
                        break;
                    }
                }
            }
        }
        #endregion

        #region Events
        private void cb_agents_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Agent a in _ac.agents)
            {
                if (a.company.Equals(cb_agents.SelectedItem))
                {
                    agent = a;
                    break;
                }
            }
        }
        private void CurrentBookings_Load(object sender, EventArgs e)
        {
            int viewState = GetViewState();
            setUpView(viewState);
        }
        private void lstV_Bookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetDates();
            int flag = 0;
            tb_g_guest_id.Enabled = false;
            if (lstV_Bookings.SelectedItems.Count > 0)
            {

                int state = GetViewState();

                if (state == 1) //Current booking view
                {
                    booking = _bc.Find(Convert.ToInt32(lstV_Bookings.SelectedItems[0].Text));
                    _daysBooked = booking.check_out.DayOfYear - booking.check_In.DayOfYear;
                    if (booking.booking_type == 0)
                    {
                        guest = _gc.Find(booking.customer_ID);
                        gb_agent.Visible = false;
                    }
                    else if (booking.booking_type == 2)
                    {
                        agent = _ac.Find(booking.agent_ID);
                        flag = 2;
                        guest = _gc.Find(booking.customer_ID);
                        gb_agent.Visible = true;
                    }
                    try
                    {
                        PopulateBoxes(booking, guest, agent, flag);
                    }
                    catch { }

                    btn_confirm_edit.Visible = false;
                    gb_edit_booking.Visible = true;
                    btn_edit.Visible = true;
                    btn_delete.Visible = true;
                    btn_confirm_edit.Visible = false;
                    gb_edit_Block.Visible = false;

                }
                else if (state == 2) //Block booking view
                {
                    blockBooking = _bbc.Find(Convert.ToInt32(lstV_Bookings.SelectedItems[0].Text));
                    _daysBooked = blockBooking.start_date.DayOfYear - blockBooking.end_date.DayOfYear;
                    agent = _ac.Find(blockBooking.agent_ID);
                    gb_agent.Visible = true;
                    try
                    {
                        PopulateBoxes(blockBooking, agent);
                    }
                    catch { }

                    gb_edit_Block.Visible = true;
                    gb_edit_booking.Visible = false;
                    btn_assign.Visible = true;
                    btn_cancel_block.Visible = true;
                    btn_confirm_assignment.Visible = false;

                }

                gb_guest_details.Visible = true;
                gb_booking_details.Visible = true;


                SetEdit(false);

            }
        }
        private void lstv_canceled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstv_canceled.SelectedItems.Count > 0)
            {
                cb = _cbc.Find(Convert.ToInt32(lstv_canceled.SelectedItems[0].Text));
                btn_Undo.Visible = true;
                gb_edit_Block.Visible = false;
                gb_edit_Block.Visible = false;
            }
            else
            {
                btn_Undo.Visible = false;
            }
        }
        private void tb_g_guest_id_Leave(object sender, EventArgs e)
        {
            if (tb_g_guest_id.Text != "")
            {
                Guest temp = _gc.getGuest(tb_g_guest_id.Text);
                if (temp.fName != null)
                {
                    tb_g_f_name.Text = temp.fName;
                    tb_g_s_name.Text = temp.sName;
                    tb_g_phone.Text = temp.phone;
                    tb_g_email.Text = DecryptData(temp.email, _KEY, _vector);
                    tb_g_address.Text = DecryptData(temp.address, _KEY, _vector);
                    tb_g_cc_num.Text = DecryptData(temp.ccNumber, _KEY, _vector);
                    _returning_guest = true;
                }
                else
                {
                    string ID = tb_g_guest_id.Text;
                    ClearGuestBox();
                    tb_g_guest_id.Text = ID;
                    _returning_guest = false;
                }
            }
            else
            {
                ClearGuestBox();
            }
        }
        private void CurrentBookings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel) return;
            if (_changes_made)
            {
                DialogResult dr = MessageBox.Show("There are unsaved changes! Do you want to save?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    SaveToDataBase();
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    //return ;
                }
                else
                {
                    _changes_made = false;
                }
            }
        }
        private void CurrentBookings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MdiParent.Enabled = true;
            _currentBookingsClosed = true;
        }
        private void CurrentBookings_Activated(object sender, EventArgs e)
        {

        }
        private void rb_Current_Bookings_CheckedChanged(object sender, EventArgs e)
        {
            int state = GetViewState();
            setUpView(state);
            if (rb_Block_Bookings.Checked)
            {

            }
            else
            {
                gb_edit_Block.Visible = false;
                gb_edit_booking.Visible = true;
            }
            gb_edit_Block.Visible = false;
            gb_edit_booking.Visible = false;
        }
        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        #endregion

        #region Input Validatation
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
            long l;
            bool result = true;
            if (!long.TryParse(tb_g_guest_id.Text, out l))
            {
                MessageBox.Show("Guest's ID is in an invalid format!");
                tb_g_guest_id.Focus();
                result = false;
            }
            

            else if (ValidValue(tb_g_f_name.Text,3))
            {
                MessageBox.Show("Guest's First name is in an invalid format!");
                tb_g_f_name.Focus();
                result = false;
            }

            else if (ValidValue(tb_g_s_name.Text,3))
            {
                MessageBox.Show("Guest's Surname is in an invalid format!");
                tb_g_s_name.Focus();
                result = false;
            }

            else if (!ValidValue(tb_g_email.Text, 0))
            {
                MessageBox.Show("Guest's email is in an invalid format!");
                tb_g_email.Focus();
                result = false;
            }

            else if (!ValidValue(tb_g_phone.Text, 1))
            {
                MessageBox.Show("Guest's Phone number is in an invalid format!");
                tb_g_phone.Focus();
                result = false;
            }

            
            else if (!ValidValue(tb_g_cc_num.Text, 2))
            {
                MessageBox.Show("Guest's Credit card number is in an invalid format!");
                tb_g_cc_num.Focus();
                result = false;
            }
            else if (tb_g_address.Text == "")
            {
                MessageBox.Show("Guest's address is in an invalid format!");
                tb_g_address.Focus();
                result = false;
            }
            return result;
        }
        private void ntb_NumRooms_ValueChanged(object sender, EventArgs e)
        {
            ntb_NumRooms.Value = (int)Math.Round((ntb_NumRooms.Value));
            if (ntb_NumRooms.Value < 1)
            {
                ntb_NumRooms.Value = 1;
            }
        }
        private void dtp_check_in_ValueChanged(object sender, EventArgs e)
        {
            dtp_check_in.MinDate = DateTime.Now.Date;
            dtp_check_out.MinDate = dtp_check_in.Value.AddDays(1);
            if (GetViewState() == 1)
            {
                decimal price = _bc.CalculatePrice(dtp_check_in.Value.Date, dtp_check_out.Value.Date, (int)ntb_NumRooms.Value);
                tb_price.Text = Convert.ToString(price);
                tb_deposit_amount.Text = Convert.ToString(price * (decimal)0.1);
            }
            else if (GetViewState() == 2)
            {
                //decimal price = _bbc.CalculatePrice(dtp_check_in.Value.Date, dtp_check_out.Value.Date, (int)ntb_NumRooms.Value);
                //tb_price.Text = Convert.ToString(price);
            }

        }
        private void dtp_check_out_ValueChanged(object sender, EventArgs e)
        {
            if (GetViewState() == 1)
            {
                decimal price = _bc.CalculatePrice(dtp_check_in.Value.Date, dtp_check_out.Value.Date, (int)ntb_NumRooms.Value);
                tb_price.Text = Convert.ToString(price);
                tb_deposit_amount.Text = Convert.ToString(price * (decimal)0.1);
            }
        }
        private void nTb_people_ValueChanged(object sender, EventArgs e)
        {
            nTb_people.Value = (int)Math.Round(nTb_people.Value);
            if (nTb_people.Value < 1)
            {
                nTb_people.Value = 1;
            }

        }
        #endregion

        #region SetupView
        private void setUpView(int state)
        {

            ListViewItem bookingDetail;
            _returning_guest = false;
            lstV_Bookings.Clear();
            lstV_Bookings.View = View.Details;

            lstV_Bookings.Columns.Insert(0, "Booking ID", 63, HorizontalAlignment.Center);
            if (state == 1)
            {
                lstV_Bookings.Columns.Insert(1, "Guest ID", 100, HorizontalAlignment.Center);
            }
            if (state == 2)
            {
                lstV_Bookings.Columns.Insert(1, "Agent ID", 60, HorizontalAlignment.Center);
            }
            lstV_Bookings.Columns.Insert(2, "Rooms", 45, HorizontalAlignment.Center);
            lstV_Bookings.Columns.Insert(3, "Check In", 75, HorizontalAlignment.Center);
            lstV_Bookings.Columns.Insert(4, "Check Out", 75, HorizontalAlignment.Center);
            lstV_Bookings.Columns.Insert(5, "Status", 70, HorizontalAlignment.Center);

            if (state == 1)
            {

                foreach (Booking b in _bc.bookings)
                {
                    bookingDetail = new ListViewItem();
                    bookingDetail.Text = b.bookingNumber.ToString();
                    bookingDetail.SubItems.Add(b.customer_ID.ToString());
                    bookingDetail.SubItems.Add(b.numRooms.ToString());
                    bookingDetail.SubItems.Add(FormatDate(b.check_In));
                    bookingDetail.SubItems.Add(FormatDate(b.check_out));
                    if (b.confirmed == 0 )
                    {
                        bookingDetail.SubItems.Add("Unconfirmed");
                    }
                    else
                    {
                        bookingDetail.SubItems.Add("Confirmed");
                    }
                    if (b.edit_state == 1)
                    {
                        bookingDetail.BackColor = Color.Yellow;
                    }
                    else if (b.edit_state == 2)
                    {
                        bookingDetail.BackColor = Color.Green;
                    }
                    else if (b.edit_state == 3)
                    {
                        bookingDetail.BackColor = Color.Red;
                    }
                    lstV_Bookings.Items.Add(bookingDetail);
                }
            }

            else if (state == 2)
            {

                foreach (BlockBooking b in _bbc.bBookings)
                {
                    bookingDetail = new ListViewItem();
                    bookingDetail.Text = b.block_booking_id.ToString();
                    bookingDetail.SubItems.Add(b.agent_ID.ToString());
                    bookingDetail.SubItems.Add(b.num_rooms.ToString());
                    bookingDetail.SubItems.Add(FormatDate(b.start_date));
                    bookingDetail.SubItems.Add(FormatDate(b.end_date));

                    lstV_Bookings.Items.Add(bookingDetail);
                }
            }
            lstV_Bookings.GridLines = true;
            lstV_Bookings.Refresh();
            gb_booking_details.Visible = false;
            gb_guest_details.Visible = false;
            gb_agent.Visible = false;

            lstv_canceled.Clear();
            lstv_canceled.View = View.Details;
            lstv_canceled.Columns.Insert(0, "Booking ID", 70, HorizontalAlignment.Center);

            lstv_canceled.Columns.Insert(1, "Guest ID", 60, HorizontalAlignment.Center);
            lstv_canceled.Columns.Insert(2, "Agent ID", 60, HorizontalAlignment.Center);

            foreach (CanceledBooking c in _canceledBookings)
            {
                bookingDetail = new ListViewItem();
                bookingDetail.Text = c.id.ToString();
                bookingDetail.SubItems.Add(c.guest_ID);
                bookingDetail.SubItems.Add(c.agent_ID);
                //bookingDetail.SubItems.Add(c.)
                lstv_canceled.Items.Add(bookingDetail);
            }
            lstv_canceled.GridLines = true;
            lstV_Bookings.Refresh();

        }
        #endregion

        #region Buttons
        private void btn_assign_Click(object sender, EventArgs e)
        {
            SetEdit(true);
            tb_g_guest_id.Enabled = true;
            btn_assign.Visible = false;
            btn_confirm_assignment.Visible = true;
            btn_cancel_block.Visible = false;
            dtp_check_in.MinDate = blockBooking.start_date;
            dtp_check_in.MaxDate = blockBooking.end_date.AddDays(-1);
            dtp_check_out.MinDate = blockBooking.start_date.AddDays(1);
            dtp_check_out.MaxDate = blockBooking.end_date;


        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            SetEdit(true);
            btn_confirm_edit.Visible = true;
            btn_edit.Visible = false;
            btn_delete.Visible = false;
            dtp_check_in.MaxDate = Convert.ToDateTime("9998/12/30");
            dtp_check_in.MinDate = DateTime.Now.Date;
            dtp_check_out.MinDate = dtp_check_in.Value.Date.AddDays(1);//DateTime.Now.Date.AddDays(1);
            dtp_check_out.MaxDate = Convert.ToDateTime("9998/12/31");
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int rowState = _bc.GetRowState(booking);
            if (rowState != 1)
            {
                _changes_made = true;
                cb = new CanceledBooking();
                cb.id = booking.bookingNumber;
                cb.date = DateTime.Now;
                if (cb.date.Date > booking.check_In.Date.AddDays(-14))
                {
                    cb.amount = booking.deposit;
                }
                else
                {
                    cb.amount = 0;
                }

                cb.agent_ID = booking.agent_ID;
                cb.guest_ID = booking.customer_ID;

                _cbc.UpdateDataSet(cb, 2);
                _canceledBookings.Add(cb);
            }

            _bc.UpdateDataSet(booking, 3);

            setUpView(GetViewState());
        }
        private void btn_confirm_edit_Click(object sender, EventArgs e)
        {
            int guestEdited;
            bool bookingEdited = false;

            if (dtp_check_in.Value > dtp_check_out.Value)
            {
                MessageBox.Show("Check out date must be greater than check in date");
            }
            else
            {
                _changes_made = true;
                //blockBooking = _bbc.Find(booking.block_booking_ID);

                bool space = CheckAvailability(dtp_check_in.Value, dtp_check_out.Value, 1);

                if (!space) { MessageBox.Show("There is not enough space in hotel to accomodate changes"); }
                else
                {
                    decimal newPrice = _bc.CalculatePrice(dtp_check_in.Value, dtp_check_out.Value, (int)ntb_NumRooms.Value);
                    decimal newDeposit = newPrice * (decimal)0.1;
                    tb_price.Text = Convert.ToString(newPrice);
                    tb_deposit_amount.Text = Convert.ToString(newDeposit);
                    DateTime deposit_due_date = dtp_check_in.Value.AddDays(-14);
                    if (deposit_due_date.Date < DateTime.Now.Date)
                    {
                        deposit_due_date = DateTime.Now.Date;
                    }
                    else
                    {
                        dtp_dep_date.Value = deposit_due_date.Date;
                    }

                    booking.depDue = deposit_due_date;
                    booking.price = newPrice;
                    booking.deposit = newDeposit;
                    booking.numRooms = (int)ntb_NumRooms.Value;
                    booking.check_In = dtp_check_in.Value;
                    booking.check_out = dtp_check_out.Value;
                    booking.modeified_by = booking.modeified_by  + _empID + ","; 
                    booking.people = (int)nTb_people.Value;

                    if (AllValuesValid())
                    {
                        guest.ID = tb_g_guest_id.Text;
                        guest.fName = tb_g_f_name.Text;
                        guest.sName = tb_g_s_name.Text;
                        guest.phone = tb_g_phone.Text;
                        guest.email = EncryptData(tb_g_email.Text, _KEY, _vector);
                        guest.address = EncryptData(tb_g_address.Text, _KEY, _vector);
                        guest.ccNumber = EncryptData(tb_g_cc_num.Text, _KEY, _vector);



                        if (booking.booking_type != 1)  //Not a block booking so guest's details are in database already
                        {
                            guestEdited = _gc.ModifyGuest(guest, 1);
                            booking.agent_ID = agent.agentID;
                        }
                        else
                        {
                            if (_returning_guest)   //The guest's details are already in the database
                            {
                                guestEdited = _gc.ModifyGuest(guest, 1);
                            }
                            else  //A new guest needs to be added to the database
                            {
                                guest.ID = tb_g_guest_id.Text;

                                guestEdited = _gc.ModifyGuest(guest, 2);  //_gc.AddGuest(guest);
                            }
                            booking.customer_ID = tb_g_guest_id.Text;
                            booking.booking_type = 2;  //The block booking is now a booking through a travel agent

                        }

                        bookingEdited = _bc.UpdateDataSet(booking, 1);  //_bc.EditBookingDetails(booking);

                        setUpView(GetViewState());
                        btn_confirm_edit.Visible = false;
                        btn_edit.Visible = true;
                        btn_delete.Visible = true;
                        gb_edit_booking.Visible = false;
                    }
                }

            }
        }
        private void btn_confirm_assignment_Click(object sender, EventArgs e)
        {
            int guestEdited;
            bool bookingEdited = false;

            bool space = CheckAvailability(dtp_check_in.Value, dtp_check_out.Value, 2);
            if (!space) { MessageBox.Show("The block booking does not have sufficient rooms."); }
            else
            {
                _changes_made = true;
                decimal newPrice = _bc.CalculatePrice(dtp_check_in.Value, dtp_check_out.Value, (int)ntb_NumRooms.Value);
                decimal newDeposit = newPrice * (decimal)0.1;
                tb_price.Text = Convert.ToString(newPrice);
                tb_deposit_amount.Text = Convert.ToString(newDeposit);
                DateTime deposit_due_date = dtp_check_in.Value.AddDays(-14);
                if (deposit_due_date.Date < DateTime.Now.Date)
                {
                    deposit_due_date = DateTime.Now.Date;
                }
                else
                {
                    dtp_dep_date.Value = deposit_due_date.Date;
                }

                int newBN = GetNewKey();

                Booking newBooking = new Booking();
                newBooking.people = (int)nTb_people.Value;
                newBooking.bookingNumber = newBN;
                newBooking.depDue = deposit_due_date;
                newBooking.price = newPrice;
                newBooking.deposit = newDeposit;
                newBooking.numRooms = (int)ntb_NumRooms.Value;
                newBooking.check_In = dtp_check_in.Value;
                newBooking.check_out = dtp_check_out.Value;
                newBooking.block_booking_ID = blockBooking.block_booking_id;
                newBooking.agent_ID = agent.agentID;
                newBooking.confirmed = 1;
                newBooking.added_by = _empID;
                newBooking.modeified_by = "";
                if (AllValuesValid())
                {
                    guest.ID = tb_g_guest_id.Text;
                    guest.fName = tb_g_f_name.Text;
                    guest.sName = tb_g_s_name.Text;
                    guest.phone = tb_g_phone.Text;
                    guest.email = EncryptData(tb_g_email.Text,_KEY,_vector);
                    guest.address = EncryptData(tb_g_address.Text, _KEY, _vector);
                    guest.ccNumber = EncryptData(tb_g_cc_num.Text, _KEY, _vector);

                    if (_returning_guest)   //The guest's details are already in the database
                    {
                        guestEdited = _gc.ModifyGuest(guest, 1);
                    }
                    else  //A new guest needs to be added to the database
                    {
                        guest.ID = tb_g_guest_id.Text;

                        guestEdited = _gc.ModifyGuest(guest, 2);  //_gc.AddGuest(guest);
                    }
                    newBooking.customer_ID = tb_g_guest_id.Text;
                    newBooking.booking_type = 2;

                    bookingEdited = _bc.UpdateDataSet(newBooking, 2);

                    ClearGuestBox();
                    ResetDates();
                    btn_confirm_assignment.Visible = false;
                    btn_cancel_block.Visible = true;
                    btn_assign.Visible = true;
                    gb_edit_Block.Visible = false;
                    setUpView(GetViewState());
                    
                }
            }
        }
        private void btn_cancel_block_Click(object sender, EventArgs e)
        {
            _changes_made = true;
            cb = new CanceledBooking();
            cb.id = blockBooking.block_booking_id;
            cb.date = DateTime.Now;
            cb.agent_ID = blockBooking.agent_ID;
            
            if (cb.date.Date > blockBooking.start_date.Date.AddDays(-14))
            {
                cb.amount = blockBooking.deposit_amount;
            }
            else
            {
                cb.amount = 0;
            }
            
            foreach (Booking b in _bc.bookings)
            {
                if (b.block_booking_ID ==  blockBooking.block_booking_id)
                {
                    b.block_booking_ID = -1;
                    _bc.UpdateDataSet(b, 1);
                }
            }
            

            _cbc.UpdateDataSet(cb, 2);
            
            _bbc.UpdateDataSet(blockBooking, 3);
            _canceledBookings.Add(cb);
            setUpView(GetViewState());
        }
        private void btn_Undo_Click(object sender, EventArgs e)
        {
            if (cb.guest_ID == "")
            {
                _bbc.UndoDelete(cb.id);
            }
            else
            {
                _bc.UndoDeleted(cb.id);
            }
            _cbc.UpdateDataSet(cb, 3);
            int index = 0;
            foreach (CanceledBooking c in _canceledBookings)
            {
                if (c.id == cb.id) 
                {
                    break;
                }
                index++;
            }
            _canceledBookings.RemoveAt(index);
            setUpView(GetViewState());
            btn_Undo.Visible = false;
        }
        private void btn_Update_database_Click(object sender, EventArgs e)
        {
            SaveToDataBase();
        }
        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        
    }


}
