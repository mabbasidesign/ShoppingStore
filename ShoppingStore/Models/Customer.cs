using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingStore.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int Phone { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
