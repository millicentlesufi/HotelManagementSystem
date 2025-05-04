using HotelManagementSystem.Business;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data
{
    internal class BookingDB: DataBase
    {
        #region Data Members
        private string sqlLocal = "SELECT * FROM Bookings";
        private string table = "Bookings";
        private Collection<Booking> bookings;
        #endregion

        #region Mutators
        public Collection<Booking> allBookings
        {
            get{return bookings;}
        }

        #endregion

        #region Constructor
        public BookingDB():base()
        {
            bookings = new Collection<Booking>();
            FillDataSet(sqlLocal, table);
        }

        #endregion

        #region CRUD methods
        public void AddToCollection(string table)
        {
            //DataRow row = null;
            Booking booking;
            bookings.Clear();
            foreach (DataRow r in dsMain.Tables[table].Rows)
            {
                if (!(r.RowState == DataRowState.Deleted))
                {
                    booking = new Booking();
                    booking.bookingNumber = Convert.ToInt32(r["Booking_Number"]);
                    booking.people = Convert.ToInt32(r["People"]);
                    booking.invoiceNumber = Convert.ToInt32(r["Invoice_Number"]);
                    booking.numRooms = Convert.ToInt32(r["Number_of_rooms"]);
                    booking.deposit = Convert.ToDecimal(r["Deposit_Amount"]);
                    booking.price = Convert.ToDecimal(r["Price_Due"]);
                    booking.depDue = Convert.ToDateTime(r["Deposit_Final_Date"]);
                    booking.customer_ID = Convert.ToString(r["Customer_ID"]);
                    booking.agent_ID = Convert.ToString(r["Travel_agent_ID"]);
                    booking.check_In = Convert.ToDateTime(r["Check_In"]);
                    booking.check_out = Convert.ToDateTime(r["Check_Out"]);
                    booking.booking_type = Convert.ToInt32(r["Booking_Type"]);
                    booking.agent_ID = Convert.ToString(r["Travel_agent_ID"]);
                    booking.confirmed = Convert.ToInt32(r["Confirmed"]);
                    booking.added_by = Convert.ToString(r["Added_by"]);
                    booking.modeified_by = Convert.ToString(r["Modified_by"]);
                    try
                    {
                        booking.block_booking_ID = Convert.ToInt32(r["Block_Booking_ID"]);
                    }
                    catch { booking.block_booking_ID = -1; }

                    if (r.RowState == DataRowState.Modified)
                    {
                        booking.edit_state = 1;
                    }
                    else if (r.RowState == DataRowState.Added)
                    {
                        booking.edit_state = 2;
                    }
                    bookings.Add(booking);
                }
            }
                
            
        }
        public decimal decimalReturnQuery(string query) 
        {
            //decimal ans = 0;
            SqlCommand statement = new SqlCommand(query, cnMain);
            daMain.SelectCommand = statement;
            cnMain.Open();
            object res = statement.ExecuteScalar();
            decimal result = Convert.ToDecimal(res);
            cnMain.Close();

            return result;
        }
        public void RunQuery(string sql, string table)
        {
            FillDataSet(sql, table);
            AddToCollection(table);
        }
        public void UpdateDataSet(Booking booking, int flag)
        {
            if (flag == 1) // Update an existing booking
            {
                int index = FindRow(booking);
                DataRow row = dsMain.Tables[table].Rows[index];
                row["People"] = booking.people;
                row["Booking_Number"] = booking.bookingNumber;
                row["Customer_ID"] = booking.customer_ID;
                row["Invoice_Number"] = booking.invoiceNumber;
                row["Number_of_rooms"] = booking.numRooms;
                row["Deposit_Amount"] = booking.deposit;
                row["Check_In"] = booking.check_In;
                row["Check_Out"] = booking.check_out;
                row["Deposit_Final_Date"] = booking.depDue;
                row["Price_Due"] = booking.price;
                row["Booking_Type"] = booking.booking_type;
                row["Travel_agent_ID"] = booking.agent_ID;
                row["Block_Booking_ID"] = booking.block_booking_ID;
                row["Confirmed"] = booking.confirmed;
                row["Added_by"] = booking.added_by;
                row["Modified_by"] = booking.modeified_by;
                // AddToCollection(table);
            }

            else if (flag == 2) // Add a new booking
            {
                //int index = FindRow(booking);
                DataRow row = dsMain.Tables[table].NewRow();
                row["Booking_Number"] = booking.bookingNumber;
                row["Invoice_Number"] = booking.invoiceNumber;
                row["Customer_ID"] = booking.customer_ID;
                row["People"] = booking.people;
                row["Number_of_rooms"] = booking.numRooms;
                row["Deposit_Amount"] = booking.deposit;
                row["Check_In"] = booking.check_In;
                row["Check_Out"] = booking.check_out;
                row["Deposit_Final_Date"] = booking.depDue;
                row["Price_Due"] = booking.price;
                row["Booking_Type"] = booking.booking_type;
                row["Travel_agent_ID"] = booking.agent_ID;
                row["Block_Booking_ID"] = booking.block_booking_ID;
                row["Confirmed"] = booking.confirmed;
                row["Added_by"] = booking.added_by;
                row["Modified_by"] = booking.modeified_by;
                dsMain.Tables[table].Rows.Add(row);
                bookings.Clear();
                AddToCollection(table);
            }

            else if (flag == 3)
            {
                int index = FindRow(booking);
                //DataRow row = dsMain.Tables[index].Rows[index];

                dsMain.Tables[table].Rows[index].Delete();
                bookings.Clear();
                AddToCollection(table);
            }

            
        }
        private int FindRow(Booking b)
        {
            int index = 0;
            int value = -1;

            foreach (DataRow r in dsMain.Tables[table].Rows)
            {
                if (r.RowState != DataRowState.Deleted)
                {
                    if (b.bookingNumber == Convert.ToInt32(dsMain.Tables[table].Rows[index]["Booking_Number"]))
                    {
                        value = index;
                        break;
                    }
                }
                index++;
            }
            return value;
        }
        public int GetRowState(Booking b)
        {
            int index = FindRow(b);
            DataRowState rs = dsMain.Tables[table].Rows[index].RowState;
            if (rs == DataRowState.Added)
            {
                return 1;
            }
            else if (rs == DataRowState.Modified)
            {
                return 2;
            }
            else if (rs == DataRowState.Deleted)
            {
                return 3;
            }
            else return 0;
        }

        public void UndoDeleted(int id)
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
       

        #endregion
    }
}
