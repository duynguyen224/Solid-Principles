using SingleResponsibility.Object;

Console.WriteLine("==============================");
Console.WriteLine("");

var book = new Bike("Honda wave alpha", 90, 100);
var invoice = new Invoice(book, 5, DateTime.Now);
var printer = new InvoicePrinter(invoice);
printer.PrintInvoice();
var dao = new InvoicePersistence(invoice);
dao.SaveInvoiceToDB();

Console.WriteLine("");
Console.WriteLine("==============================");
