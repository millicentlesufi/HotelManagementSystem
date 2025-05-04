using HotelManagementSystem.Business.Clients;
using HotelManagementSystem.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HotelManagementSystem.Presentation
{
    public partial class OccupancyReport : Form
    {
        #region Data members
        private bool _formClosed = false;
        private const int TOTALROOMS = 5;
        private int _privateBooking, _agentBooking, _blockBooking;
        private string _reportName;
        private string _empID;
        private List<DateTime> dates;
        private List<int> totalRooms;

        private BookingControll _bc;
        private BlockBookingControl _bbc;
        #endregion

        #region Mutators
        public bool formClosed { get => _formClosed; }
        #endregion
        #region
        public OccupancyReport(string emp)
        {
            InitializeComponent();
            _formClosed = false;
            _bc = new BookingControll();
            _bbc = new BlockBookingControl();
            
            _empID = emp;
            chrt_bookings.Series.Clear();
        }
        #endregion
        #region Events
        private void OccupancyReport_Load(object sender, EventArgs e)
        {

        }
        private void OccupancyReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            _formClosed = true;
        }

        #endregion 

        #region Utilities
        private void GetRooms()
        {

            string queryBookings = $"SELECT * FROM Bookings WHERE Check_In <= '{dtp_End.Value.Date}' AND Check_Out > '{dtp_Start.Value.Date}' AND Block_Booking_ID = -1";
            _bc.FillDataSet(queryBookings, "Bookings");
            string queryBlockBookings = $"SELECT * FROM Block_Bookings WHERE Start_date <= '{dtp_End.Value.Date}' AND End_date > '{dtp_Start.Value.Date}'";
            _bbc.FillDataSet(queryBlockBookings, "Block_Bookings");
            totalRooms = new List<int>();
            for (DateTime day = dtp_Start.Value.Date; day <= dtp_End.Value.Date; day = day.AddDays(1))
            {
                int rooms = 0;
                rooms += _bc.CheckOccupencyLevel(day, false, null);
                rooms += _bbc.GetOccupancyLevel(day, false, null);
                totalRooms.Add(rooms);
            }

            _privateBooking = 0;
            _agentBooking = 0;
            _blockBooking = 0;
            foreach (Booking b in _bc.bookings)
            {
                if (b.booking_type == 0)
                {
                    _privateBooking += b.numRooms;
                }
                else if (b.booking_type == 2)
                {
                    _agentBooking += b.numRooms;
                }
            }
            foreach (BlockBooking bb in _bbc.bBookings)
            {
                _blockBooking += bb.num_rooms;
            }
        }
        private void Create_X_Axis()
        {
            dates = new List<DateTime>();
            for (DateTime day = dtp_Start.Value.Date; day <= dtp_End.Value.Date; day = day.AddDays(1))
            {
                dates.Add(day);
            }
        }
        private void DrawBarGraph()
        {
            chrt_bookings.Series.Clear();
            chrt_bookings.Titles.Clear();
            chrt_bookings.Titles.Add("Bookings per day");
            Series series = this.chrt_bookings.Series.Add("Rooms booked");
            series.ChartType = SeriesChartType.Column;
            int count = 0;
            foreach (DateTime day in dates)
            {
                series.Points.AddXY(day, totalRooms[count]);
                count++;
            }

        }
        #endregion

        #region Buttons
        private void btn_Generate_report_Click(object sender, EventArgs e)
        {
            if(dtp_End.Value < dtp_Start.Value)
            {
                MessageBox.Show("End date should be greater than start date!");
            }
            else
            {
                GetRooms();
                Create_X_Axis();
                DrawBarGraph();
                gb_Charts.Text = $"Occupancy_Report_{DateTime.Now.ToShortDateString()}";
                gb_Charts.Visible = true;
            }
            
        }
        #endregion


    }
}
