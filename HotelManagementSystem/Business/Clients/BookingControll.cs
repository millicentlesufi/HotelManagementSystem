using HotelManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Business
{
    internal class BookingControll
    {
        #region Data Members
        private Collection<Booking> _bookings;
        private BookingDB _bookingDB;
        private const int _rooms = 5;
        
        #endregion

        #region Mutators
        public Collection<Booking> bookings { get => _bookings; }
        #endregion

        #region Constructors
        public BookingControll()
        {
            _bookingDB = new BookingDB();
            getAllBookings();
        }
        #endregion

        #region Utility Methods

        public Booking Find(int id)
        {
            int index = 0;
            int count = _bookings.Count;
            bool found = (_bookings[index].bookingNumber == id);
            while (!found &&  index < count) 
            {
                index++;
                found = (_bookings[index].bookingNumber == id);
            }
            if (found)
            {
                return _bookings[index];
            }
            else
            {
                return null;
            }
        }
        public void UndoDeleted(int id)
        {
            _bookingDB.UndoDeleted(id);
        }

        public int CheckOccupencyLevel(DateTime day, bool existingBooking, Booking booking)
        {
            int rooms = 0;

            foreach (Booking b in _bookings)
            {
                if (existingBooking)
                {
                    if (booking.bookingNumber == b.bookingNumber)
                    {
                        continue;
                    }
                }
                if ((b.check_out > day) && (b.check_In <= day))
                {
                    rooms += b.numRooms;
                }

            }

            return rooms;
        }

        public decimal CalculatePrice(DateTime ci, DateTime co, int r)
        {
            decimal price = 0;
            string day, month, query;
            for (DateTime d = ci; d < co; d = d.AddDays(1))
            {
                month = d.Month.ToString();
                day = d.Day.ToString();
                query = $"SELECT Price FROM Room_Price WHERE [Month] = '{month}' AND [Start_Date] <= {day} AND [End_Date] >= {day}";
                decimal temp = _bookingDB.decimalReturnQuery(query);
                temp = temp * (decimal)r;
                price += temp;
            }
            return price;
        }
        #endregion

        #region CRUD Methods

        public int GetRowState(Booking b)
        {
            return _bookingDB.GetRowState(b);
        }
        public void getAllBookings()
        {
            if (bookings != null) { bookings.Clear(); }

            string query = "SELECT * FROM Bookings";
            string table = "Bookings";
            _bookingDB.RunQuery(query, table);
            _bookings = _bookingDB.allBookings;
        }
   
        public int UpdateDataSource()
        {
            string sql = "SELECT * FROM Bookings";
            string table = "Bookings";
            return _bookingDB.UpdateDataSource(sql, table);
            
        }

        public bool UpdateDataSet(Booking b, int flag)
        {
            try
            {
                _bookingDB.UpdateDataSet(b, flag);
                if (flag == 1)
                {
                    b.edit_state = 1;
                }
                return true;
            }
            catch { return false; }
        }

        public void FillDataSet(string sql, string table)
        {
            _bookingDB.FillDataSet(sql, table);
            _bookingDB.AddToCollection(table);
            _bookings = _bookingDB.allBookings;

        }
       

        #endregion
    }
}
