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
            throw new NotImplementedException();
        }

        public void VisitInvoiceLine(InvoiceLine invoiceLine)
        {
            throw new NotImplementedException();
        }

        public void VisitProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
