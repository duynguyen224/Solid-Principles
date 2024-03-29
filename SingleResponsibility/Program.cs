using SingleResponsibility.Object;

Console.WriteLine("==============================");
Console.WriteLine("");

// Violate case
//var bike = new Bike("Honda wave alpha", 90, 1000);
//var invoice = new Invoice(bike, 1, DateTime.Now);
//invoice.PrintInvoice();
//invoice.SaveInvoiceToDB();

// Fixed
var bike = new Bike("Honda wave alpha", 90, 1000);
var invoice = new Invoice(bike, 1, DateTime.Now);
var printer = new InvoicePrinter(invoice);
printer.PrintInvoice();
var dao = new InvoicePersistence(invoice);
dao.SaveInvoiceToDB();

Console.WriteLine("");
Console.WriteLine("==============================");
