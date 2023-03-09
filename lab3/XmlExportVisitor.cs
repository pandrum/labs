namespace lab3
{
    internal class XmlExportVisitor : IVisitor
    {
        public void Visit(Invoice invoice)
        {
            Console.WriteLine($"<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            Console.WriteLine($"<invoice date={invoice.InvoiceDate}>");
            Console.WriteLine($"<customerNumber>{invoice.InvoiceDate}</customerNumber>");
            Console.WriteLine($"<invoiceNumber>{invoice.InvoiceNumber}</invoiceNumber>");
            Console.WriteLine($"<paymentBy>{invoice.PaymentBy}</paymentBy>");
            Console.WriteLine($"<total pre-tax={invoice.PreTax}$ tax={invoice.Tax}$ total={invoice.TotalPrice}$/>");
            Console.WriteLine();
        }

        public void Visit(InvoiceLine invoiceLine)
        {
            Console.WriteLine($"\t<line qty=1 productTitle={invoiceLine.Product.Name}$ unitPrice={invoiceLine.Product.UnitPrice}$ total={invoiceLine.Product.UnitPrice * invoiceLine.Quantity}$/>");
        }

        public void Visit(Product product)
        {
            Console.WriteLine($"<product>");
            Console.WriteLine($"\t<name>{product.Name}</name>");
            Console.WriteLine($"\t<unitPrice>{product.UnitPrice}</unitPrice>");
            Console.WriteLine($"</product>");
        }
    }
}