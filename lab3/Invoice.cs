using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Invoice : IElement
    {
        public DateTime InvoiceDate { get; set; } = DateTime.Now;
        public DateTime PaymentBy { get; set; }
        public int CustomerNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public InvoiceList InvoiceList { get; set; }

        public Invoice(InvoiceList invoiceList)
        {
            InvoiceList= invoiceList;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}