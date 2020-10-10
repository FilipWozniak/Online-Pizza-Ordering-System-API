using System;
using System.Collections.Generic;

namespace PizzaOnlineOrderingSystem.Models
{
    public partial class RestaurantTable
    {
        public RestaurantTable()
        {
            Booking = new HashSet<Booking>();
        }

        public int RestaurantTableId { get; set; }
        public byte TableNumber { get; set; }
        public byte NumberofSeats { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }
    }
}
