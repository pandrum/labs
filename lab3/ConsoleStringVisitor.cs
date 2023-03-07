namespace lab3
{
    internal class ConsoleStringVisitor : IVisitor
    {
        public void Visit(Invoice invoice)
        {
            Console.WriteLine("{0, -30} {1, 5}", "Invoice", $"Date: {invoice.InvoiceDate}");
            Console.WriteLine();

            Console.WriteLine($"Customer number: {invoice.CustomerNumber}");
            Console.WriteLine($"Invoice number: {invoice.InvoiceNumber}");
            Console.WriteLine($"Payment by: {invoice.PaymentBy}");
            Console.WriteLine();
            Console.WriteLine($"Pre-tax total: {invoice.PreTax}$");
            Console.WriteLine($"Tax(10%): {invoice.Tax}$");
            Console.WriteLine($"Total: {invoice.TotalPrice}$");
            Console.WriteLine();
            Console.WriteLine("{0, -10} {1, -35} {2, 10} {3,10} ", "Qty", "Product", "Unit Price", "Total");
        }

        public void Visit(InvoiceLine invoiceLine)
        {
            Console.WriteLine("{0, -10} {1, -35} {2, 10} {3,10}", $"{invoiceLine.Quantity}", $"{invoiceLine.Product.Name}", $"{invoiceLine.Product.UnitPrice}$", $"{invoiceLine.Product.UnitPrice * invoiceLine.Quantity}$");
        }

        public void Visit(Product product)
        {
            Console.WriteLine($"Product name is {product.Name} and cost {product.UnitPrice}$ per item.");
        }
    }
}