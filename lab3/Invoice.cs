namespace lab3
{
    internal class Invoice : IElement
    {
        public List<InvoiceLine> InvoiceLine { get; set; }
        public int CustomerNumber { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime PaymentBy { get; set; }

        public double PreTax { get; set; }
        public double Tax { get; set; }
        public double TotalPrice { get; set; }

        public Invoice(List<InvoiceLine> invoiceList, int customerNumber, int invoiceNumber)
        {
            InvoiceLine = invoiceList;
            CustomerNumber = customerNumber;
            InvoiceNumber = invoiceNumber;

            InvoiceDate = DateTime.Now;
            PaymentBy = InvoiceDate.AddMonths(1);

            InvoiceLine.ForEach(invoiceLine => PreTax += invoiceLine.Product.UnitPrice * invoiceLine.Quantity);
            Tax = Math.Ceiling(PreTax * 0.1);
            TotalPrice = Math.Ceiling(Tax + PreTax);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}