using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Invoice
    {

        public List<InvoiceLine> InvoiceLines;

        public int InvoiceNumber { get; set; }
        public int CustomerNumber { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }

        public double Tax { get; set; }
        public double PreTax { get; set; }

        public double Total { get; set; }


        public Invoice(List<InvoiceLine> invoiceLineList, int _invoiceNumber, int _customerNumber, DateTime _dueDate)
        {
            InvoiceLines = invoiceLineList;
            InvoiceNumber = _invoiceNumber;
            CustomerNumber = _customerNumber;
            DueDate = _dueDate;

            Date = DateTime.UtcNow.Date;
            Tax = 0.1;
            foreach(InvoiceLine IL in invoiceLineList)
            {
                PreTax += IL.TotalCost; //sätter pretax till alla kostnader för all invoiceLines
            }

            Total = PreTax * 1.1;       
        
        }

        





    }
}
