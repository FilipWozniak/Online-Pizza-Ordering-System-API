using System;
using System.Collections.Generic;

namespace PizzaOnlineOrderingSystem.Models
{
    public partial class CategoryDiscount
    {
        public int CategoryDiscountId { get; set; }
        public string Name { get; set; }
        public byte[] CreateDate { get; set; }
        public DateTime ValidStartDate { get; set; }
        public DateTime ValidEndDate { get; set; }
        public string CouponCode { get; set; }
        public int DiscountPercentValue { get; set; }
        public decimal MinimumOrderValue { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
