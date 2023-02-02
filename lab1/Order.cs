using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Order
    {
        public Product OrderedProduct { get; set; }
        public string State { get; set; }

        public Order(Product product)
        {
            OrderedProduct = product;
            State = "Ordered";
        }
    }
}