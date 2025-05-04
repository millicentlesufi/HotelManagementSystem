using HotelManagementSystem.Business;
using HotelManagementSystem.Data;
using HotelManagementSystem.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            //DataBase _data = new DataBase();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDI_HomeScreen());
            //string sql = "SELECT * FROM Bookings";
            //string table = "Bookings";

            //_data.FillDataSet(sql, table);

            //BookingControll bControl = new BookingControll();

            //Application.Run(new NewBookings());
            //Application.Run(new Form1());
            //Application.Run(new CurrentBookings());
        }
    }
}
