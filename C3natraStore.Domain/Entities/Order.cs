using C3natraStore.Domain.Enums;
using C3natraStore.Domain.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3natraStore.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public decimal TotalPrice { get; set; }
        public string ShippingAddress { get; set; }

        public PaymentStatus PaymentStatus { get; set; }
        public OrderStatus OrderStatus { get; set; }


        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
