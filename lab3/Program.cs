using lab3;

var product = new Product("Mythical Man-Month", 45);
var product2 = new Product("Ream of paper (500)", 5, 4);
var product3 = new Product("Standart Fruit Laptop", 2000);
var invoiceList = new InvoiceList();
var invoice = new Invoice(invoiceList);

invoiceList.Products.Add(product);
invoiceList.Products.Add(product2);
invoiceList.Products.Add(product3);

invoice.InvoiceList= invoiceList;

var visitor = new ConsoleStringOperation();
invoice.Accept(visitor);