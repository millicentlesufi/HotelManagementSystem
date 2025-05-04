using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Business
{
    internal class CanceledBooking
    {
        #region Data Members
        private int _id;
        private DateTime _date;
        private decimal _amount;
        private string _guest_ID, _agent_ID;
        #endregion

        #region Mutators
        public int id { get => _id; set => _id = value; }
        public DateTime date { get => _date; set => _date = value; }
        public decimal amount { get => _amount; set => _amount = value; }
        public string guest_ID { get => _guest_ID; set => _guest_ID = value; }
        public string agent_ID { get => _agent_ID; set => _agent_ID = value; }
        #endregion

        #region Constructor
        public CanceledBooking() { }
        #endregion
    }
}
