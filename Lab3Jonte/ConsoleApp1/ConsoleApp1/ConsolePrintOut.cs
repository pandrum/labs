using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ConsolePrintOut : IVisitor1
    {
        public void VisitInvoice(Invoice invoice)
        {

            Console.WriteLine("Invoice Number: " + invoice.InvoiceNumber);
            Console.WriteLine("Customer Number: " + invoice.CustomerNumber);
            Console.WriteLine("Date: " + invoice.Date);
            Console.WriteLine("DueDate: " + invoice.DueDate);
            Console.WriteLine("Pre-Tax: " + invoice.PreTax);
            Console.WriteLine("Tax: " + invoice.Tax);
            Console.WriteLine("Total: " + invoice.Total);






        }

        public void VisitInvoiceLine(InvoiceLine invoiceLine)
        {
            Console.WriteLine("Quantity: " + invoiceLine.Quanitity);
            Console.WriteLine("Total price: " + invoiceLine.TotalCost);


        }

        public void VisitProduct(Product product)
        {
            //samma som print
           Console.WriteLine("Product Name: " + product.ProductTitle);
           Console.WriteLine("Product Id: " + product.ProductId);




        }
    }
}
