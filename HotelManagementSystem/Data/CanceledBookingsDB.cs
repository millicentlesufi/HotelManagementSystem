using HotelManagementSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data
{
    internal class CanceledBookingsDB:DataBase
    {
        #region DataMembers
        private Collection<CanceledBooking> _canceled_bookings;
        private string sqlLocal = "SELECT * FROM Canceled_Bookings";
        private string table = "Canceled_Bookings";
        #endregion

        #region Mutators
        public Collection<CanceledBooking> allCanceledBookings
        {
            get { return _canceled_bookings; }
        }
        #endregion

        #region Constructor
        public CanceledBookingsDB() :base()
        {
            _canceled_bookings = new Collection<CanceledBooking>();
            FillDataSet(sqlLocal, table);
        }
        #endregion

        #region Crud Methods
        public void AddToCollection(string table)
        {
            //DataRow row = null;
            CanceledBooking canceled_booking;

            foreach (DataRow r in dsMain.Tables[table].Rows)
            {
                if (!(r.RowState == DataRowState.Deleted))
                {
                    canceled_booking = new CanceledBooking();
                    canceled_booking.id = Convert.ToInt32(r["Booking_ID"]);
                    canceled_booking.date = Convert.ToDateTime(r["Date_Canceled"]);
                    canceled_booking.amount = Convert.ToDecimal(r["Refund_Amount"]);
                    canceled_booking.guest_ID = Convert.ToString(r["Guest_ID"]);
                    canceled_booking.agent_ID = Convert.ToString(r["Agent_ID"]);
                    _canceled_bookings.Add(canceled_booking);
                }

            }
        }

        public void RunQuery(string sql, string table)
        {
            FillDataSet(sql, table);
            AddToCollection(table);
        }
        private int FindRow(CanceledBooking c)
        {
            int index = 0;
            int value = -1;

            foreach (DataRow r in dsMain.Tables[table].Rows)
            {
                if (r.RowState != DataRowState.Deleted)
                {
                    if (c.id == Convert.ToInt32(dsMain.Tables[table].Rows[index]["Booking_ID"]))
                    {
                        value = index;
                    }
                }
                index++;
            }
            return value;
        }

        public void UpdateDataSet(CanceledBooking cbooking, int flag)
        {
            switch (flag)
            {
                case 1:
                    

                    break;                
                case 2:
                    DataRow row = dsMain.Tables[table].NewRow();
                    row["Booking_ID"] = cbooking.id;
                    row["Date_Canceled"] = cbooking.date;
                    row["Refund_Amount"] = cbooking.amount;
                    row["Guest_ID"] = cbooking.guest_ID;
                    row["Agent_ID"] = cbooking.agent_ID;
                    dsMain.Tables[table].Rows.Add(row);
                    break;
                case 3:
                    int index = FindRow(cbooking);
                    DataRow r = dsMain.Tables[table].Rows[index];
                    r.Delete();
                    break;
                default:
                    break;
            }
            
            _canceled_bookings.Clear();
            AddToCollection(table);
        }
        #endregion


    }
}
