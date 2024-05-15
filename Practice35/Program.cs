int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"\tInvoice Number: {invoiceNumber}");
Console.WriteLine($"\t\tShares: {productShares:N3} Product");
Console.WriteLine($"\t     Sub Tatal: {subtotal:C}");
Console.WriteLine($"\t\t   Tax: {taxPercentage:P2}");
Console.WriteLine($"\t  Total Billed: {total:C}");

