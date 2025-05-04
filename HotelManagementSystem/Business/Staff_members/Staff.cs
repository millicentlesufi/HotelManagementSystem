using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Business.Staff
{
    class Staff : Person
    {
        #region Data Members
        private string _empID;
        private int _role;
        #endregion

        #region Mutators
        public string empID { get => _empID; set => _empID = value; }
        public int role { get => _role; set => _role = value; }
        #endregion 

        #region Constructor
        public Staff() : base() { }
        #endregion 

        #region Utility methods

        #endregion
    }
}

