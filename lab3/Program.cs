using lab3;

//init products, invoicelines and invoice
Product p = new Product("Mythical Man-Month", 45);
Product p2 = new Product("Ream of paper (500)", 5);
Product p3 = new Product("Standart Fruit Laptop", 2000);

List<InvoiceLine> invoiceLines = new List<InvoiceLine>()
{
    new InvoiceLine(p),
    new InvoiceLine(p2, 4),
    new InvoiceLine(p3),
};

Invoice invoice = new Invoice(invoiceLines, 5678, 1234);

//init visitors
var visitor = new ConsoleStringVisitor();
var visitor2 = new XmlExportVisitor();

//visiting the invoice types from ConsoleStringVisitor
invoice.Accept(visitor);
invoiceLines.ForEach(invoiceLine => invoiceLine.Accept(visitor));
p.Accept(visitor);
p2.Accept(visitor);
p3.Accept(visitor);

Console.WriteLine();

//visiting the invoice types from XmlExportVisitor
invoice.Accept(visitor2);
invoiceLines.ForEach(invoiceLine => invoiceLine.Accept(visitor2));
p.Accept(visitor2);
p2.Accept(visitor2);
p3.Accept(visitor2);