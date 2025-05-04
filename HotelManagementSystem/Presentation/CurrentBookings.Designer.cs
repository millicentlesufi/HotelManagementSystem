namespace HotelManagementSystem.Presentation
{
    partial class CurrentBookings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentBookings));
            this.lstV_Bookings = new System.Windows.Forms.ListView();
            this.gb_booking_details = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nTb_people = new System.Windows.Forms.NumericUpDown();
            this.lbl_NumRooms = new System.Windows.Forms.Label();
            this.ntb_NumRooms = new System.Windows.Forms.NumericUpDown();
            this.dtp_dep_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_check_out = new System.Windows.Forms.DateTimePicker();
            this.dtp_check_in = new System.Windows.Forms.DateTimePicker();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_deposit_amount = new System.Windows.Forms.TextBox();
            this.tb_booking_number = new System.Windows.Forms.TextBox();
            this.lbl_check_out = new System.Windows.Forms.Label();
            this.lbl_check_in = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_deposit_date = new System.Windows.Forms.Label();
            this.lbl_deposit = new System.Windows.Forms.Label();
            this.lbl_booking_num = new System.Windows.Forms.Label();
            this.gb_guest_details = new System.Windows.Forms.GroupBox();
            this.tb_g_phone = new System.Windows.Forms.TextBox();
            this.lbl_g_Phone = new System.Windows.Forms.Label();
            this.tb_g_address = new System.Windows.Forms.RichTextBox();
            this.tb_g_cc_num = new System.Windows.Forms.TextBox();
            this.tb_g_email = new System.Windows.Forms.TextBox();
            this.tb_g_s_name = new System.Windows.Forms.TextBox();
            this.tb_g_f_name = new System.Windows.Forms.TextBox();
            this.tb_g_guest_id = new System.Windows.Forms.TextBox();
            this.lbl_cc_num = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_s_name = new System.Windows.Forms.Label();
            this.lbl_f_name = new System.Windows.Forms.Label();
            this.lbl_guest_id = new System.Windows.Forms.Label();
            this.gb_agent = new System.Windows.Forms.GroupBox();
            this.cb_agents = new System.Windows.Forms.ComboBox();
            this.lbl_a_ID = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_confirm_edit = new System.Windows.Forms.Button();
            this.gb_ItemView = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.rb_Block_Bookings = new System.Windows.Forms.RadioButton();
            this.rb_Current_Bookings = new System.Windows.Forms.RadioButton();
            this.btn_assign = new System.Windows.Forms.Button();
            this.btn_confirm_assignment = new System.Windows.Forms.Button();
            this.btn_cancel_block = new System.Windows.Forms.Button();
            this.hotel_DatabaseDataSet = new HotelManagementSystem.Hotel_DatabaseDataSet();
            this.hotelDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gb_edit_booking = new System.Windows.Forms.GroupBox();
            this.gb_edit_Block = new System.Windows.Forms.GroupBox();
            this.gb_canceled = new System.Windows.Forms.GroupBox();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.lstv_canceled = new System.Windows.Forms.ListView();
            this.bt_close = new System.Windows.Forms.Button();
            this.btn_Update_database = new System.Windows.Forms.Button();
            this.gb_booking_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTb_people)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_NumRooms)).BeginInit();
            this.gb_guest_details.SuspendLayout();
            this.gb_agent.SuspendLayout();
            this.gb_ItemView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatabaseDataSetBindingSource)).BeginInit();
            this.gb_edit_booking.SuspendLayout();
            this.gb_edit_Block.SuspendLayout();
            this.gb_canceled.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstV_Bookings
            // 
            this.lstV_Bookings.GridLines = true;
            this.lstV_Bookings.HideSelection = false;
            this.lstV_Bookings.Location = new System.Drawing.Point(6, 73);
            this.lstV_Bookings.Name = "lstV_Bookings";
            this.lstV_Bookings.Size = new System.Drawing.Size(569, 242);
            this.lstV_Bookings.TabIndex = 0;
            this.lstV_Bookings.UseCompatibleStateImageBehavior = false;
            this.lstV_Bookings.SelectedIndexChanged += new System.EventHandler(this.lstV_Bookings_SelectedIndexChanged);
            // 
            // gb_booking_details
            // 
            this.gb_booking_details.Controls.Add(this.label2);
            this.gb_booking_details.Controls.Add(this.nTb_people);
            this.gb_booking_details.Controls.Add(this.lbl_NumRooms);
            this.gb_booking_details.Controls.Add(this.ntb_NumRooms);
            this.gb_booking_details.Controls.Add(this.dtp_dep_date);
            this.gb_booking_details.Controls.Add(this.dtp_check_out);
            this.gb_booking_details.Controls.Add(this.dtp_check_in);
            this.gb_booking_details.Controls.Add(this.tb_price);
            this.gb_booking_details.Controls.Add(this.tb_deposit_amount);
            this.gb_booking_details.Controls.Add(this.tb_booking_number);
            this.gb_booking_details.Controls.Add(this.lbl_check_out);
            this.gb_booking_details.Controls.Add(this.lbl_check_in);
            this.gb_booking_details.Controls.Add(this.lbl_price);
            this.gb_booking_details.Controls.Add(this.lbl_deposit_date);
            this.gb_booking_details.Controls.Add(this.lbl_deposit);
            this.gb_booking_details.Controls.Add(this.lbl_booking_num);
            this.gb_booking_details.Location = new System.Drawing.Point(613, 12);
            this.gb_booking_details.Name = "gb_booking_details";
            this.gb_booking_details.Size = new System.Drawing.Size(285, 266);
            this.gb_booking_details.TabIndex = 2;
            this.gb_booking_details.TabStop = false;
            this.gb_booking_details.Text = "Booking Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Number of people";
            // 
            // nTb_people
            // 
            this.nTb_people.Location = new System.Drawing.Point(130, 45);
            this.nTb_people.Name = "nTb_people";
            this.nTb_people.Size = new System.Drawing.Size(120, 22);
            this.nTb_people.TabIndex = 17;
            this.nTb_people.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTb_people.ValueChanged += new System.EventHandler(this.nTb_people_ValueChanged);
            // 
            // lbl_NumRooms
            // 
            this.lbl_NumRooms.AutoSize = true;
            this.lbl_NumRooms.Location = new System.Drawing.Point(6, 225);
            this.lbl_NumRooms.Name = "lbl_NumRooms";
            this.lbl_NumRooms.Size = new System.Drawing.Size(110, 16);
            this.lbl_NumRooms.TabIndex = 16;
            this.lbl_NumRooms.Text = "Number of rooms";
            // 
            // ntb_NumRooms
            // 
            this.ntb_NumRooms.Location = new System.Drawing.Point(130, 223);
            this.ntb_NumRooms.Name = "ntb_NumRooms";
            this.ntb_NumRooms.Size = new System.Drawing.Size(120, 22);
            this.ntb_NumRooms.TabIndex = 15;
            this.ntb_NumRooms.ValueChanged += new System.EventHandler(this.ntb_NumRooms_ValueChanged);
            // 
            // dtp_dep_date
            // 
            this.dtp_dep_date.Enabled = false;
            this.dtp_dep_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dep_date.Location = new System.Drawing.Point(130, 111);
            this.dtp_dep_date.Name = "dtp_dep_date";
            this.dtp_dep_date.Size = new System.Drawing.Size(116, 22);
            this.dtp_dep_date.TabIndex = 14;
            // 
            // dtp_check_out
            // 
            this.dtp_check_out.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_check_out.Location = new System.Drawing.Point(130, 167);
            this.dtp_check_out.Name = "dtp_check_out";
            this.dtp_check_out.Size = new System.Drawing.Size(116, 22);
            this.dtp_check_out.TabIndex = 13;
            this.dtp_check_out.ValueChanged += new System.EventHandler(this.dtp_check_out_ValueChanged);
            // 
            // dtp_check_in
            // 
            this.dtp_check_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_check_in.Location = new System.Drawing.Point(130, 195);
            this.dtp_check_in.Name = "dtp_check_in";
            this.dtp_check_in.Size = new System.Drawing.Size(116, 22);
            this.dtp_check_in.TabIndex = 12;
            this.dtp_check_in.ValueChanged += new System.EventHandler(this.dtp_check_in_ValueChanged);
            // 
            // tb_price
            // 
            this.tb_price.Enabled = false;
            this.tb_price.Location = new System.Drawing.Point(130, 139);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(116, 22);
            this.tb_price.TabIndex = 9;
            // 
            // tb_deposit_amount
            // 
            this.tb_deposit_amount.Enabled = false;
            this.tb_deposit_amount.Location = new System.Drawing.Point(130, 83);
            this.tb_deposit_amount.Name = "tb_deposit_amount";
            this.tb_deposit_amount.Size = new System.Drawing.Size(116, 22);
            this.tb_deposit_amount.TabIndex = 7;
            // 
            // tb_booking_number
            // 
            this.tb_booking_number.Enabled = false;
            this.tb_booking_number.Location = new System.Drawing.Point(130, 17);
            this.tb_booking_number.Name = "tb_booking_number";
            this.tb_booking_number.Size = new System.Drawing.Size(116, 22);
            this.tb_booking_number.TabIndex = 6;
            // 
            // lbl_check_out
            // 
            this.lbl_check_out.AutoSize = true;
            this.lbl_check_out.Location = new System.Drawing.Point(6, 172);
            this.lbl_check_out.Name = "lbl_check_out";
            this.lbl_check_out.Size = new System.Drawing.Size(96, 16);
            this.lbl_check_out.TabIndex = 5;
            this.lbl_check_out.Text = "Check out date";
            // 
            // lbl_check_in
            // 
            this.lbl_check_in.AutoSize = true;
            this.lbl_check_in.Location = new System.Drawing.Point(6, 200);
            this.lbl_check_in.Name = "lbl_check_in";
            this.lbl_check_in.Size = new System.Drawing.Size(88, 16);
            this.lbl_check_in.TabIndex = 4;
            this.lbl_check_in.Text = "Check in date";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(6, 142);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(64, 16);
            this.lbl_price.TabIndex = 3;
            this.lbl_price.Text = "Total due";
            // 
            // lbl_deposit_date
            // 
            this.lbl_deposit_date.AutoSize = true;
            this.lbl_deposit_date.Location = new System.Drawing.Point(6, 116);
            this.lbl_deposit_date.Name = "lbl_deposit_date";
            this.lbl_deposit_date.Size = new System.Drawing.Size(98, 16);
            this.lbl_deposit_date.TabIndex = 2;
            this.lbl_deposit_date.Text = "Deposit due by";
            // 
            // lbl_deposit
            // 
            this.lbl_deposit.AutoSize = true;
            this.lbl_deposit.Location = new System.Drawing.Point(6, 86);
            this.lbl_deposit.Name = "lbl_deposit";
            this.lbl_deposit.Size = new System.Drawing.Size(54, 16);
            this.lbl_deposit.TabIndex = 1;
            this.lbl_deposit.Text = "Deposit";
            // 
            // lbl_booking_num
            // 
            this.lbl_booking_num.AutoSize = true;
            this.lbl_booking_num.Location = new System.Drawing.Point(6, 20);
            this.lbl_booking_num.Name = "lbl_booking_num";
            this.lbl_booking_num.Size = new System.Drawing.Size(108, 16);
            this.lbl_booking_num.TabIndex = 0;
            this.lbl_booking_num.Text = "Booking Number";
            // 
            // gb_guest_details
            // 
            this.gb_guest_details.Controls.Add(this.tb_g_phone);
            this.gb_guest_details.Controls.Add(this.lbl_g_Phone);
            this.gb_guest_details.Controls.Add(this.tb_g_address);
            this.gb_guest_details.Controls.Add(this.tb_g_cc_num);
            this.gb_guest_details.Controls.Add(this.tb_g_email);
            this.gb_guest_details.Controls.Add(this.tb_g_s_name);
            this.gb_guest_details.Controls.Add(this.tb_g_f_name);
            this.gb_guest_details.Controls.Add(this.tb_g_guest_id);
            this.gb_guest_details.Controls.Add(this.lbl_cc_num);
            this.gb_guest_details.Controls.Add(this.lbl_Address);
            this.gb_guest_details.Controls.Add(this.lbl_email);
            this.gb_guest_details.Controls.Add(this.lbl_s_name);
            this.gb_guest_details.Controls.Add(this.lbl_f_name);
            this.gb_guest_details.Controls.Add(this.lbl_guest_id);
            this.gb_guest_details.Location = new System.Drawing.Point(613, 284);
            this.gb_guest_details.Name = "gb_guest_details";
            this.gb_guest_details.Size = new System.Drawing.Size(285, 254);
            this.gb_guest_details.TabIndex = 3;
            this.gb_guest_details.TabStop = false;
            this.gb_guest_details.Text = "Guest Details";
            // 
            // tb_g_phone
            // 
            this.tb_g_phone.Location = new System.Drawing.Point(91, 133);
            this.tb_g_phone.Name = "tb_g_phone";
            this.tb_g_phone.Size = new System.Drawing.Size(188, 22);
            this.tb_g_phone.TabIndex = 10;
            // 
            // lbl_g_Phone
            // 
            this.lbl_g_Phone.AutoSize = true;
            this.lbl_g_Phone.Location = new System.Drawing.Point(8, 137);
            this.lbl_g_Phone.Name = "lbl_g_Phone";
            this.lbl_g_Phone.Size = new System.Drawing.Size(46, 16);
            this.lbl_g_Phone.TabIndex = 12;
            this.lbl_g_Phone.Text = "Phone";
            // 
            // tb_g_address
            // 
            this.tb_g_address.Location = new System.Drawing.Point(91, 189);
            this.tb_g_address.Name = "tb_g_address";
            this.tb_g_address.Size = new System.Drawing.Size(188, 55);
            this.tb_g_address.TabIndex = 12;
            this.tb_g_address.Text = "";
            // 
            // tb_g_cc_num
            // 
            this.tb_g_cc_num.Location = new System.Drawing.Point(91, 161);
            this.tb_g_cc_num.Name = "tb_g_cc_num";
            this.tb_g_cc_num.Size = new System.Drawing.Size(188, 22);
            this.tb_g_cc_num.TabIndex = 11;
            // 
            // tb_g_email
            // 
            this.tb_g_email.Location = new System.Drawing.Point(91, 105);
            this.tb_g_email.Name = "tb_g_email";
            this.tb_g_email.Size = new System.Drawing.Size(188, 22);
            this.tb_g_email.TabIndex = 9;
            // 
            // tb_g_s_name
            // 
            this.tb_g_s_name.Location = new System.Drawing.Point(91, 77);
            this.tb_g_s_name.Name = "tb_g_s_name";
            this.tb_g_s_name.Size = new System.Drawing.Size(188, 22);
            this.tb_g_s_name.TabIndex = 8;
            // 
            // tb_g_f_name
            // 
            this.tb_g_f_name.Location = new System.Drawing.Point(91, 49);
            this.tb_g_f_name.Name = "tb_g_f_name";
            this.tb_g_f_name.Size = new System.Drawing.Size(188, 22);
            this.tb_g_f_name.TabIndex = 7;
            // 
            // tb_g_guest_id
            // 
            this.tb_g_guest_id.Enabled = false;
            this.tb_g_guest_id.Location = new System.Drawing.Point(91, 21);
            this.tb_g_guest_id.Name = "tb_g_guest_id";
            this.tb_g_guest_id.Size = new System.Drawing.Size(188, 22);
            this.tb_g_guest_id.TabIndex = 6;
            this.tb_g_guest_id.Leave += new System.EventHandler(this.tb_g_guest_id_Leave);
            // 
            // lbl_cc_num
            // 
            this.lbl_cc_num.AutoSize = true;
            this.lbl_cc_num.Location = new System.Drawing.Point(7, 166);
            this.lbl_cc_num.Name = "lbl_cc_num";
            this.lbl_cc_num.Size = new System.Drawing.Size(72, 16);
            this.lbl_cc_num.TabIndex = 5;
            this.lbl_cc_num.Text = "Credit card";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(6, 211);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(58, 16);
            this.lbl_Address.TabIndex = 4;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(8, 108);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 16);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email";
            // 
            // lbl_s_name
            // 
            this.lbl_s_name.AutoSize = true;
            this.lbl_s_name.Location = new System.Drawing.Point(8, 80);
            this.lbl_s_name.Name = "lbl_s_name";
            this.lbl_s_name.Size = new System.Drawing.Size(61, 16);
            this.lbl_s_name.TabIndex = 2;
            this.lbl_s_name.Text = "Surname";
            // 
            // lbl_f_name
            // 
            this.lbl_f_name.AutoSize = true;
            this.lbl_f_name.Location = new System.Drawing.Point(8, 52);
            this.lbl_f_name.Name = "lbl_f_name";
            this.lbl_f_name.Size = new System.Drawing.Size(72, 16);
            this.lbl_f_name.TabIndex = 1;
            this.lbl_f_name.Text = "First Name";
            // 
            // lbl_guest_id
            // 
            this.lbl_guest_id.AutoSize = true;
            this.lbl_guest_id.Location = new System.Drawing.Point(8, 24);
            this.lbl_guest_id.Name = "lbl_guest_id";
            this.lbl_guest_id.Size = new System.Drawing.Size(58, 16);
            this.lbl_guest_id.TabIndex = 0;
            this.lbl_guest_id.Text = "Guest ID";
            // 
            // gb_agent
            // 
            this.gb_agent.Controls.Add(this.cb_agents);
            this.gb_agent.Controls.Add(this.lbl_a_ID);
            this.gb_agent.Location = new System.Drawing.Point(613, 544);
            this.gb_agent.Name = "gb_agent";
            this.gb_agent.Size = new System.Drawing.Size(285, 68);
            this.gb_agent.TabIndex = 12;
            this.gb_agent.TabStop = false;
            this.gb_agent.Text = "Travel Agent details";
            this.gb_agent.Visible = false;
            // 
            // cb_agents
            // 
            this.cb_agents.Enabled = false;
            this.cb_agents.FormattingEnabled = true;
            this.cb_agents.Location = new System.Drawing.Point(91, 21);
            this.cb_agents.Name = "cb_agents";
            this.cb_agents.Size = new System.Drawing.Size(188, 24);
            this.cb_agents.TabIndex = 18;
            this.cb_agents.SelectedIndexChanged += new System.EventHandler(this.cb_agents_SelectedIndexChanged);
            // 
            // lbl_a_ID
            // 
            this.lbl_a_ID.AutoSize = true;
            this.lbl_a_ID.Location = new System.Drawing.Point(7, 24);
            this.lbl_a_ID.Name = "lbl_a_ID";
            this.lbl_a_ID.Size = new System.Drawing.Size(81, 16);
            this.lbl_a_ID.TabIndex = 0;
            this.lbl_a_ID.Text = "Company ID";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(6, 21);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(133, 29);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Text = "Edit Booking";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(6, 56);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 29);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Cancel Booking";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_confirm_edit
            // 
            this.btn_confirm_edit.Location = new System.Drawing.Point(144, 21);
            this.btn_confirm_edit.Name = "btn_confirm_edit";
            this.btn_confirm_edit.Size = new System.Drawing.Size(139, 64);
            this.btn_confirm_edit.TabIndex = 15;
            this.btn_confirm_edit.Text = "Confirm Changes to Bookings";
            this.btn_confirm_edit.UseVisualStyleBackColor = true;
            this.btn_confirm_edit.Visible = false;
            this.btn_confirm_edit.Click += new System.EventHandler(this.btn_confirm_edit_Click);
            // 
            // gb_ItemView
            // 
            this.gb_ItemView.Controls.Add(this.label1);
            this.gb_ItemView.Controls.Add(this.tb_search);
            this.gb_ItemView.Controls.Add(this.rb_Block_Bookings);
            this.gb_ItemView.Controls.Add(this.lstV_Bookings);
            this.gb_ItemView.Controls.Add(this.rb_Current_Bookings);
            this.gb_ItemView.Location = new System.Drawing.Point(12, 12);
            this.gb_ItemView.Name = "gb_ItemView";
            this.gb_ItemView.Size = new System.Drawing.Size(586, 324);
            this.gb_ItemView.TabIndex = 16;
            this.gb_ItemView.TabStop = false;
            this.gb_ItemView.Text = "Bookings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search by guest ID";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(302, 14);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(100, 22);
            this.tb_search.TabIndex = 3;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // rb_Block_Bookings
            // 
            this.rb_Block_Bookings.AutoSize = true;
            this.rb_Block_Bookings.Location = new System.Drawing.Point(6, 44);
            this.rb_Block_Bookings.Name = "rb_Block_Bookings";
            this.rb_Block_Bookings.Size = new System.Drawing.Size(122, 20);
            this.rb_Block_Bookings.TabIndex = 2;
            this.rb_Block_Bookings.TabStop = true;
            this.rb_Block_Bookings.Text = "Block Bookings";
            this.rb_Block_Bookings.UseVisualStyleBackColor = true;
            // 
            // rb_Current_Bookings
            // 
            this.rb_Current_Bookings.AutoSize = true;
            this.rb_Current_Bookings.Checked = true;
            this.rb_Current_Bookings.Location = new System.Drawing.Point(6, 21);
            this.rb_Current_Bookings.Name = "rb_Current_Bookings";
            this.rb_Current_Bookings.Size = new System.Drawing.Size(130, 20);
            this.rb_Current_Bookings.TabIndex = 1;
            this.rb_Current_Bookings.TabStop = true;
            this.rb_Current_Bookings.Text = "Current Bookings";
            this.rb_Current_Bookings.UseVisualStyleBackColor = true;
            this.rb_Current_Bookings.CheckedChanged += new System.EventHandler(this.rb_Current_Bookings_CheckedChanged);
            // 
            // btn_assign
            // 
            this.btn_assign.Location = new System.Drawing.Point(6, 21);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(133, 29);
            this.btn_assign.TabIndex = 17;
            this.btn_assign.Text = "Assign Guest";
            this.btn_assign.UseVisualStyleBackColor = true;
            this.btn_assign.Click += new System.EventHandler(this.btn_assign_Click);
            // 
            // btn_confirm_assignment
            // 
            this.btn_confirm_assignment.Location = new System.Drawing.Point(144, 21);
            this.btn_confirm_assignment.Name = "btn_confirm_assignment";
            this.btn_confirm_assignment.Size = new System.Drawing.Size(138, 64);
            this.btn_confirm_assignment.TabIndex = 18;
            this.btn_confirm_assignment.Text = "Confirm Assignment";
            this.btn_confirm_assignment.UseVisualStyleBackColor = true;
            this.btn_confirm_assignment.Visible = false;
            this.btn_confirm_assignment.Click += new System.EventHandler(this.btn_confirm_assignment_Click);
            // 
            // btn_cancel_block
            // 
            this.btn_cancel_block.Location = new System.Drawing.Point(6, 56);
            this.btn_cancel_block.Name = "btn_cancel_block";
            this.btn_cancel_block.Size = new System.Drawing.Size(133, 29);
            this.btn_cancel_block.TabIndex = 19;
            this.btn_cancel_block.Text = "Cancel block booking";
            this.btn_cancel_block.UseVisualStyleBackColor = true;
            this.btn_cancel_block.Click += new System.EventHandler(this.btn_cancel_block_Click);
            // 
            // hotel_DatabaseDataSet
            // 
            this.hotel_DatabaseDataSet.DataSetName = "Hotel_DatabaseDataSet";
            this.hotel_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelDatabaseDataSetBindingSource
            // 
            this.hotelDatabaseDataSetBindingSource.DataSource = this.hotel_DatabaseDataSet;
            this.hotelDatabaseDataSetBindingSource.Position = 0;
            // 
            // gb_edit_booking
            // 
            this.gb_edit_booking.Controls.Add(this.btn_edit);
            this.gb_edit_booking.Controls.Add(this.btn_confirm_edit);
            this.gb_edit_booking.Controls.Add(this.btn_delete);
            this.gb_edit_booking.Location = new System.Drawing.Point(314, 342);
            this.gb_edit_booking.Name = "gb_edit_booking";
            this.gb_edit_booking.Size = new System.Drawing.Size(290, 91);
            this.gb_edit_booking.TabIndex = 3;
            this.gb_edit_booking.TabStop = false;
            this.gb_edit_booking.Text = "Edit Booking";
            this.gb_edit_booking.Visible = false;
            // 
            // gb_edit_Block
            // 
            this.gb_edit_Block.Controls.Add(this.btn_confirm_assignment);
            this.gb_edit_Block.Controls.Add(this.btn_cancel_block);
            this.gb_edit_Block.Controls.Add(this.btn_assign);
            this.gb_edit_Block.Location = new System.Drawing.Point(18, 342);
            this.gb_edit_Block.Name = "gb_edit_Block";
            this.gb_edit_Block.Size = new System.Drawing.Size(290, 91);
            this.gb_edit_Block.TabIndex = 16;
            this.gb_edit_Block.TabStop = false;
            this.gb_edit_Block.Text = "Edit Block booking";
            this.gb_edit_Block.Visible = false;
            // 
            // gb_canceled
            // 
            this.gb_canceled.Controls.Add(this.btn_Undo);
            this.gb_canceled.Controls.Add(this.lstv_canceled);
            this.gb_canceled.Location = new System.Drawing.Point(18, 439);
            this.gb_canceled.Name = "gb_canceled";
            this.gb_canceled.Size = new System.Drawing.Size(586, 208);
            this.gb_canceled.TabIndex = 17;
            this.gb_canceled.TabStop = false;
            this.gb_canceled.Text = "Canceled bookings";
            // 
            // btn_Undo
            // 
            this.btn_Undo.Location = new System.Drawing.Point(436, 165);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(139, 29);
            this.btn_Undo.TabIndex = 18;
            this.btn_Undo.Text = "Undo cancelation";
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Visible = false;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // lstv_canceled
            // 
            this.lstv_canceled.HideSelection = false;
            this.lstv_canceled.Location = new System.Drawing.Point(10, 21);
            this.lstv_canceled.Name = "lstv_canceled";
            this.lstv_canceled.Size = new System.Drawing.Size(345, 173);
            this.lstv_canceled.TabIndex = 0;
            this.lstv_canceled.UseCompatibleStateImageBehavior = false;
            this.lstv_canceled.SelectedIndexChanged += new System.EventHandler(this.lstv_canceled_SelectedIndexChanged);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(765, 618);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(133, 29);
            this.bt_close.TabIndex = 20;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // btn_Update_database
            // 
            this.btn_Update_database.Location = new System.Drawing.Point(626, 618);
            this.btn_Update_database.Name = "btn_Update_database";
            this.btn_Update_database.Size = new System.Drawing.Size(133, 29);
            this.btn_Update_database.TabIndex = 21;
            this.btn_Update_database.Text = "Update Database";
            this.btn_Update_database.UseVisualStyleBackColor = true;
            this.btn_Update_database.Click += new System.EventHandler(this.btn_Update_database_Click);
            // 
            // CurrentBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 651);
            this.Controls.Add(this.btn_Update_database);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.gb_edit_Block);
            this.Controls.Add(this.gb_edit_booking);
            this.Controls.Add(this.gb_canceled);
            this.Controls.Add(this.gb_ItemView);
            this.Controls.Add(this.gb_agent);
            this.Controls.Add(this.gb_guest_details);
            this.Controls.Add(this.gb_booking_details);
            this.DoubleBuffered = true;
            this.Name = "CurrentBookings";
            this.Text = "Current Bookings";
            this.Activated += new System.EventHandler(this.CurrentBookings_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CurrentBookings_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CurrentBookings_FormClosed);
            this.Load += new System.EventHandler(this.CurrentBookings_Load);
            this.gb_booking_details.ResumeLayout(false);
            this.gb_booking_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTb_people)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntb_NumRooms)).EndInit();
            this.gb_guest_details.ResumeLayout(false);
            this.gb_guest_details.PerformLayout();
            this.gb_agent.ResumeLayout(false);
            this.gb_agent.PerformLayout();
            this.gb_ItemView.ResumeLayout(false);
            this.gb_ItemView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatabaseDataSetBindingSource)).EndInit();
            this.gb_edit_booking.ResumeLayout(false);
            this.gb_edit_Block.ResumeLayout(false);
            this.gb_canceled.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstV_Bookings;
        private System.Windows.Forms.GroupBox gb_booking_details;
        private System.Windows.Forms.Label lbl_deposit_date;
        private System.Windows.Forms.Label lbl_deposit;
        private System.Windows.Forms.Label lbl_booking_num;
        private System.Windows.Forms.GroupBox gb_guest_details;
        private System.Windows.Forms.Label lbl_check_out;
        private System.Windows.Forms.Label lbl_check_in;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_s_name;
        private System.Windows.Forms.Label lbl_f_name;
        private System.Windows.Forms.Label lbl_guest_id;
        private System.Windows.Forms.Label lbl_cc_num;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_deposit_amount;
        private System.Windows.Forms.TextBox tb_booking_number;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_g_guest_id;
        private System.Windows.Forms.RichTextBox tb_g_address;
        private System.Windows.Forms.TextBox tb_g_cc_num;
        private System.Windows.Forms.TextBox tb_g_email;
        private System.Windows.Forms.TextBox tb_g_s_name;
        private System.Windows.Forms.TextBox tb_g_f_name;
        private System.Windows.Forms.DateTimePicker dtp_dep_date;
        private System.Windows.Forms.DateTimePicker dtp_check_out;
        private System.Windows.Forms.DateTimePicker dtp_check_in;
        private System.Windows.Forms.GroupBox gb_agent;
        private System.Windows.Forms.Label lbl_g_Phone;
        private System.Windows.Forms.TextBox tb_g_phone;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.NumericUpDown ntb_NumRooms;
        private System.Windows.Forms.Label lbl_NumRooms;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_confirm_edit;
        private System.Windows.Forms.GroupBox gb_ItemView;
        private System.Windows.Forms.RadioButton rb_Block_Bookings;
        private System.Windows.Forms.RadioButton rb_Current_Bookings;
        private System.Windows.Forms.Button btn_assign;
        private System.Windows.Forms.Button btn_confirm_assignment;
        private System.Windows.Forms.Button btn_cancel_block;
        private System.Windows.Forms.BindingSource hotelDatabaseDataSetBindingSource;
        private Hotel_DatabaseDataSet hotel_DatabaseDataSet;
        private System.Windows.Forms.GroupBox gb_edit_Block;
        private System.Windows.Forms.GroupBox gb_edit_booking;
        private System.Windows.Forms.GroupBox gb_canceled;
        private System.Windows.Forms.ListView lstv_canceled;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.ComboBox cb_agents;
        private System.Windows.Forms.Label lbl_a_ID;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button btn_Update_database;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nTb_people;
        private System.Windows.Forms.Label label2;
    }
}