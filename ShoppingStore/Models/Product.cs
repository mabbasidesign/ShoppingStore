using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        public double Quantity { get; set; }

        [Range(typeof(decimal), "0.01", "9999999999999")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 20)]
        public string Description { get; set; }

        public ICollection<Saller> Sallers { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<OrderProduct> OrderItems { get; set; }
    }
}
