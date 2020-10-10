using System;
using System.Collections.Generic;

namespace PizzaOnlineOrderingSystem.Models
{
    public partial class FoodOrder
    {
        public FoodOrder()
        {
            ItemsOrder = new HashSet<ItemsOrder>();
        }

        public int FoodOrderId { get; set; }
        public int Amount { get; set; }
        public string OrderType { get; set; }
        public int? DeliveryId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Delivery Delivery { get; set; }
        public virtual ICollection<ItemsOrder> ItemsOrder { get; set; }
    }
}
