using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IVisitor1
    {

        //public Visit(Invoice invoice);
        //skica in elementet som print
        void VisitInvoice(Invoice invoice);
        void VisitInvoiceLine(InvoiceLine invoiceLine);

        void VisitProduct(Product product);

    }
}
