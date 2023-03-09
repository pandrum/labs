using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class XmlExport : IVisitor1
    {
        public void VisitInvoice(Invoice invoice)
        {
            Console.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?");
            Console.WriteLine("<invoiceDate=\"" + invoice.Date + "\">");
            Console.WriteLine("<customerNumber>" + invoice.CustomerNumber + "</customerNumber>");
            Console.WriteLine("<invoiceNumber=\"" + invoice.InvoiceNumber + "</invoiceNumber>");
            Console.WriteLine("<paymentBy=\"" + invoice.DueDate + "</paymentBy>");



            throw new NotImplementedException();
        }

        public void VisitInvoiceLine(InvoiceLine invoiceLine)
        {
            Console.WriteLine("<line qty=$ productTitle= \""+ invoiceLine.product.ProductTitle + invoice.Date + "\">");

            throw new NotImplementedException();
        }

        public void VisitProduct(Product product)
        {
            Console.WriteLine("Tets");
            throw new NotImplementedException();
        }
    }
}
