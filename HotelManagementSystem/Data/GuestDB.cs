using HotelManagementSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Data
{
    internal class GuestDB:DataBase
    {
        #region Data Members
        private string sqlLocal = "SELECT * FROM Guests";
        private string table = "Guests";
        private Collection<Guest> guests;
        #endregion

        #region Mutator Methods
        public Collection<Guest> allGuests { get => guests; }
        #endregion

        #region Constructors
        public GuestDB() : base()
        {
            guests = new Collection<Guest>();
            FillDataSet(sqlLocal, table);
        }
        #endregion

        #region CRUD Methods

        public void AddToCollection(string table)
        {
            //DataRow row = null;
            Guest guest;
            guests.Clear();
            foreach (DataRow r in dsMain.Tables[table].Rows)
            {
                if (!(r.RowState == DataRowState.Deleted))
                {
                    guest = new Guest();
                    //guest.bookingID = Convert.ToInt32(r["Booking_ID"]);
                    guest.ID = Convert.ToString(r["Guest_ID"]);
                    guest.fName = Convert.ToString(r["First_Name"]);
                    guest.sName = Convert.ToString(r["Surname"]);
                    guest.phone = Convert.ToString(r["Phone"]);
                    guest.email = Convert.ToString(r["Email"]);
                    guest.address = Convert.ToString(r["Address"]);
                    guest.ccNumber = Convert.ToString(r["CC_Number"]);
                    guests.Add(guest);
                }

            }
        }

        public void RunQuery(string sql, string table)
        {
            FillDataSet(sql, table);
            AddToCollection(table);
        }

        public int UpdateDataSet(Guest guest, int flag)
        {
            //int code;
            DataRow row = null;
            if (flag == 1) //Update an existing guest
            {
                int index = FindRow(guest.ID);
                row = dsMain.Tables[table].Rows[index];
                row["First_Name"] = guest.fName;
                row["Surname"] = guest.sName;
                row["Phone"] = guest.phone;
                row["Email"] = guest.email;
                row["Address"] = guest.address;
                row["CC_Number"] = guest.ccNumber;
                AddToCollection(table);
            }
            else if (flag == 2)  //Add a new Guest
            {
                row = dsMain.Tables[table].NewRow();
                row["Guest_ID"] = guest.ID;
                row["First_Name"] = guest.fName;
                row["Surname"] = guest.sName;
                row["Phone"] = guest.phone;
                row["Email"] = guest.email;
                row["Address"] = guest.address;
                row["CC_Number"] = guest.ccNumber;
                dsMain.Tables[table].Rows.Add(row);
                guests.Clear();
                AddToCollection(table);
            }
            if (row.RowState == DataRowState.Modified)
            {
                return 1;
            }
            else if (row.RowState == DataRowState.Added)
            {
                return 2;
            }
            else if (row.RowState == DataRowState.Unchanged)
            {
                return 3;
            }
            else
                return 0;
        }


        public int FindRow(string id)
        {
            int index = 0;
            int value = -1;

            foreach (DataRow r in dsMain.Tables[table].Rows)
            {
                if (r.RowState != DataRowState.Deleted)
                {
                    if (id == Convert.ToString(dsMain.Tables[table].Rows[index]["Guest_ID"]))
                    {
                        value = index;
                    }
                }
                index++;
            }
            return value;
            
        }
        public Guest FindGuest(string gID)
        {
            Guest temp = new Guest();
            string query = "SELECT * FROM Guests WHERE Guest_ID = @Guest_ID";

            cnMain.Open();
            using (SqlCommand command = new SqlCommand(query, cnMain))
            {
                command.Parameters.AddWithValue("@Guest_ID", gID);
                //command.ExecuteScalar();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) 
                {
                    temp.ID = reader.GetString(0);
                    temp.fName = reader.GetString(1);
                    temp.sName = reader.GetString(2);
                    temp.phone = reader.GetString(3);
                    temp.email = reader.GetString(4);
                    temp.address = reader.GetString(5);
                    temp.ccNumber = reader.GetString(6);
                }

                
                cnMain.Close();
            }
            return temp;
        }

        #endregion
    }
}
