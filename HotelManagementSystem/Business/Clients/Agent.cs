using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Business
{
    internal class Agent
    {
        #region Data Members
        private string _agentID;
        private string _company;
        private string _phone;
        private string _email;
        private string _address;
        #endregion

        #region Mutators
        public string agentID { get => _agentID; set => _agentID = value; }
        public string company { get => _company; set => _company = value; }
        public string phone { get => _phone; set => _phone = value; }
        public string email { get => _email; set => _email = value; }
        public string address { get => _address; set => _address = value; }
        #endregion


        #region Constructor
        public Agent() { }
        #endregion

    }
}
