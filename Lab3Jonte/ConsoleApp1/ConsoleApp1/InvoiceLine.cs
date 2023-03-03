using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InvoiceLine
    {

        public Product product { get; set; }
        public int Quanitity { get; set; }

        public double TotalCost { get; set; }

        public InvoiceLine(Product _produt, int _quantity) 
        { 
            product = _produt;
            Quanitity = _quantity;
            TotalCost = Quanitity * _produt.UnitPrice;
        }

    }
}
