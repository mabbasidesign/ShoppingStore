using ShoppingStore.Data;
using ShoppingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingStore.Services
{
    public class NotificationService : INotificationService
    {
        private OrderDbContext _db;
        public NotificationService(OrderDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Notification> NotificationDateAndStatus()
        {
            return _db.Notifications.OrderBy(n => n.DateTime).ToList();
        }

        public bool EmployeeNotifications(Notification notification, int EmployeeId)
        {
            var employee = _db.Employees.Any(n => n.EmployeeId == EmployeeId);
            var employeePosition = _db.Employees.Any(e => e.Position.Name == "CEO");

            var now = DateTime.Now;
            var timing = _db.Orders.Any(o => (now - o.DateTime).TotalSeconds < 5);

            if (timing)
            {
                if (employee && employeePosition)
                {
                    _db.Notifications.AddRange(notification);
                    _db.SaveChanges();
                }
            }

            return false;
        }

        public bool CEONotifications(Notification notification, int EmployeeId)
        {
            throw new NotImplementedException();
        }

    }
}
