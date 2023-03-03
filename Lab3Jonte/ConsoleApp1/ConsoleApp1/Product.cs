using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {

        public string ProductTitle { get; set; }    
        
        public int ProductId { get; set; }

        public double UnitPrice { get; set; }



        public void Accept(IVisitor1 ConsolePrintOut) //hela dens jobb är att kalla på console Print klassen
        {
            ConsolePrintOut.VisitProduct(this);
        }


        public Product(string _productTitle, int _productId, int _unitPrice)
        {
            ProductTitle= _productTitle;
            ProductId= _productId;
            UnitPrice= _unitPrice;
        }

    }
}
