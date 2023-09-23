using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace NWinMVC.Models
{
    public class RepositoryOrders
    {
        private NorthwindContext _context;
        public RepositoryOrders(NorthwindContext context)
        {
            _context = context;
        }
        
        public List<int> GetAllOrderId()

        {

            List<int> orderIds = new List<int>();

            foreach (var order in _context.Orders)

            {

                orderIds.Add(order.OrderId);

            }

            return orderIds;

        }
        public List<Order> AllOrders()
        {
            return _context.Orders.ToList();
        }
        public List<Order> ListAllOrders()
        {
            return _context.Orders.ToList();
        }
        public Order FindOrderById(int id)
        {

            Order order = _context.Orders.Find(id);
            return order;
        }
        public List<Order> GetOrderId()
        {
            List<Order> orderIds = _context.Orders
         .Select(o => new Order { OrderId = o.OrderId })
         .ToList();
            return orderIds;
        }
        public Order? FindOrderByCustomerId(int Customerid)
        {

            var order = _context.Orders.Find(Customerid);
            return order;
        }
        public Product GetProductId(int productid)
        {
            return null;
        }
        public List<OrderDetail> GetOrderDetails(int id)
        { 

            List<Order> ordersWithOrderDetails = _context.Orders.Include(o => o.OrderDetails).ToList();
            Order orders = ordersWithOrderDetails.FirstOrDefault(x => x.OrderId == id);
            return orders.OrderDetails.ToList();
        }
    }
}
