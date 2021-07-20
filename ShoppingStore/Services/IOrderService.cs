using ShoppingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingStore.Services
{
    public interface IOrderService
    {
        IEnumerable<Order> GetOrders();
        void CreateOrderByCustomer(Order order); // Create order by customer
        void UpdateOrderBySaller(Order order); // Update And Edit Order By Seller
        bool UpdateAndConfirmOrderBySalesManager(Order order); // Update Order by sales manager and confirm or denay
        bool GetConfirmOrders(); // Display All Orders if they are confirm by sales manager
        IEnumerable<Order> DisplayNewOrdersToManager(); // display new orders (less than 24-h) which are confirmed to the eo
    }
}
