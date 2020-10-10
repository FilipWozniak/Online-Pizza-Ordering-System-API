using System;
using System.Collections.Generic;

namespace PizzaOnlineOrderingSystem.Models
{
    public partial class Category
    {
        public Category()
        {
            CategoryDiscount = new HashSet<CategoryDiscount>();
            InverseParentCategory = new HashSet<Category>();
            Pizza = new HashSet<Pizza>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentCategoryId { get; set; }

        public virtual Category ParentCategory { get; set; }
        public virtual ICollection<CategoryDiscount> CategoryDiscount { get; set; }
        public virtual ICollection<Category> InverseParentCategory { get; set; }
        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
