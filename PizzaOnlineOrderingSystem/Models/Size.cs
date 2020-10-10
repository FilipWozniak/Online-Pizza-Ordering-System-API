using System;
using System.Collections.Generic;

namespace PizzaOnlineOrderingSystem.Models
{
    public partial class Size
    {
        public Size()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int SizeId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public short SizeCentimetres { get; set; }

        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
