using DataAccess.MemoryDaos;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DaoFactory
    {
        public static IDao<Order> CreateOrderDao()
        {
            return new OrderDao();
        }

        public static IDao<Product> CreateProductDao()
        {
            return new ProductDao();
        }
    }
}
