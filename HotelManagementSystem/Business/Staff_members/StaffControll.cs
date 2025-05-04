using HotelManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Business.Staff
{
    internal class StaffControll
    {
        #region Data Members
        private Collection<Staff> _staff;
        private StaffDB _staffDB;
        string sqlLocal = "SELECT * FROM Staff";
        string table = "Staff";
        #endregion

        #region Mutators
        public Collection<Staff> allStaff { get => _staff; }
        #endregion

        #region Constructor
        public StaffControll()
        {
            _staffDB = new StaffDB();
            GetAllStaff();
        }
        #endregion

        #region Utility methods
        private void GetAllStaff()
        {
            if(_staff != null) {_staff.Clear(); }

            string query = "SELECT * FROM Staff";
            string table = "Staff";
            _staffDB.RunQuery(query, table);
            _staff = _staffDB.allStaff;
        }

        public Staff Find(string id)
        {
            int index = 0;
            int count = _staffDB.allStaff.Count;
            bool found = (_staffDB.allStaff[index].empID == id);
            while (!found && index < count)
            {
                index++;
                found = (_staffDB.allStaff[index].empID == id);
            }
            if (found)
            {
                return _staffDB.allStaff[index];
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region CRUD METHODS
        public void ModifyStaff(Staff staff, int flag)
        {
            try
            {
                _staffDB.UpdateDataSet(staff, flag);
            }
            catch
            { }

        }

        public void UpdateDateSource()
        {
            _staffDB.UpdateDataSource(sqlLocal, table);
        }
        #endregion
    }
}
