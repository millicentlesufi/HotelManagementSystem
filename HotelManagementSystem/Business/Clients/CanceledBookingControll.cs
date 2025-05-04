using HotelManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Business
{
    internal class CanceledBookingControll
    {
        #region Data Members
        private Collection<CanceledBooking> _canceledBookings;
        private CanceledBookingsDB _cbDB;

        #endregion

        #region Mutators
        public Collection<CanceledBooking> canceledBookings { get => _canceledBookings; }
        #endregion

        #region Constructor
        public CanceledBookingControll()
        {
            _cbDB = new CanceledBookingsDB();
            getAllCanceledBookings();
        }
        #endregion

        #region Utility methods
        public void getAllCanceledBookings()
        {
            if (_canceledBookings != null) { _canceledBookings.Clear(); }

            string query = "SELECT * FROM Canceled_Bookings";
            string table = "Canceled_Bookings";
            _cbDB.RunQuery(query, table);
            _canceledBookings = _cbDB.allCanceledBookings;
        }

        public void UpdateDataSet(CanceledBooking cb, int flag)
        {
            _cbDB.UpdateDataSet(cb, flag);
        }

        public CanceledBooking Find(int id)
        {
            int index = 0;
            int count = _canceledBookings.Count;
            bool found = (_canceledBookings[index].id == id);
            while (!found && index < count)
            {
                index++;
                found = (_canceledBookings[index].id == id);
            }
            if (found)
            {
                return _canceledBookings[index];
            }
            else
            {
                return null;
            }
        }

        public int UpdateDataSource()
        {
            string sql = "SELECT * FROM Canceled_Bookings";
            string table = "Canceled_Bookings";
            return _cbDB.UpdateDataSource(sql, table);
        }
        #endregion
    }
}
