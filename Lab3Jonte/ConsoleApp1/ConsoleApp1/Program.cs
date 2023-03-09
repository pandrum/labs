// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

//InvoiceLine invoiceLine= new InvoiceLine();

//List<InvoiceLine> invoiceLineList = new List<InvoiceLine>();   

Invoice Invoice = new Invoice( new List<InvoiceLine> { new InvoiceLine(new Product("Mythical Man Month", 1, 10), 1) }, 1, 1, DateTime.UtcNow.Date.AddDays(2));
//ConsolePrintOut consolePrint = new ConsolePrintOut();
//consolePrint.VisitInvoice(Invoice);
//Invoice.Accept(consolePrint);
Invoice.Accept(new ConsolePrintOut());
Invoice.Accept(new XmlExport());


//vi skapar en invoice med tillhörande lista som består av en invoice line och en product