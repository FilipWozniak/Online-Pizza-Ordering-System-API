using System;
using System.Collections.Generic;

namespace PizzaOnlineOrderingSystem.Models
{
    public partial class PizzaTopping
    {
        public int PizzaTopping1 { get; set; }
        public int ToppingId { get; set; }
        public int PizzaId { get; set; }

        public virtual Pizza Pizza { get; set; }
        public virtual Topping Topping { get; set; }
    }
}
