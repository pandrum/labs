using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class ConsoleStringOperation : IVisitor
    {
        public void Visit(IElement element)
        {
            Invoice invoice = (Invoice)element;

            Console.WriteLine("{0, -30} {1, 5}", "Invoice", $"Date: {invoice.InvoiceDate}");
            Console.WriteLine();

            Console.WriteLine("Customer number: ");
            Console.WriteLine("Invoice number: ");
            Console.WriteLine("Payment by: ");
            Console.WriteLine();

            Console.WriteLine("{0, -10} {1, -35} {2, 10} {3,10} ", "Qty", "Product", "Unit Price", "Total");

            double total = 0;
            double tax = 0.1;
            foreach (var item in invoice.InvoiceList.Products)
            {
                Console.WriteLine("{0, -10} {1, -35} {2, 10} {3,10} ", $"{item.Quantity}", $"{item.Name}", $"{item.Price}$", $"{item.Total}$");
                total += item.Total;
            }
            Console.WriteLine();
            Console.WriteLine("{0, 60}", $"Pre-tax total: {total}$");
            Console.WriteLine("{0, 60}", $"Tax(10%): {Math.Ceiling((total * tax))}$");
            Console.WriteLine("{0, 60}", $"Total: {Math.Ceiling(total + (total * tax))}$");
        }
    }
}