using ShoppingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingStore.Services
{
    public interface INotificationService
    {
        void EmployeeNotifications(Notification notification); // Send confirm order sms to corespondent employee if position == employee using thread
        IEnumerable<Order> NotificationDateAndStatus(); // display all notifications
        void CEONotifications(Notification notification); // Send sms to ceo manages every night at 8pm
    }
}
