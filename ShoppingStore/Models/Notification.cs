using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingStore.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Description { get; set; }

        [Required]
        public DateTime DateTime { get; set; }
        public int Duration { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
