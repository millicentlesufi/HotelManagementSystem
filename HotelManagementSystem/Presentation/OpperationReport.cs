using HotelManagementSystem.Business;
using HotelManagementSystem.Business.Clients;
using HotelManagementSystem.Data;
using Microsoft.Win32;
using QuestPDF.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
//using 

namespace HotelManagementSystem.Presentation
{
    public partial class OpperationReport : Form
    {
        #region DataMembers
        private bool _occupancyReportFormClosed = false;
        private const int TOTALROOMS = 5;
        private int _privateBooking, _agentBooking, _blockBooking;
        private string _reportName;
        private string _empID;
        private List<DateTime> dates;
        private List<int> totalRooms;
        private List<decimal> totalIncome;
        private Dictionary<string, int> agents = new Dictionary<string, int>();
        private Dictionary<string, string> agentNames = new Dictionary<string, string>();

        private BookingControll _bc;
        private BlockBookingControl _bbc;
        private AgentController _ac;
        
        #endregion

        #region Mutators
        public bool occupancyReportFormClosed { get => _occupancyReportFormClosed; set => _occupancyReportFormClosed = value; }
        #endregion

        #region Constructors
        public OpperationReport(string emp)
        {
            InitializeComponent();

            _bc = new BookingControll();
            _bbc = new BlockBookingControl();
            _ac = new AgentController();
            _empID = emp;

            chrt_Income.Series.Clear();
            chrt_occGraph.Series.Clear();
            chrt_Pie_Bookings.Series.Clear();
            chrt_agent_pie.Series.Clear();
            
            this.Activated += OpperationReport_Activated;
            this.FormClosed += OpperationReport_FormClosed;
        }

