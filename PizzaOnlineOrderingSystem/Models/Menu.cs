using System;
using System.Collections.Generic;

namespace PizzaOnlineOrderingSystem.Models
{
    public partial class Menu
    {
        public Menu()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int MenuId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
