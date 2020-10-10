using System;
using System.Collections.Generic;

namespace PizzaOnlineOrderingSystem.Models
{
    public partial class DeliveryMan
    {
        public DeliveryMan()
        {
            Delivery = new HashSet<Delivery>();
        }

        public int DeliveryManId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }

        public virtual ICollection<Delivery> Delivery { get; set; }
    }
}
