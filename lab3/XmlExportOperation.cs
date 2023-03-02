namespace lab3
{
    internal class XmlExportOperation : IVisitor
    {
        public void Visit(IElement element)
        {
            Invoice invoice = (Invoice)element;

            Console.WriteLine($"<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            Console.WriteLine($"<invoice date={invoice.InvoiceDate}>");
            Console.WriteLine($"<customerNumber>5678</customerNumber>");
            Console.WriteLine($"<invoiceNumber>1234</invoiceNumber>");
            Console.WriteLine($"<paymentBy>2023-02-05</paymentBy>");
            Console.WriteLine("<lines>");

            foreach (var item in invoice.InvoiceList.Products)
            {
                Console.WriteLine($"\t<line qty={item.Quantity} productTitle={item.Name} unitPrice={item.Price}$ total={item.Total}$/>");
            }
            Console.WriteLine("</lines>");
            Console.WriteLine($"<total pre-tax=\"2065$\" tax=\"207$\" total=\"2272$\"/>");
            Console.WriteLine("</invoice>");
        }
    }
}