using DependencyInversion.Interface.Implement;
using DependencyInversion.Object;

Console.WriteLine("==============================");
Console.WriteLine("");

// 
var bike = new Bike("Honda wave alpha", 90, 1000);

// Violate
var invoice = new Invoice(bike, 5);
invoice.PrintInvoice();
invoice.SaveInvoiceToDB();
invoice.Pay();

// Fix
//var paymentService = new BankingService();
//var invoice = new Invoice(bike, 5, paymentService);
//invoice.PrintInvoice();
//invoice.SaveInvoiceToDB();
//invoice.Pay();

Console.WriteLine("");
Console.WriteLine("==============================");
