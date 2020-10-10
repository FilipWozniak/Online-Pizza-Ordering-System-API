using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaOnlineOrderingSystem.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Booking = new HashSet<Booking>();
            FoodOrder = new HashSet<FoodOrder>();
        }

        public int CustomerId { get; set; }
        [Required(ErrorMessage = "FirstName is Required")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public DateTime? BirthDate { get; set; }
        [Required]
        public string PostalCode { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<FoodOrder> FoodOrder { get; set; }
    }
}
