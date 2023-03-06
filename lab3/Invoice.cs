namespace lab3
{
    internal class Invoice : IElement
    {
        public InvoiceList InvoiceList { get; set; }
        public int CustomerNumber { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime PaymentBy { get; set; }

        public Invoice(InvoiceList invoiceList, int customerNumber, int invoiceNumber)
        {
            InvoiceList = invoiceList;
            CustomerNumber = customerNumber;
            InvoiceNumber = invoiceNumber;
            InvoiceDate = DateTime.Now;
            PaymentBy = InvoiceDate.AddMonths(1);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);






        }
    }
}