using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingStore.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [Range(15, 80)]
        public int Age { get; set; }

        [Required]
        public int PositionId { get; set; }
        public Position Position { get; set; }

        [Required]
        public int NotificationId { get; set; }
        public Notification Notification { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
