using System;
using System.Collections.Generic;

namespace PizzaOnlineOrderingSystem.Models
{
    public partial class Delivery
    {
        public Delivery()
        {
            FoodOrder = new HashSet<FoodOrder>();
        }

        public int DeliveryId { get; set; }
        public DateTime EstimatedDeliveryTime { get; set; }
        public DateTime ActualDeliveryTime { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public int DeliveryManId { get; set; }

        public virtual DeliveryMan DeliveryMan { get; set; }
        public virtual ICollection<FoodOrder> FoodOrder { get; set; }
    }
}
