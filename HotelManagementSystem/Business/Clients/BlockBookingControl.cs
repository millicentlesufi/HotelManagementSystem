using HotelManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Business.Clients
{
    internal class BlockBookingControl
    {
        #region Data Members
        private Collection<BlockBooking> _block_bookings;
        private BlockBookingDB _bBookingDB;

        #endregion

        #region Mutators
        public Collection<BlockBooking> bBookings { get => _block_bookings; }
        #endregion

        #region Constructors
        public BlockBookingControl()
        {
            _bBookingDB = new BlockBookingDB();
            _block_bookings = _bBookingDB.allBlockBookings;
        }
        #endregion

        #region Utility
        public BlockBooking Find(int id)
        {
            int index = 0;
            int count = _block_bookings.Count;
            bool found = (_block_bookings[index].block_booking_id == id);
            while (!found && index < count)
            {
                found = (_block_bookings[index].block_booking_id == id);
                if (found) break;
                index++;
            }
            if (found)
            {
                return _block_bookings[index];
            }
            else
            {
                return null;
            }
        }
        public int GetOccupancyLevel(DateTime day, bool existingBooking, BlockBooking blockBooking)
        {
            int rooms = 0;
            foreach (BlockBooking b in _block_bookings)
            {
                if (existingBooking)
                {
                    if (b.block_booking_id == blockBooking.block_booking_id)
                    {
                        continue;
                    }
                }
                if ((b.start_date <= day )&& (b.end_date > day))
                {
                    rooms += b.num_rooms;
                }
            }
            return rooms;
        }
        public int GetBlockBookingRooms(Collection<Booking> bookings, int blockID, DateTime day)
        {
            int rooms = 0;
            foreach(Booking b in bookings)
            {
                if(b.check_In <= day && b.check_out > day) 
                {
                    if (b.block_booking_ID == blockID)
                    {
                        rooms += b.numRooms;
                    }
                }
            }
            return rooms;
        }
        #endregion

        #region CRUD

        public void UndoDelete(int id)
        {
            _bBookingDB.UndoDelete(id);
        }
        public bool UpdateDataSet(BlockBooking b, int flag)
        {
            try
            {
                _bBookingDB.UpdateDataSet(b, flag);
                return true;
            }
            catch { return false; }
        }
        public int UpdateDataSource()
        {
            string sql = "SELECT * FROM Block_Bookings";
            string table = "Block_Bookings";
            return  _bBookingDB.UpdateDataSource(sql, table);
            
        }
        public void FillDataSet(string sql, string table)
        {
            _bBookingDB.FillDataSet(sql, table);
            _bBookingDB.AddToCollection(table);
            _block_bookings = _bBookingDB.allBlockBookings;
        }
        #endregion
    }
}
