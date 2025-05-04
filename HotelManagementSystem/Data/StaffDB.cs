using HotelManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace HotelManagementSystem.Business.Staff
{
    internal class StaffDB:DataBase
    {
        #region Data Members
        private string sqlLocal = "SELECT * FROM Staff";
        private string table = "Staff";
        private Collection<Staff> _staff;
        #endregion

        #region Mutators
        public Collection<Staff> allStaff { get => _staff; }
        #endregion

        #region Constructor
        public StaffDB()
        {
            _staff = new Collection<Staff>();
        }
        #endregion

        #region Utility methods
        public void RunQuery(string sql, string table)
        {
            FillDataSet(sql, table);
            AddToCollection(table);
        }

        public void AddToCollection(string table)
        {
            //DataRow row = null;
            Staff staff;

            foreach (DataRow r in dsMain.Tables[table].Rows)
            {
                if (!(r.RowState == DataRowState.Deleted))
                {
                    staff = new Staff();
                    staff.empID = Convert.ToString(r["EMP_ID"]);
                    staff.ID = Convert.ToString(r["ID"]);
                    staff.fName = Convert.ToString(r["First_Name"]);
                    staff.sName = Convert.ToString(r["Surname"]);
                    staff.phone = Convert.ToString(r["Phone"]);
                    staff.email = Convert.ToString(r["Email"]);
                    staff.address = Convert.ToString(r["Address"]);
                    staff.role = Convert.ToInt32(r["Role"]);
                    _staff.Add(staff);
                }

            }
        }
        public int FindRow(string id)
        {
            int index = 0;
            int value = -1;

            foreach (DataRow r in dsMain.Tables[table].Rows)
            {
                if (r.RowState != DataRowState.Deleted)
                {
                    if (id == Convert.ToString(dsMain.Tables[table].Rows[index]["EMP_ID"]))
                    {
                        value = index;
                    }
                }
                index++;
            }
            return value;

        }
        #endregion


        #region CRUD
        public void UpdateDataSet(Staff staff, int flag)
        {
            DataRow row = null;
            if (flag == 1) //Update an existing guest
            {
                int index = FindRow(staff.empID);
                row = dsMain.Tables[table].Rows[index];
                row["ID"] = staff.ID;
                row["First_Name"] = staff.fName;
                row["Surname"] = staff.sName;
                row["Phone"] = staff.phone;
                row["Email"] = staff.email;
                row["Address"] = staff.address;
                row["Role"] = staff.role;
                AddToCollection(table);
            }
            else if (flag == 2)  //Add a new Guest
            {
                row = dsMain.Tables[table].NewRow();
                row["EMP_ID"] = staff.empID;
                row["ID"] = staff.ID;
                row["First_Name"] = staff.fName;
                row["Surname"] = staff.sName;
                row["Phone"] = staff.phone;
                row["Email"] = staff.email;
                row["Address"] = staff.address;
                row["Role"] = staff.role;
                dsMain.Tables[table].Rows.Add(row);
                _staff.Clear();
                AddToCollection(table);
            }
            else if (flag == 3)
            {
                int index = FindRow(staff.empID);
                //DataRow row = dsMain.Tables[index].Rows[index];

                dsMain.Tables[table].Rows[index].Delete();
                _staff.Clear();
                AddToCollection(table);
            }
        }
        #endregion
    }
}
