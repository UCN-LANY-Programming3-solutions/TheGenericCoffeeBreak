using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Orderline
    {
        public int Quantity { get; set; }
        public Product Product { get; }

        public Orderline(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }
    }
}
