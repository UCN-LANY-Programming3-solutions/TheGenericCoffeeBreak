using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MemoryDaos
{
    internal class ProductDao : IDao<Product>
    {
        private IList<Product> _products = new List<Product>();

        private void Init()
        {
            Product product1 = new(1, "Coffee", 39.95m);
            Product product2 = new(2, "Cafe Latte", 41.50m);
            Product product3 = new(3, "Choco", 39.95m);
            Product product4 = new(4, "Chai", 49.95m);
            Product product5 = new(5, "Espresso", 25.00m);

            _products.Add(product1);
            _products.Add(product2);
            _products.Add(product3);
            _products.Add(product4);
            _products.Add(product5);
        }

        public ProductDao()
        {
            Init();
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product? GetById(int id)
        {
            return _products.SingleOrDefault(p => p.Id == id);
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
