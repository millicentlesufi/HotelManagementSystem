using HotelManagementSystem.Business;
using HotelManagementSystem.Business.Clients;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data
{
    internal class BlockBookingDB:DataBase
    {
        #region Data members
        private string sqlLocal = "SELECT * FROM Block_Bookings";
        private string table = "Block_Bookings";
        private Collection<BlockBooking> _block_bookings;
        #endregion

        #region Mutators
        public Collection<BlockBooking> allBlockBookings { get => _block_bookings; }
        #endregion

        #region Constructor
        public BlockBookingDB()
        {
            _block_bookings = new Collection<BlockBooking>();
            RunQuery(sqlLocal,table);
        }
        #endregion

        #region CRUD Methods
        public void RunQuery(string sql, string table)
        {
            FillDataSet(sql, table);
            AddToCollection(table);
        }
        public void UndoDelete(int id)
        {
            foreach (DataRow r in dsMain.Tables[table].Rows)
            {
                if (r.RowState == DataRowState.Deleted)
                {
                    r.RejectChanges();
                    AddToCollection(table);
                }
            }
        }
        public void AddToCollection(string table)
        {
            //DataRow row = null;
            BlockBooking booking;
            _block_bookings.Clear();
            foreach (DataRow r in dsMain.Tables[table].Rows)
            {
                if (!(r.RowState == DataRowState.Deleted))
                {
                    booking = new BlockBooking();
                    booking.block_booking_id = Convert.ToInt32(r["Block_Booking_ID"]);
                    booking.agent_ID = Convert.ToString(r["Agent_ID"]);
                    booking.start_date = Convert.ToDateTime(r["Start_date"]);
                    booking.end_date = Convert.ToDateTime(r["End_date"]);
                    booking.dep_due = Convert.ToDateTime(r["Deposit_Date"]);
                    booking.num_rooms = Convert.ToInt32(r["Number_of_rooms"]);
                    booking.deposit_amount = Convert.ToDecimal(r["Deposit_Amount"]);
                    booking.price = Convert.ToDecimal(r["Price"]);
                    booking.added_by = Convert.ToString(r["Added_by"]);
                    booking.modified_by = Convert.ToString(r["Modified_by"]);
                    _block_bookings.Add(booking);
                }

            }
        }

        public void UpdateDataSet(BlockBooking booking, int flag)
        {
            if (flag == 1) // Update an existing booking
            {
                int index = FindRow(booking);
                DataRow row = dsMain.Tables[table].Rows[index];
                //row["Block_Booking_ID"] = booking.block_booking_id;
                row["Agent_ID"] = booking.agent_ID;
                row["Start_date"] = booking.start_date;
                row["End_date"] = booking.end_date;
                row["Deposit_Date"] = booking.dep_due;
                row["Number_of_rooms"] = booking.num_rooms;
                row["Deposit_Amount"] = booking.deposit_amount;
                row["Price"] = booking.price;
                row["Added_by"] = booking.added_by;
                row["Modified_by"] = booking.modified_by;
                AddToCollection(table);
            }

            else if (flag == 2) // Add a new booking
            {
                //int index = FindRow(booking);
                DataRow row = dsMain.Tables[table].NewRow();
                row["Block_Booking_ID"] = booking.block_booking_id;
                row["Agent_ID"] = booking.agent_ID;
                row["Start_date"] = booking.start_date;
                row["End_date"] = booking.end_date;
                row["Deposit_Date"] = booking.dep_due;
                row["Number_of_rooms"] = booking.num_rooms;
                row["Deposit_Amount"] = booking.deposit_amount;
                row["Price"] = booking.price;
                row["Added_by"] = booking.added_by;
                row["Modified_by"] = booking.modified_by;
                dsMain.Tables[table].Rows.Add(row);
                _block_bookings.Clear();
                AddToCollection(table);
            }

            else if (flag == 3)
            {
                int index = FindRow(booking);
                //DataRow row = dsMain.Tables[index].Rows[index];

                dsMain.Tables[table].Rows[index].Delete();
                _block_bookings.Clear();
                AddToCollection(table);
            }

        }
        private int FindRow(BlockBooking b)
        {
            int index = 0;
            int value = -1;

            foreach (DataRow r in dsMain.Tables[table].Rows)
            {
                if (r.RowState != DataRowState.Deleted)
                {
                    if (b.block_booking_id == Convert.ToInt32(dsMain.Tables[table].Rows[index]["Block_Booking_ID"]))
                    {
                        value = index;
                    }
                }
                index++;
            }
            return value;
        }
        #endregion
    }
}