        private void OpperationReport_Activated1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Events
        private void OpperationReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            _occupancyReportFormClosed = true;
        }
        private void OpperationReport_Activated(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Utility
        private void Create_X_Axis()
        {
            dates = new List<DateTime>();
            for (DateTime day = dtp_Start.Value.Date; day <= dtp_End.Value.Date; day = day.AddDays(1))
            {
                dates.Add(day);
            }
        }
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
                if(b.booking_type == 0)
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

        private void GetIncome()
        {

            totalIncome = new List<decimal>();
            BookingDB _bookingDB = new BookingDB();
            for (DateTime day = dtp_Start.Value.Date; day <= dtp_End.Value.Date; day = day.AddDays(1))
            {
                string month = day.Month.ToString();
                string d = day.Day.ToString();
                string query = $"SELECT Price FROM Room_Price WHERE [Month] = '{month}' AND [Start_Date] <= {d} AND [End_Date] >= {d}";
                decimal temp = _bookingDB.decimalReturnQuery(query);
                decimal income = 0;
                foreach (Booking b in _bc.bookings)
                {
                    if (b.check_In.Date <= day && b.check_out.Date > day)
                    {
                        income += temp * (decimal)b.numRooms;
                    }
                }
                foreach (BlockBooking bb in _bbc.bBookings)
                {
                    if (bb.start_date.Date <= day && bb.end_date.Date > day)
                    {
                        income += temp * (decimal)bb.num_rooms;
                    }
                }
                totalIncome.Add(income);
            }
        }

        private void DrawBarGraph()
        {
            chrt_occGraph.Series.Clear();
            chrt_occGraph.Titles.Clear();
            chrt_occGraph.Titles.Add("Occupancy per day");
            Series series = this.chrt_occGraph.Series.Add("Rooms booked");
            series.ChartType = SeriesChartType.Column;
            int count = 0;
            foreach (DateTime day in dates)
            {
                series.Points.AddXY(day, totalRooms[count]);
                count++;
            }

        }
        private void DrawIncomeGraph()
        {
            chrt_Income.Series.Clear();
            chrt_Income.Titles.Clear();
            chrt_Income.Titles.Add("Income Per Day");
            Series series = this.chrt_Income.Series.Add("Income Earned");
            series.ChartType = SeriesChartType.Line;
            //series.Palette = ChartColorPalette.BrightPastel;
            series.Color = Color.Red;
            //series.MarkerSize = 10;
            int count = 0;
            foreach (DateTime day in dates)
            {
                series.Points.AddXY(day,totalIncome[count]);
                count++;
            }
        }
        private void DrawBookingsPieChart()
        {
            chrt_Pie_Bookings.Series.Clear();
            chrt_Pie_Bookings.Titles.Clear();
            chrt_Pie_Bookings.Titles.Add("Bookings by Type");
            chrt_Pie_Bookings.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            chrt_Pie_Bookings.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "Booking by type",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie
            };

            chrt_Pie_Bookings.Series.Add(series);
            series.Points.AddXY("Private Bookings", _privateBooking);
            series.Points.AddXY("Bookings through agent", _agentBooking);
            series.Points.AddXY("Block Bookings", _blockBooking);
        }
        private void DrawAgentPieChart()
        {
            agents.Clear();
            foreach (Agent a in _ac.agents)
            {
                agents.Add(a.agentID, 0);
                agentNames.Add(a.agentID, a.company);
            }

            foreach (Booking b in _bc.bookings)
            {
                if (b.booking_type == 2)
                {
                    if (agents.ContainsKey($"{b.agent_ID}"))
                    {
                        string key = b.agent_ID.ToString();
                        agents[key] += b.numRooms;
                    }
                }
            }

            foreach (BlockBooking b in _bbc.bBookings)
            {
                if (agents.ContainsKey($"{b.agent_ID}"))
                {
                    string key = b.agent_ID.ToString();
                    agents[key] += b.num_rooms;
                }
            }    

            chrt_agent_pie.ChartAreas.Clear();
            chrt_agent_pie.Titles.Clear();
            chrt_agent_pie.Series.Clear();
            chrt_agent_pie.Titles.Add("Bookings by Agents");
            ChartArea chartArea = new ChartArea();
            chrt_agent_pie.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "Booking by Agent",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie
            };
            chrt_agent_pie.Series.Add(series);
            foreach (var k in agents)
            {
                series.Points.AddXY(agentNames[k.Key], k.Value);
            }


        }



        #endregion

        #region Buttons
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Generate_report_Click(object sender, EventArgs e)
        {
            if (dtp_End.Value < dtp_Start.Value)
            {
                MessageBox.Show("End date should be greater than start date");
                dtp_End.Focus();
            }
            else
            {
                agentNames.Clear();
                agents.Clear();
                gb_Oc_report.Visible = true;
                _reportName = $"Opperations_Report_{DateTime.Now.ToShortDateString()} for Period:{dtp_Start.Value.ToShortDateString()}-{dtp_End.Value.ToShortDateString()}";
                gb_Oc_report.Text = _reportName;
                Create_X_Axis();
                GetRooms();
                DrawBarGraph();
                DrawBookingsPieChart();
                DrawAgentPieChart();
                GetIncome();
                DrawIncomeGraph();
            }

        }
        private void btn_Export_Click(object sender, EventArgs e)
        {
            string title = $"Report: OccupancyReport_{DateTime.Now.Date.ToShortDateString()}";
            string description = $"This report displays the hotel performance for the period from {dtp_Start.Value.ToShortDateString()} to {dtp_End.Value.ToShortDateString()}";
            string bar = "Occupancy_Graph_By_Day.png";
            string bPie = "Bookings_By_Type.png";
            string aPie = "Bookings_By_Agent.png";
            string line = "Income_chart.png";

            string barTitle = $"Rooms booked by day from {dtp_Start.Value.ToShortDateString()} to {dtp_Start.Value.ToShortDateString()}";
            string bPieTitle = $"Booking break down by type of booking";
            string aPieTitle = "Bookings broken down by refering travel agents";
            string lineTitle = "Income recieved over period";

            
            chrt_occGraph.Titles.Clear();
            chrt_occGraph.SaveImage(bar, ChartImageFormat.Png);
            chrt_occGraph.Titles.Add(("Occupancy per day"));

            chrt_Income.Titles.Clear();
            chrt_Income.SaveImage(line, ChartImageFormat.Png);

            chrt_Pie_Bookings.Titles.Clear();
            chrt_Pie_Bookings.SaveImage(bPie, ChartImageFormat.Png);
            chrt_Pie_Bookings.Titles.Add("Bookings by Type");

            
            chrt_agent_pie.Titles.Clear();
            chrt_agent_pie.SaveImage(aPie, ChartImageFormat.Png);
            chrt_agent_pie.Titles.Add("Bookings by Agents");

            ReportControl _rc = new ReportControl();
            _rc.GenerateReport(title, description, barTitle, line, lineTitle, bar, aPieTitle, aPie, bPieTitle, bPie, DateTime.Now, _empID);

            MessageBox.Show("Report Emailed to managers");
            if (File.Exists(bar))
            {
                File.Delete(bar);
            }
            if (File.Exists(aPie))
            {
                File.Delete(aPie);
            }
            if(File.Exists(bPie))
            {
                File.Delete(bPie);
            }
            if (File.Exists(line))
            {
                File.Delete(line);
            }


        }
        #endregion


    }
}
