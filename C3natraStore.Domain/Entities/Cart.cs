using C3natraStore.Domain.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3natraStore.Domain.Entities
{
    public class Cart : BaseEntity
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public IEnumerable<CartItem> Items { get; set; } = new List<CartItem>();
    }
}
