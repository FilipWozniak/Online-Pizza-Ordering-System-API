using System;
using System.Collections.Generic;

namespace PizzaOnlineOrderingSystem.Models
{
    public partial class Pizza
    {
        public Pizza()
        {
            ItemsOrder = new HashSet<ItemsOrder>();
            PizzaTopping = new HashSet<PizzaTopping>();
        }

        public int PizzaId { get; set; }
        public string Name { get; set; }
        public int SizeId { get; set; }
        public int MenuId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual Size Size { get; set; }
        public virtual ICollection<ItemsOrder> ItemsOrder { get; set; }
        public virtual ICollection<PizzaTopping> PizzaTopping { get; set; }
    }
}
