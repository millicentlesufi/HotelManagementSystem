using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Business
{
    internal abstract class Person
    {
        #region Data Members
        private string _id;
        private string _fName;
        private string _sName;
        private string _phone;
        private string _email;
        private string _address;
        #endregion

        #region Mutators
        public string ID { get => _id; set => _id = value; }
        public string fName { get => _fName; set => _fName = value; }
        public string sName { get => _sName; set => _sName = value; }
        public string phone { get => _phone; set => _phone = value; }
        public string email { get => _email; set => _email = value; }
        public string address { get => _address; set => _address = value; }

        #endregion

        #region Constructor
        public Person() { }

        #endregion

       
    }
}
