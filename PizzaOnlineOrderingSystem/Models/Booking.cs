using System;
using System.Collections.Generic;

namespace PizzaOnlineOrderingSystem.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public DateTime BookingDateFrom { get; set; }
        public DateTime? BookingDateTo { get; set; }
        public int CustomerId { get; set; }
        public int RestaurantTableId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual RestaurantTable RestaurantTable { get; set; }
    }
}
