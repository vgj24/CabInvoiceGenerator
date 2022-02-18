// See https://aka.ms/new-console-template for more information
using CabInvoiceGenerator;

Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to Cab Invoice Generator");
InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
double fare = invoiceGenerator.CalculateFare(2.0, 5);
InvoiceGenerator invgenrator =new InvoiceGenerator(RideType.PREMIUM);
double farepremium =invgenrator.CalculateFare(2.0,20);
Console.WriteLine("fare for normal ride");
Console.WriteLine($"Fare : {fare}");
Console.WriteLine("fare for premiumride");
Console.WriteLine($"Fare : {farepremium}");
Console.ReadLine();
