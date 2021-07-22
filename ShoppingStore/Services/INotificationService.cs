using ShoppingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingStore.Services
{
    public interface INotificationService
    {
        bool EmployeeNotifications(Notification notification, int EmployeeId);
        IEnumerable<Notification> NotificationDateAndStatus();
        bool CEONotifications(Notification notification, int EmployeeId);
    }
}
