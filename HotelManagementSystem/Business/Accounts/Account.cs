using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Business.Accounts
{
    internal class Account
    {
        #region Data Members
        private string _empID, _password;
        private int _role;
        #endregion

        #region Mutators
        public string empID { get => _empID; set => _empID = value; }
        public string password { get => _password; set => _password = value;}
        public int role { get => _role; set => _role = value; }
        #endregion

        #region Constructor
        public Account() { }
        #endregion

        #region Utility methods

        #endregion
    }
}
