using C3natraStore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3natraStore.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal BasePrice { get; set; }
        public string ImageUrl { get; set; }
        public Category Category { get; set; }

        public ICollection<ProductVariant> Variants { get; set; }
    }
}
