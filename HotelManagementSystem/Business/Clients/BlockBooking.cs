using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Business.Clients
{
    internal class BlockBooking
    {

        #region DataMembers
        private int _block_booking_id;
        private string _agent_ID, _added_by, _modified_by;
        private DateTime _start, _end, _dep_due;
        private int _num_rooms;
        private decimal _deposit_amount, _price;
        #endregion

        #region Mutators
        public int block_booking_id { get => _block_booking_id; set => _block_booking_id = value; }
        public string agent_ID { get => _agent_ID; set => _agent_ID = value; }
        public string added_by { get => _added_by; set => _added_by = value; }
        public string modified_by { get => _modified_by; set => _modified_by = value; }
        public DateTime start_date { get => _start ; set => _start = value; }
        public DateTime end_date { get => _end; set => _end = value; }
        public DateTime dep_due { get => _dep_due; set => _dep_due = value; }
        public int num_rooms { get => _num_rooms; set => _num_rooms = value; }
        public  decimal deposit_amount { get => _deposit_amount; set => _deposit_amount = value; }
        public decimal price { get => _price; set => _price = value; }

        #endregion

        #region Constructors
        public BlockBooking() { }
        #endregion

        #region

        #endregion

        #region

        #endregion
    }
}
