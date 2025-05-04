namespace HotelManagementSystem.Presentation
{
    partial class NewBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBookings));
            this.gb_Dates = new System.Windows.Forms.GroupBox();
            this.btn_changeDates = new System.Windows.Forms.Button();
            this.lbl_NumRooms = new System.Windows.Forms.Label();
            this.nTB_numRooms = new System.Windows.Forms.NumericUpDown();
            this.btn_Check_Dates = new System.Windows.Forms.Button();
            this.DTP_CheckOut = new System.Windows.Forms.DateTimePicker();
            this.DTP_CheckIn = new System.Windows.Forms.DateTimePicker();
            this.lbl_CheckOutDate = new System.Windows.Forms.Label();
            this.lbl_checkInDate = new System.Windows.Forms.Label();
            this.gb_Guest_Details = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nTb_People = new System.Windows.Forms.NumericUpDown();
            this.lbl_new_rooms = new System.Windows.Forms.Label();
            this.ntb_edit_rooms = new System.Windows.Forms.NumericUpDown();
            this.lbl_co_edit = new System.Windows.Forms.Label();
            this.lbl_ci_edit = new System.Windows.Forms.Label();
            this.dtp_co_edit = new System.Windows.Forms.DateTimePicker();
            this.dtp_ci_edit = new System.Windows.Forms.DateTimePicker();
            this.tb_Address = new System.Windows.Forms.RichTextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gb_price_details = new System.Windows.Forms.GroupBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.lbl_PriceTotal = new System.Windows.Forms.Label();
            this.tb_Deposit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DepAmount = new System.Windows.Forms.Label();
            this.tb_depDue = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tb_CCNum = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_SName = new System.Windows.Forms.TextBox();
            this.tb_FName = new System.Windows.Forms.TextBox();
            this.tb_GID = new System.Windows.Forms.TextBox();
            this.tb_BN = new System.Windows.Forms.TextBox();
            this.lbl_CCNum = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_SName = new System.Windows.Forms.Label();
            this.lbl_FName = new System.Windows.Forms.Label();
            this.lbl_GID = new System.Windows.Forms.Label();
            this.lbl_BkngNum = new System.Windows.Forms.Label();
            this.btn_add_booking = new System.Windows.Forms.Button();
            this.btn_confirm_edit = new System.Windows.Forms.Button();
            this.gb_CType = new System.Windows.Forms.GroupBox();
            this.gb_agent = new System.Windows.Forms.GroupBox();
            this.rb_blkBook = new System.Windows.Forms.RadioButton();
            this.rb_snglBooking = new System.Windows.Forms.RadioButton();
            this.lbl_selectAgent = new System.Windows.Forms.Label();
            this.cb_Agents = new System.Windows.Forms.ComboBox();
            this.rb_Person = new System.Windows.Forms.RadioButton();
            this.rb_Agent = new System.Windows.Forms.RadioButton();
            this.gb_NewBookings = new System.Windows.Forms.GroupBox();
            this.btn_delete_new_booking = new System.Windows.Forms.Button();
            this.btn_Edit_Booking = new System.Windows.Forms.Button();
            this.lstV_New_Bookings = new System.Windows.Forms.ListView();
            this.gb_new_BlockBooki = new System.Windows.Forms.GroupBox();
            this.btn_Block_delete = new System.Windows.Forms.Button();
            this.btn_Edit_Block = new System.Windows.Forms.Button();
            this.lstv_New_Block = new System.Windows.Forms.ListView();
            this.btn_update_data_base = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.gb_conflict = new System.Windows.Forms.GroupBox();
            this.lsv_conflicts = new System.Windows.Forms.ListView();
            this.pb_Email_Progress = new System.Windows.Forms.ProgressBar();
            this.lbl_sending_emails = new System.Windows.Forms.Label();
            this.gb_Dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTB_numRooms)).BeginInit();
            this.gb_Guest_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTb_People)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_edit_rooms)).BeginInit();
            this.gb_price_details.SuspendLayout();
            this.gb_CType.SuspendLayout();
            this.gb_agent.SuspendLayout();
            this.gb_NewBookings.SuspendLayout();
            this.gb_new_BlockBooki.SuspendLayout();
            this.gb_conflict.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Dates
            // 
            this.gb_Dates.Controls.Add(this.btn_changeDates);
            this.gb_Dates.Controls.Add(this.lbl_NumRooms);
            this.gb_Dates.Controls.Add(this.nTB_numRooms);
            this.gb_Dates.Controls.Add(this.btn_Check_Dates);
            this.gb_Dates.Controls.Add(this.DTP_CheckOut);
            this.gb_Dates.Controls.Add(this.DTP_CheckIn);
            this.gb_Dates.Controls.Add(this.lbl_CheckOutDate);
            this.gb_Dates.Controls.Add(this.lbl_checkInDate);
            this.gb_Dates.Location = new System.Drawing.Point(12, 12);
            this.gb_Dates.Name = "gb_Dates";
            this.gb_Dates.Size = new System.Drawing.Size(648, 101);
            this.gb_Dates.TabIndex = 0;
            this.gb_Dates.TabStop = false;
            this.gb_Dates.Text = "Booking Dates";
            // 
            // btn_changeDates
            // 
            this.btn_changeDates.Location = new System.Drawing.Point(454, 62);
            this.btn_changeDates.Name = "btn_changeDates";
            this.btn_changeDates.Size = new System.Drawing.Size(175, 31);
            this.btn_changeDates.TabIndex = 7;
            this.btn_changeDates.Text = "Change Dates/Rooms";
            this.btn_changeDates.UseVisualStyleBackColor = true;
            this.btn_changeDates.Visible = false;
            this.btn_changeDates.Click += new System.EventHandler(this.btn_changeDates_Click);
            // 
            // lbl_NumRooms
            // 
            this.lbl_NumRooms.AutoSize = true;
            this.lbl_NumRooms.Location = new System.Drawing.Point(9, 74);
            this.lbl_NumRooms.Name = "lbl_NumRooms";
            this.lbl_NumRooms.Size = new System.Drawing.Size(113, 16);
            this.lbl_NumRooms.TabIndex = 6;
            this.lbl_NumRooms.Text = "Number of rooms:";
            // 
            // nTB_numRooms
            // 
            this.nTB_numRooms.Location = new System.Drawing.Point(128, 72);
            this.nTB_numRooms.Name = "nTB_numRooms";
            this.nTB_numRooms.Size = new System.Drawing.Size(120, 22);
            this.nTB_numRooms.TabIndex = 5;
            this.nTB_numRooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTB_numRooms.ValueChanged += new System.EventHandler(this.nTB_numRooms_ValueChanged);
            // 
            // btn_Check_Dates
            // 
            this.btn_Check_Dates.Location = new System.Drawing.Point(273, 63);
            this.btn_Check_Dates.Name = "btn_Check_Dates";
            this.btn_Check_Dates.Size = new System.Drawing.Size(175, 32);
            this.btn_Check_Dates.TabIndex = 4;
            this.btn_Check_Dates.Text = "Submit";
            this.btn_Check_Dates.UseVisualStyleBackColor = true;
            this.btn_Check_Dates.Click += new System.EventHandler(this.btn_Check_Dates_Click);
            // 
            // DTP_CheckOut
            // 
            this.DTP_CheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_CheckOut.Location = new System.Drawing.Point(368, 34);
            this.DTP_CheckOut.Name = "DTP_CheckOut";
            this.DTP_CheckOut.Size = new System.Drawing.Size(134, 22);
            this.DTP_CheckOut.TabIndex = 3;
            this.DTP_CheckOut.ValueChanged += new System.EventHandler(this.DTP_CheckOut_ValueChanged);
            // 
            // DTP_CheckIn
            // 
            this.DTP_CheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_CheckIn.Location = new System.Drawing.Point(103, 34);
            this.DTP_CheckIn.Name = "DTP_CheckIn";
            this.DTP_CheckIn.Size = new System.Drawing.Size(134, 22);
            this.DTP_CheckIn.TabIndex = 2;
            this.DTP_CheckIn.ValueChanged += new System.EventHandler(this.DTP_CheckIn_ValueChanged);
            // 
            // lbl_CheckOutDate
            // 
            this.lbl_CheckOutDate.AutoSize = true;
            this.lbl_CheckOutDate.Location = new System.Drawing.Point(263, 34);
            this.lbl_CheckOutDate.Name = "lbl_CheckOutDate";
            this.lbl_CheckOutDate.Size = new System.Drawing.Size(99, 16);
            this.lbl_CheckOutDate.TabIndex = 1;
            this.lbl_CheckOutDate.Text = "Check out date:";
            // 
            // lbl_checkInDate
            // 
            this.lbl_checkInDate.AutoSize = true;
            this.lbl_checkInDate.Location = new System.Drawing.Point(6, 34);
            this.lbl_checkInDate.Name = "lbl_checkInDate";
            this.lbl_checkInDate.Size = new System.Drawing.Size(91, 16);
            this.lbl_checkInDate.TabIndex = 0;
            this.lbl_checkInDate.Text = "Check in date:";
            // 
            // gb_Guest_Details
            // 
            this.gb_Guest_Details.Controls.Add(this.label2);
            this.gb_Guest_Details.Controls.Add(this.nTb_People);
            this.gb_Guest_Details.Controls.Add(this.lbl_new_rooms);
            this.gb_Guest_Details.Controls.Add(this.ntb_edit_rooms);
            this.gb_Guest_Details.Controls.Add(this.lbl_co_edit);
            this.gb_Guest_Details.Controls.Add(this.lbl_ci_edit);
            this.gb_Guest_Details.Controls.Add(this.dtp_co_edit);
            this.gb_Guest_Details.Controls.Add(this.dtp_ci_edit);
            this.gb_Guest_Details.Controls.Add(this.tb_Address);
            this.gb_Guest_Details.Controls.Add(this.btn_cancel);
            this.gb_Guest_Details.Controls.Add(this.gb_price_details);
            this.gb_Guest_Details.Controls.Add(this.lbl_Address);
            this.gb_Guest_Details.Controls.Add(this.tb_CCNum);
            this.gb_Guest_Details.Controls.Add(this.tb_Email);
            this.gb_Guest_Details.Controls.Add(this.tb_phone);
            this.gb_Guest_Details.Controls.Add(this.tb_SName);
            this.gb_Guest_Details.Controls.Add(this.tb_FName);
            this.gb_Guest_Details.Controls.Add(this.tb_GID);
            this.gb_Guest_Details.Controls.Add(this.tb_BN);
            this.gb_Guest_Details.Controls.Add(this.lbl_CCNum);
            this.gb_Guest_Details.Controls.Add(this.lbl_Email);
            this.gb_Guest_Details.Controls.Add(this.lbl_Phone);
            this.gb_Guest_Details.Controls.Add(this.lbl_SName);
            this.gb_Guest_Details.Controls.Add(this.lbl_FName);
            this.gb_Guest_Details.Controls.Add(this.lbl_GID);
            this.gb_Guest_Details.Controls.Add(this.lbl_BkngNum);
            this.gb_Guest_Details.Controls.Add(this.btn_add_booking);
            this.gb_Guest_Details.Controls.Add(this.btn_confirm_edit);
            this.gb_Guest_Details.Location = new System.Drawing.Point(12, 253);
            this.gb_Guest_Details.Name = "gb_Guest_Details";
            this.gb_Guest_Details.Size = new System.Drawing.Size(648, 334);
            this.gb_Guest_Details.TabIndex = 1;
            this.gb_Guest_Details.TabStop = false;
            this.gb_Guest_Details.Text = "Guest Details";
            this.gb_Guest_Details.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Number of people";
            // 
            // nTb_People
            // 
            this.nTb_People.Location = new System.Drawing.Point(147, 49);
            this.nTb_People.Name = "nTb_People";
            this.nTb_People.Size = new System.Drawing.Size(90, 22);
            this.nTb_People.TabIndex = 7;
            this.nTb_People.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTb_People.ValueChanged += new System.EventHandler(this.nTb_People_ValueChanged);
            // 
            // lbl_new_rooms
            // 
            this.lbl_new_rooms.AutoSize = true;
            this.lbl_new_rooms.Location = new System.Drawing.Point(380, 229);
            this.lbl_new_rooms.Name = "lbl_new_rooms";
            this.lbl_new_rooms.Size = new System.Drawing.Size(110, 16);
            this.lbl_new_rooms.TabIndex = 32;
            this.lbl_new_rooms.Text = "Number of rooms";
            this.lbl_new_rooms.Visible = false;
            // 
            // ntb_edit_rooms
            // 
            this.ntb_edit_rooms.Location = new System.Drawing.Point(496, 227);
            this.ntb_edit_rooms.Name = "ntb_edit_rooms";
            this.ntb_edit_rooms.Size = new System.Drawing.Size(109, 22);
            this.ntb_edit_rooms.TabIndex = 31;
            this.ntb_edit_rooms.Visible = false;
            this.ntb_edit_rooms.ValueChanged += new System.EventHandler(this.ntb_edit_rooms_ValueChanged);
            // 
            // lbl_co_edit
            // 
            this.lbl_co_edit.AutoSize = true;
            this.lbl_co_edit.Location = new System.Drawing.Point(424, 204);
            this.lbl_co_edit.Name = "lbl_co_edit";
            this.lbl_co_edit.Size = new System.Drawing.Size(66, 16);
            this.lbl_co_edit.TabIndex = 30;
            this.lbl_co_edit.Text = "Check out";
            this.lbl_co_edit.Visible = false;
            // 
            // lbl_ci_edit
            // 
            this.lbl_ci_edit.AutoSize = true;
            this.lbl_ci_edit.Location = new System.Drawing.Point(432, 175);
            this.lbl_ci_edit.Name = "lbl_ci_edit";
            this.lbl_ci_edit.Size = new System.Drawing.Size(58, 16);
            this.lbl_ci_edit.TabIndex = 29;
            this.lbl_ci_edit.Text = "Check in";
            this.lbl_ci_edit.Visible = false;
            // 
            // dtp_co_edit
            // 
            this.dtp_co_edit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_co_edit.Location = new System.Drawing.Point(496, 199);
            this.dtp_co_edit.Name = "dtp_co_edit";
            this.dtp_co_edit.Size = new System.Drawing.Size(108, 22);
            this.dtp_co_edit.TabIndex = 28;
            this.dtp_co_edit.Visible = false;
            // 
            // dtp_ci_edit
            // 
            this.dtp_ci_edit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ci_edit.Location = new System.Drawing.Point(496, 170);
            this.dtp_ci_edit.Name = "dtp_ci_edit";
            this.dtp_ci_edit.Size = new System.Drawing.Size(109, 22);
            this.dtp_ci_edit.TabIndex = 27;
            this.dtp_ci_edit.Visible = false;
            this.dtp_ci_edit.ValueChanged += new System.EventHandler(this.dtp_ci_edit_ValueChanged);
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(146, 245);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(180, 61);
            this.tb_Address.TabIndex = 14;
            this.tb_Address.Text = "";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(332, 297);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(175, 31);
            this.btn_cancel.TabIndex = 25;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // gb_price_details
            // 
            this.gb_price_details.Controls.Add(this.tb_price);
            this.gb_price_details.Controls.Add(this.lbl_PriceTotal);
            this.gb_price_details.Controls.Add(this.tb_Deposit);
            this.gb_price_details.Controls.Add(this.label1);
            this.gb_price_details.Controls.Add(this.lbl_DepAmount);
            this.gb_price_details.Controls.Add(this.tb_depDue);
            this.gb_price_details.Location = new System.Drawing.Point(368, 30);
            this.gb_price_details.Name = "gb_price_details";
            this.gb_price_details.Size = new System.Drawing.Size(237, 134);
            this.gb_price_details.TabIndex = 26;
            this.gb_price_details.TabStop = false;
            this.gb_price_details.Text = "Payment details";
            // 
            // tb_price
            // 
            this.tb_price.Enabled = false;
            this.tb_price.Location = new System.Drawing.Point(132, 24);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(100, 22);
            this.tb_price.TabIndex = 18;
            // 
            // lbl_PriceTotal
            // 
            this.lbl_PriceTotal.AutoSize = true;
            this.lbl_PriceTotal.Location = new System.Drawing.Point(54, 27);
            this.lbl_PriceTotal.Name = "lbl_PriceTotal";
            this.lbl_PriceTotal.Size = new System.Drawing.Size(72, 16);
            this.lbl_PriceTotal.TabIndex = 19;
            this.lbl_PriceTotal.Text = "Total Price";
            // 
            // tb_Deposit
            // 
            this.tb_Deposit.Enabled = false;
            this.tb_Deposit.Location = new System.Drawing.Point(132, 57);
            this.tb_Deposit.Name = "tb_Deposit";
            this.tb_Deposit.Size = new System.Drawing.Size(100, 22);
            this.tb_Deposit.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Deposit due before";
            // 
            // lbl_DepAmount
            // 
            this.lbl_DepAmount.AutoSize = true;
            this.lbl_DepAmount.Location = new System.Drawing.Point(24, 63);
            this.lbl_DepAmount.Name = "lbl_DepAmount";
            this.lbl_DepAmount.Size = new System.Drawing.Size(102, 16);
            this.lbl_DepAmount.TabIndex = 21;
            this.lbl_DepAmount.Text = "Deposit Amount";
            // 
            // tb_depDue
            // 
            this.tb_depDue.Enabled = false;
            this.tb_depDue.Location = new System.Drawing.Point(132, 97);
            this.tb_depDue.Name = "tb_depDue";
            this.tb_depDue.Size = new System.Drawing.Size(100, 22);
            this.tb_depDue.TabIndex = 22;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(82, 266);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(58, 16);
            this.lbl_Address.TabIndex = 17;
            this.lbl_Address.Text = "Address";
            // 
            // tb_CCNum
            // 
            this.tb_CCNum.Location = new System.Drawing.Point(147, 189);
            this.tb_CCNum.Name = "tb_CCNum";
            this.tb_CCNum.Size = new System.Drawing.Size(179, 22);
            this.tb_CCNum.TabIndex = 12;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(147, 217);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(179, 22);
            this.tb_Email.TabIndex = 13;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(147, 161);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(179, 22);
            this.tb_phone.TabIndex = 11;
            // 
            // tb_SName
            // 
            this.tb_SName.Location = new System.Drawing.Point(147, 133);
            this.tb_SName.Name = "tb_SName";
            this.tb_SName.Size = new System.Drawing.Size(180, 22);
            this.tb_SName.TabIndex = 10;
            // 
            // tb_FName
            // 
            this.tb_FName.Location = new System.Drawing.Point(147, 105);
            this.tb_FName.Name = "tb_FName";
            this.tb_FName.Size = new System.Drawing.Size(180, 22);
            this.tb_FName.TabIndex = 9;
            // 
            // tb_GID
            // 
            this.tb_GID.Location = new System.Drawing.Point(147, 77);
            this.tb_GID.Name = "tb_GID";
            this.tb_GID.Size = new System.Drawing.Size(180, 22);
            this.tb_GID.TabIndex = 8;
            this.tb_GID.Leave += new System.EventHandler(this.tb_GID_Leave);
            // 
            // tb_BN
            // 
            this.tb_BN.Enabled = false;
            this.tb_BN.Location = new System.Drawing.Point(147, 21);
            this.tb_BN.Name = "tb_BN";
            this.tb_BN.Size = new System.Drawing.Size(90, 22);
            this.tb_BN.TabIndex = 7;
            // 
            // lbl_CCNum
            // 
            this.lbl_CCNum.AutoSize = true;
            this.lbl_CCNum.Location = new System.Drawing.Point(17, 193);
            this.lbl_CCNum.Name = "lbl_CCNum";
            this.lbl_CCNum.Size = new System.Drawing.Size(125, 16);
            this.lbl_CCNum.TabIndex = 6;
            this.lbl_CCNum.Text = "Credit Card Number";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(101, 220);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(41, 16);
            this.lbl_Email.TabIndex = 5;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(45, 164);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(97, 16);
            this.lbl_Phone.TabIndex = 4;
            this.lbl_Phone.Text = "Phone Number";
            // 
            // lbl_SName
            // 
            this.lbl_SName.AutoSize = true;
            this.lbl_SName.Location = new System.Drawing.Point(80, 139);
            this.lbl_SName.Name = "lbl_SName";
            this.lbl_SName.Size = new System.Drawing.Size(61, 16);
            this.lbl_SName.TabIndex = 3;
            this.lbl_SName.Text = "Surname";
            // 
            // lbl_FName
            // 
            this.lbl_FName.AutoSize = true;
            this.lbl_FName.Location = new System.Drawing.Point(69, 111);
            this.lbl_FName.Name = "lbl_FName";
            this.lbl_FName.Size = new System.Drawing.Size(72, 16);
            this.lbl_FName.TabIndex = 2;
            this.lbl_FName.Text = "First Name";
            // 
            // lbl_GID
            // 
            this.lbl_GID.AutoSize = true;
            this.lbl_GID.Location = new System.Drawing.Point(83, 83);
            this.lbl_GID.Name = "lbl_GID";
            this.lbl_GID.Size = new System.Drawing.Size(58, 16);
            this.lbl_GID.TabIndex = 1;
            this.lbl_GID.Text = "Guest ID";
            // 
            // lbl_BkngNum
            // 
            this.lbl_BkngNum.AutoSize = true;
            this.lbl_BkngNum.Location = new System.Drawing.Point(33, 25);
            this.lbl_BkngNum.Name = "lbl_BkngNum";
            this.lbl_BkngNum.Size = new System.Drawing.Size(108, 16);
            this.lbl_BkngNum.TabIndex = 0;
            this.lbl_BkngNum.Text = "Booking Number";
            // 
            // btn_add_booking
            // 
            this.btn_add_booking.Location = new System.Drawing.Point(332, 258);
            this.btn_add_booking.Name = "btn_add_booking";
            this.btn_add_booking.Size = new System.Drawing.Size(175, 33);
            this.btn_add_booking.TabIndex = 15;
            this.btn_add_booking.Text = "Add booking";
            this.btn_add_booking.UseVisualStyleBackColor = true;
            this.btn_add_booking.Click += new System.EventHandler(this.btn_add_booking_Click);
            // 
            // btn_confirm_edit
            // 
            this.btn_confirm_edit.Location = new System.Drawing.Point(332, 258);
            this.btn_confirm_edit.Name = "btn_confirm_edit";
            this.btn_confirm_edit.Size = new System.Drawing.Size(174, 33);
            this.btn_confirm_edit.TabIndex = 3;
            this.btn_confirm_edit.Text = "Confirm Edits";
            this.btn_confirm_edit.UseVisualStyleBackColor = true;
            this.btn_confirm_edit.Visible = false;
            this.btn_confirm_edit.Click += new System.EventHandler(this.btn_confirm_edit_Click);
            // 
            // gb_CType
            // 
            this.gb_CType.Controls.Add(this.gb_agent);
            this.gb_CType.Controls.Add(this.rb_Person);
            this.gb_CType.Controls.Add(this.rb_Agent);
            this.gb_CType.Location = new System.Drawing.Point(12, 119);
            this.gb_CType.Name = "gb_CType";
            this.gb_CType.Size = new System.Drawing.Size(648, 128);
            this.gb_CType.TabIndex = 0;
            this.gb_CType.TabStop = false;
            this.gb_CType.Text = "Customer Type";
            this.gb_CType.Visible = false;
            // 
            // gb_agent
            // 
            this.gb_agent.Controls.Add(this.rb_blkBook);
            this.gb_agent.Controls.Add(this.rb_snglBooking);
            this.gb_agent.Controls.Add(this.lbl_selectAgent);
            this.gb_agent.Controls.Add(this.cb_Agents);
            this.gb_agent.Location = new System.Drawing.Point(158, 21);
            this.gb_agent.Name = "gb_agent";
            this.gb_agent.Size = new System.Drawing.Size(471, 88);
            this.gb_agent.TabIndex = 2;
            this.gb_agent.TabStop = false;
            this.gb_agent.Text = "Travel Agent Details";
            this.gb_agent.Visible = false;
            // 
            // rb_blkBook
            // 
            this.rb_blkBook.AutoSize = true;
            this.rb_blkBook.Location = new System.Drawing.Point(279, 51);
            this.rb_blkBook.Name = "rb_blkBook";
            this.rb_blkBook.Size = new System.Drawing.Size(115, 20);
            this.rb_blkBook.TabIndex = 5;
            this.rb_blkBook.Text = "Block Booking";
            this.rb_blkBook.UseVisualStyleBackColor = true;
            this.rb_blkBook.CheckedChanged += new System.EventHandler(this.rb_blkBook_CheckedChanged);
            // 
            // rb_snglBooking
            // 
            this.rb_snglBooking.AutoSize = true;
            this.rb_snglBooking.Checked = true;
            this.rb_snglBooking.Location = new System.Drawing.Point(279, 22);
            this.rb_snglBooking.Name = "rb_snglBooking";
            this.rb_snglBooking.Size = new System.Drawing.Size(118, 20);
            this.rb_snglBooking.TabIndex = 4;
            this.rb_snglBooking.TabStop = true;
            this.rb_snglBooking.Text = "Single booking";
            this.rb_snglBooking.UseVisualStyleBackColor = true;
            // 
            // lbl_selectAgent
            // 
            this.lbl_selectAgent.AutoSize = true;
            this.lbl_selectAgent.Location = new System.Drawing.Point(7, 22);
            this.lbl_selectAgent.Name = "lbl_selectAgent";
            this.lbl_selectAgent.Size = new System.Drawing.Size(129, 16);
            this.lbl_selectAgent.TabIndex = 3;
            this.lbl_selectAgent.Text = "Select a travel agent";
            // 
            // cb_Agents
            // 
            this.cb_Agents.FormattingEnabled = true;
            this.cb_Agents.Location = new System.Drawing.Point(6, 48);
            this.cb_Agents.Name = "cb_Agents";
            this.cb_Agents.Size = new System.Drawing.Size(229, 24);
            this.cb_Agents.TabIndex = 2;
            this.cb_Agents.SelectedIndexChanged += new System.EventHandler(this.cb_Agents_SelectedIndexChanged);
            // 
            // rb_Person
            // 
            this.rb_Person.AutoSize = true;
            this.rb_Person.Checked = true;
            this.rb_Person.Location = new System.Drawing.Point(6, 22);
            this.rb_Person.Name = "rb_Person";
            this.rb_Person.Size = new System.Drawing.Size(122, 20);
            this.rb_Person.TabIndex = 1;
            this.rb_Person.TabStop = true;
            this.rb_Person.Text = "Private booking";
            this.rb_Person.UseVisualStyleBackColor = true;
            // 
            // rb_Agent
            // 
            this.rb_Agent.AutoSize = true;
            this.rb_Agent.Location = new System.Drawing.Point(6, 48);
            this.rb_Agent.Name = "rb_Agent";
            this.rb_Agent.Size = new System.Drawing.Size(105, 20);
            this.rb_Agent.TabIndex = 0;
            this.rb_Agent.Text = "Travel Agent";
            this.rb_Agent.UseVisualStyleBackColor = true;
            this.rb_Agent.CheckedChanged += new System.EventHandler(this.rb_Agent_CheckedChanged);
            // 
            // gb_NewBookings
            // 
            this.gb_NewBookings.Controls.Add(this.btn_delete_new_booking);
            this.gb_NewBookings.Controls.Add(this.btn_Edit_Booking);
            this.gb_NewBookings.Controls.Add(this.lstV_New_Bookings);
            this.gb_NewBookings.Location = new System.Drawing.Point(676, 12);
            this.gb_NewBookings.Name = "gb_NewBookings";
            this.gb_NewBookings.Size = new System.Drawing.Size(521, 235);
            this.gb_NewBookings.TabIndex = 2;
            this.gb_NewBookings.TabStop = false;
            this.gb_NewBookings.Text = "New Bookings";
            this.gb_NewBookings.Leave += new System.EventHandler(this.gb_NewBookings_Leave);
            // 
            // btn_delete_new_booking
            // 
            this.btn_delete_new_booking.Location = new System.Drawing.Point(329, 199);
            this.btn_delete_new_booking.Name = "btn_delete_new_booking";
            this.btn_delete_new_booking.Size = new System.Drawing.Size(175, 30);
            this.btn_delete_new_booking.TabIndex = 2;
            this.btn_delete_new_booking.Text = "Delete booking";
            this.btn_delete_new_booking.UseVisualStyleBackColor = true;
            this.btn_delete_new_booking.Visible = false;
            this.btn_delete_new_booking.Click += new System.EventHandler(this.btn_delete_new_booking_Click);
            // 
            // btn_Edit_Booking
            // 
            this.btn_Edit_Booking.Location = new System.Drawing.Point(21, 199);
            this.btn_Edit_Booking.Name = "btn_Edit_Booking";
            this.btn_Edit_Booking.Size = new System.Drawing.Size(175, 31);
            this.btn_Edit_Booking.TabIndex = 1;
            this.btn_Edit_Booking.Text = "Edit Booking";
            this.btn_Edit_Booking.UseVisualStyleBackColor = true;
            this.btn_Edit_Booking.Visible = false;
            this.btn_Edit_Booking.Click += new System.EventHandler(this.btn_Edit_Booking_Click);
            // 
            // lstV_New_Bookings
            // 
            this.lstV_New_Bookings.HideSelection = false;
            this.lstV_New_Bookings.Location = new System.Drawing.Point(6, 21);
            this.lstV_New_Bookings.Name = "lstV_New_Bookings";
            this.lstV_New_Bookings.Size = new System.Drawing.Size(509, 172);
            this.lstV_New_Bookings.TabIndex = 0;
            this.lstV_New_Bookings.UseCompatibleStateImageBehavior = false;
            this.lstV_New_Bookings.SelectedIndexChanged += new System.EventHandler(this.lstV_New_Bookings_SelectedIndexChanged);
            // 
            // gb_new_BlockBooki
            // 
            this.gb_new_BlockBooki.Controls.Add(this.btn_Block_delete);
            this.gb_new_BlockBooki.Controls.Add(this.btn_Edit_Block);
            this.gb_new_BlockBooki.Controls.Add(this.lstv_New_Block);
            this.gb_new_BlockBooki.Location = new System.Drawing.Point(676, 253);
            this.gb_new_BlockBooki.Name = "gb_new_BlockBooki";
            this.gb_new_BlockBooki.Size = new System.Drawing.Size(521, 231);
            this.gb_new_BlockBooki.TabIndex = 3;
            this.gb_new_BlockBooki.TabStop = false;
            this.gb_new_BlockBooki.Text = "New Block Bookings";
            this.gb_new_BlockBooki.Leave += new System.EventHandler(this.gb_new_BlockBooki_Leave);
            // 
            // btn_Block_delete
            // 
            this.btn_Block_delete.Location = new System.Drawing.Point(329, 192);
            this.btn_Block_delete.Name = "btn_Block_delete";
            this.btn_Block_delete.Size = new System.Drawing.Size(175, 32);
            this.btn_Block_delete.TabIndex = 2;
            this.btn_Block_delete.Text = "Delete Block Booking";
            this.btn_Block_delete.UseVisualStyleBackColor = true;
            this.btn_Block_delete.Visible = false;
            this.btn_Block_delete.Click += new System.EventHandler(this.btn_Block_delete_Click);
            // 
            // btn_Edit_Block
            // 
            this.btn_Edit_Block.Location = new System.Drawing.Point(21, 192);
            this.btn_Edit_Block.Name = "btn_Edit_Block";
            this.btn_Edit_Block.Size = new System.Drawing.Size(175, 33);
            this.btn_Edit_Block.TabIndex = 1;
            this.btn_Edit_Block.Text = "Edit Block Booking";
            this.btn_Edit_Block.UseVisualStyleBackColor = true;
            this.btn_Edit_Block.Visible = false;
            this.btn_Edit_Block.Click += new System.EventHandler(this.btn_Edit_Block_Click);
            // 
            // lstv_New_Block
            // 
            this.lstv_New_Block.HideSelection = false;
            this.lstv_New_Block.Location = new System.Drawing.Point(7, 22);
            this.lstv_New_Block.Name = "lstv_New_Block";
            this.lstv_New_Block.Size = new System.Drawing.Size(508, 164);
            this.lstv_New_Block.TabIndex = 0;
            this.lstv_New_Block.UseCompatibleStateImageBehavior = false;
            this.lstv_New_Block.SelectedIndexChanged += new System.EventHandler(this.lstv_New_Block_SelectedIndexChanged);
            // 
            // btn_update_data_base
            // 
            this.btn_update_data_base.Location = new System.Drawing.Point(676, 555);
            this.btn_update_data_base.Name = "btn_update_data_base";
            this.btn_update_data_base.Size = new System.Drawing.Size(175, 32);
            this.btn_update_data_base.TabIndex = 3;
            this.btn_update_data_base.Text = "Update Database";
            this.btn_update_data_base.UseVisualStyleBackColor = true;
            this.btn_update_data_base.Click += new System.EventHandler(this.btn_update_data_base_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(1022, 555);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(175, 32);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // gb_conflict
            // 
            this.gb_conflict.Controls.Add(this.lsv_conflicts);
            this.gb_conflict.Location = new System.Drawing.Point(12, 119);
            this.gb_conflict.Name = "gb_conflict";
            this.gb_conflict.Size = new System.Drawing.Size(648, 468);
            this.gb_conflict.TabIndex = 5;
            this.gb_conflict.TabStop = false;
            this.gb_conflict.Text = "groupBox1";
            this.gb_conflict.Visible = false;
            // 
            // lsv_conflicts
            // 
            this.lsv_conflicts.HideSelection = false;
            this.lsv_conflicts.Location = new System.Drawing.Point(36, 22);
            this.lsv_conflicts.Name = "lsv_conflicts";
            this.lsv_conflicts.Size = new System.Drawing.Size(587, 403);
            this.lsv_conflicts.TabIndex = 0;
            this.lsv_conflicts.UseCompatibleStateImageBehavior = false;
            // 
            // pb_Email_Progress
            // 
            this.pb_Email_Progress.Location = new System.Drawing.Point(679, 526);
            this.pb_Email_Progress.Name = "pb_Email_Progress";
            this.pb_Email_Progress.Size = new System.Drawing.Size(521, 23);
            this.pb_Email_Progress.TabIndex = 6;
            this.pb_Email_Progress.Visible = false;
            // 
            // lbl_sending_emails
            // 
            this.lbl_sending_emails.AutoSize = true;
            this.lbl_sending_emails.BackColor = System.Drawing.Color.Chartreuse;
            this.lbl_sending_emails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sending_emails.ForeColor = System.Drawing.Color.Red;
            this.lbl_sending_emails.Location = new System.Drawing.Point(677, 487);
            this.lbl_sending_emails.Name = "lbl_sending_emails";
            this.lbl_sending_emails.Size = new System.Drawing.Size(398, 36);
            this.lbl_sending_emails.TabIndex = 7;
            this.lbl_sending_emails.Text = "Sending Confirmation Emails";
            this.lbl_sending_emails.Visible = false;
            // 
            // NewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 648);
            this.Controls.Add(this.lbl_sending_emails);
            this.Controls.Add(this.pb_Email_Progress);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_update_data_base);
            this.Controls.Add(this.gb_new_BlockBooki);
            this.Controls.Add(this.gb_NewBookings);
            this.Controls.Add(this.gb_Guest_Details);
            this.Controls.Add(this.gb_CType);
            this.Controls.Add(this.gb_Dates);
            this.Controls.Add(this.gb_conflict);
            this.DoubleBuffered = true;
            this.Name = "NewBookings";
            this.Text = "Create New Booking";
            this.Activated += new System.EventHandler(this.NewBookings_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewBookings_FormClosing);
            this.Load += new System.EventHandler(this.NewBookings_Load);
            this.gb_Dates.ResumeLayout(false);
            this.gb_Dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTB_numRooms)).EndInit();
            this.gb_Guest_Details.ResumeLayout(false);
            this.gb_Guest_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTb_People)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_edit_rooms)).EndInit();
            this.gb_price_details.ResumeLayout(false);
            this.gb_price_details.PerformLayout();
            this.gb_CType.ResumeLayout(false);
            this.gb_CType.PerformLayout();
            this.gb_agent.ResumeLayout(false);
            this.gb_agent.PerformLayout();
            this.gb_NewBookings.ResumeLayout(false);
            this.gb_new_BlockBooki.ResumeLayout(false);
            this.gb_conflict.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Dates;
        private System.Windows.Forms.DateTimePicker DTP_CheckIn;
        private System.Windows.Forms.Label lbl_CheckOutDate;
        private System.Windows.Forms.Label lbl_checkInDate;
        private System.Windows.Forms.DateTimePicker DTP_CheckOut;
        private System.Windows.Forms.Button btn_Check_Dates;
        private System.Windows.Forms.GroupBox gb_Guest_Details;
        private System.Windows.Forms.GroupBox gb_CType;
        private System.Windows.Forms.RadioButton rb_Person;
        private System.Windows.Forms.RadioButton rb_Agent;
        private System.Windows.Forms.NumericUpDown nTB_numRooms;
        private System.Windows.Forms.Label lbl_NumRooms;
        private System.Windows.Forms.Label lbl_GID;
        private System.Windows.Forms.Label lbl_BkngNum;
        private System.Windows.Forms.TextBox tb_FName;
        private System.Windows.Forms.TextBox tb_GID;
        private System.Windows.Forms.TextBox tb_BN;
        private System.Windows.Forms.Label lbl_CCNum;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_SName;
        private System.Windows.Forms.Label lbl_FName;
        private System.Windows.Forms.TextBox tb_CCNum;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_SName;
        private System.Windows.Forms.Button btn_changeDates;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.ComboBox cb_Agents;
        private System.Windows.Forms.GroupBox gb_agent;
        private System.Windows.Forms.Label lbl_selectAgent;
        private System.Windows.Forms.RadioButton rb_blkBook;
        private System.Windows.Forms.RadioButton rb_snglBooking;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label lbl_PriceTotal;
        private System.Windows.Forms.Label lbl_DepAmount;
        private System.Windows.Forms.TextBox tb_Deposit;
        private System.Windows.Forms.TextBox tb_depDue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_booking;
        private System.Windows.Forms.RichTextBox tb_Address;
        private System.Windows.Forms.GroupBox gb_price_details;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox gb_NewBookings;
        private System.Windows.Forms.ListView lstV_New_Bookings;
        private System.Windows.Forms.Button btn_Edit_Booking;
        private System.Windows.Forms.Button btn_delete_new_booking;
        private System.Windows.Forms.DateTimePicker dtp_ci_edit;
        private System.Windows.Forms.DateTimePicker dtp_co_edit;
        private System.Windows.Forms.Button btn_confirm_edit;
        private System.Windows.Forms.Label lbl_co_edit;
        private System.Windows.Forms.Label lbl_ci_edit;
        private System.Windows.Forms.NumericUpDown ntb_edit_rooms;
        private System.Windows.Forms.GroupBox gb_new_BlockBooki;
        private System.Windows.Forms.Label lbl_new_rooms;
        private System.Windows.Forms.Button btn_Block_delete;
        private System.Windows.Forms.Button btn_Edit_Block;
        private System.Windows.Forms.ListView lstv_New_Block;
        private System.Windows.Forms.Button btn_update_data_base;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.GroupBox gb_conflict;
        private System.Windows.Forms.ListView lsv_conflicts;
        private System.Windows.Forms.ProgressBar pb_Email_Progress;
        private System.Windows.Forms.Label lbl_sending_emails;
        private System.Windows.Forms.NumericUpDown nTb_People;
        private System.Windows.Forms.Label label2;
    }
}