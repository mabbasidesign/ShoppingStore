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
        void CreateOrderByCustomer(Order order); 
        void UpdateOrderBySaller(Order order);
        bool UpdateAndConfirmOrderBySalesManager(Order order);
        bool GetConfirmOrders();
        IEnumerable<Order> DisplayNewOrdersToManager();
    }
}
