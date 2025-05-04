using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Business
{
    internal class Guest:Person
    {
        #region Data Members
        private int _bookingID;
        private string _ccNumber;
        private Collection<int> _room_Numbers;
        #endregion

        #region Mutator methods
        
        public int bookingID { get => _bookingID; set => _bookingID = value; }
       
        public string ccNumber { get => _ccNumber; set => _ccNumber = value; }
        public Collection<int> room_Numbers { get => _room_Numbers; set => _room_Numbers = value; }

        #endregion

        #region Constructor
        public Guest() : base() { }

        #endregion

        #region

        #endregion
    }
}
