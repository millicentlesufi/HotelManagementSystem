using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Business
{
    internal class Booking
    {
        #region Data memebers
        private int _bookingNumber, _numRooms, _invoiceNumber, _people;
        private string _customer_ID, _agent_ID;
        private decimal _deposit, _price;
        private DateTime _check_in, _check_out, _depDue;
        private int _booking_type, _block_booking_ID;
        private int _edit_state;
        private int _confirmed;
        private string _added_by;
        private string _modified_by;
        #endregion

        #region Mutators
        public int bookingNumber { get => _bookingNumber; set => _bookingNumber = value; }
        public int numRooms { get => _numRooms; set => _numRooms = value; }
        public int people { get => _people; set => _people = value; }
        public int invoiceNumber { get => _invoiceNumber; set => _invoiceNumber = value; }
        public string customer_ID { get => _customer_ID; set => _customer_ID = value; }
        public string agent_ID { get => _agent_ID; set => _agent_ID = value; }
        public string added_by { get => _added_by; set => _added_by = value; }
        public string modeified_by { get => _modified_by; set => _modified_by = value; }
        public decimal deposit { get => _deposit; set => _deposit = value; }
        public decimal price { get => _price; set => _price = value; }
        public DateTime check_In { get => _check_in; set => _check_in = value; }
        public DateTime check_out { get => _check_out; set => _check_out = value; }
        public DateTime depDue { get => _depDue; set => _depDue = value; }
        public int booking_type { get => _booking_type; set => _booking_type = value; }
        public int block_booking_ID { get => _block_booking_ID; set => _block_booking_ID = value; }
        public int edit_state { get => _edit_state; set => _edit_state = value; }
        public int confirmed { get => _confirmed; set => _confirmed = value; }
        #endregion

        #region Constructors
        public Booking(){}

        #endregion

        #region

        #endregion

    }
}
