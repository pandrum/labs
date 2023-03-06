namespace lab3
{
    internal class XmlExportOperation : IVisitor
    {
        public void Visit(IElement element)
        {
            Invoice invoice = (Invoice)element;
            double total = 0;


            Console.WriteLine($"<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            Console.WriteLine($"<invoice date={invoice.InvoiceDate}>");
            Console.WriteLine($"<customerNumber>{invoice.InvoiceDate}</customerNumber>");
            Console.WriteLine($"<invoiceNumber>{invoice.InvoiceNumber}</invoiceNumber>");
            Console.WriteLine($"<paymentBy>{invoice.PaymentBy}</paymentBy>");
            Console.WriteLine("<lines>");

            foreach (var item in invoice.InvoiceList.Products)
            {
                Console.WriteLine($"\t<line qty={item.Quantity} productTitle={item.Name} unitPrice={item.Price}$ total={item.Total}$/>");
                total += item.Total;
            }
            Console.WriteLine("</lines>");
            Console.WriteLine($"<total pre-tax=\"{total}$\" tax=\"{Math.Ceiling((total * Product.Tax))}$\" total=\"{Math.Ceiling(total + (total * Product.Tax))}$\"/>");
            Console.WriteLine("</invoice>");
        }
    }
}