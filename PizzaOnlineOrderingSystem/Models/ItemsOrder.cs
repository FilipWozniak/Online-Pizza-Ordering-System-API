using System;
using System.Collections.Generic;

namespace PizzaOnlineOrderingSystem.Models
{
    public partial class ItemsOrder
    {
        public int ItemsOrderId { get; set; }
        public int PizzaId { get; set; }
        public int FoodOrderId { get; set; }

        public virtual FoodOrder FoodOrder { get; set; }
        public virtual Pizza Pizza { get; set; }
    }
}
