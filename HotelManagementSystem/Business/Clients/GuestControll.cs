using HotelManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace HotelManagementSystem.Business
{
    internal class GuestControll
    {
        #region Data Members
        private Collection<Guest> _guests;
        private GuestDB _guestDB;
        //private int _rooms;
        #endregion

        #region Mutators
        public Collection<Guest> guests { get => _guests; }
        #endregion

        #region Constructors
        public GuestControll()
        {
            _guestDB = new GuestDB();
            getAllGuests();
        }
        #endregion

        #region Utility Methods
        public Guest Find(string id)
        {
            int index = 0;
            int count = _guests.Count;
            bool found = (_guests[index].ID == id);
            while (!found && index < count -1)
            {
                index++;
                found = (_guests[index].ID == id);
                
                
            }
            if (found)
            {
                return _guests[index];
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region CRUD Methods

        public int UpdateDataSource()
        {
            string sql = "SELECT * FROM Guests";
            string table = "Guests";
            return _guestDB.UpdateDataSource(sql, table);
        }

        public int ModifyGuest(Guest guest, int flag)
        {
            try
            {
                if (flag == 1)
                {
                    return _guestDB.UpdateDataSet(guest, 1);
                }
                else if (flag == 2) 
                {
                    return _guestDB.UpdateDataSet(guest, 2);
                }
                
                return 0;
            }
            catch
            { return 0; }
            
        }

        public void getAllGuests()
        {
            if (_guests != null) { _guests.Clear(); }
            string query = "SELECT * FROM Guests";
            string table = "Guests";

            _guestDB.RunQuery(query, table);
            _guests = _guestDB.allGuests;
        }

        public Guest getGuest(string gID)
        {
            return _guestDB.FindGuest(gID);
        }
        
        #endregion
    }
}
