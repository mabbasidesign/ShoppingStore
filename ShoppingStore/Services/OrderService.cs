using ShoppingStore.Data;
using ShoppingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingStore.Services
{
    public class OrderService: IOrderService
    {
        private OrderDbContext _db;
        public OrderService(OrderDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _db.Orders.OrderBy(o => o.DateTime).ToList();
        }

        // Create order by Customer
        public void CreateOrderByCustomer(Order order)
        {
            _db.Orders.Add(order);
            _db.SaveChanges();
        }

        // Update order by seller
        public void UpdateOrderBySaller(Order order)
        {
            try
            {
                if (_db.Employees.Any(e => e.Position.Name == "Employee"))
                {
                    _db.Update(order);
                    _db.SaveChanges();
                }
            }
            catch (InvalidCastException e)
            {
                throw new InvalidCastException("Only Employees can Edit this order", e);
            }
        }

        // Confirm order by sales manager
        public bool UpdateAndConfirmOrderBySalesManager(Order order)
        {
            try
            {
                if (_db.Employees.Any(e => e.Position.Name == "Sales Manager"))
                {
                    _db.Update(order);
                    _db.SaveChanges();
                }
            }
            catch (InvalidCastException e)
            {
                throw new InvalidCastException("Only Sales Manager can Edit this order", e);
            }

            return _db.Orders.Any(o => o.IsConfirmBySalesManger == true) ? true : false;

        }

        // Display All Orders if they are confirm by sales manager
        public bool GetConfirmOrders()
        {
            var isConfirmed = _db.Orders.Any(o => o.IsConfirmBySalesManger == true);

            if (isConfirmed)
            {
                GetOrders();
                return true;
            }
            else
            {
                return false;
            }
        }

        // display new orders (less than 24-h) that are confirmed
        public IEnumerable<Order> DisplayNewOrdersToManager()
        {
            var now = DateTime.Now;

            return _db.Orders.Where(o => (now - o.DateTime).TotalHours < 24)
                .OrderByDescending(o => o.DateTime);
        }

    }
}
