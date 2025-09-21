using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C3natraStore.Domain.Enums;

namespace C3natraStore.Domain.Entities
{
    public class ProductVariant : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public Size Size { get; set; }
        public string Color { get; set; }
        public int StockQuantity { get; set; }
        public decimal Price { get; set; }
    }
}
