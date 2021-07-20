using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        [NotMapped]
        public decimal TotalPrice { get; set; }
        public bool IsConfirmBySalesManger { get; set; }

        [Required]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        //public ICollection<OrderProduct> OrderItems { get; set; }
    }
}
