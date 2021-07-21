using ShoppingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingStore.Services
{
    public interface INotificationService
    {
        bool EmployeeNotifications(Notification notification, int EmployeeId); // Send confirm order sms to corespondent employee if position == employee using thread
        IEnumerable<Notification> NotificationDateAndStatus(); // display all notifications
        bool CEONotifications(Notification notification, int EmployeeId); // Send sms to ceo manages every night at 8pm
    }
}
