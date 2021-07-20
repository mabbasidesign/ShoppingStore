using ShoppingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingStore.Services
{
    public interface IOrderService
    {
        void CreateOrderByCustomer(Order oder);
        void UpdateOrderBySaller(Order oder); // Update And Edit Order By Seller
        void UpdateAndConfirmOrderBySalesManager(Order oder); // Update Order by sales manager and confirm or denay
        IEnumerable<Order> GetConfirmOrders(); // Display All Orders if they are confirm by sales manager
        IEnumerable<Order> DisplayNewOrdersToManager(); // display new orders (less than 24-h) which are confirmed to the eo
    }
}
