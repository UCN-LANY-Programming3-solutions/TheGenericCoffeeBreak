using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDao
    {
        private int _currentId = 3;

        private IList<Order> _orders = new List<Order>();

        private void Init()
        {
            Product product1 = new(1, "Coffee", 39.95m);
            Product product2 = new(2, "Cafe Latte", 41.50m);
            Product product3 = new(3, "Choco", 39.95m);
            Product product4 = new(4, "Chai", 49.95m);
            Product product5 = new(5, "Espresso", 25.00m);

            Order order1 = new(1, "Hans");
            order1.Orderlines.Add(new Orderline(1, product1));
            order1.Orderlines.Add(new Orderline(1, product2));

            Order order2 = new(2, "Kurt");
            order2.Orderlines.Add(new Orderline(1, product3));
            order2.Orderlines.Add(new Orderline(2, product4));
            order2.Orderlines.Add(new Orderline(1, product5));

            Order order3 = new(3, "Else");
            order3.Orderlines.Add(new Orderline(2, product1));

            _orders.Add(order1);
            _orders.Add(order2);    
            _orders.Add(order3);
        }

        public OrderDao()
        {
            Init();
        }

        public IEnumerable<Order> GetAll()
        {
            return _orders;
        }

        public Order? GetById(int id)
        {
            return _orders.SingleOrDefault(o => o.Id == id);
        }

        public void Create(Order order)
        {
            _orders.Add(new Order(++_currentId, order.Customer));
        }

        public void Update(Order order)
        {
            Order? old = _orders.SingleOrDefault(o => o.Id == order.Id);
            if (old != null)
            {
                old.Orderlines.Clear();
                foreach (var orderline in order.Orderlines)
                {
                    old.Orderlines.Add(orderline);
                }                
            }
        }

        public void Delete(Order order)
        {
            Order? old = _orders.SingleOrDefault(o => o.Id == order.Id);
            if (old != null)
            {
                _orders.Remove(old);
            }
        }
    }
}
