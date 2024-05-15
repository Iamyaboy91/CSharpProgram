string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine("Here's a quick comparison:\n");
string comparisonMessage = @"Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own {currentShares:N2} shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be ¤63,000,000.00.";

Console.WriteLine($"{currentProduct.PadRight(20)} {currentReturn:P2}\t {currentProfit:C2}");
Console.WriteLine($"{newProduct.PadRight(20)} {newReturn:P2}\t {newProfit:C2}");

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P2}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C2}", currentProfit);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P2}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C2}", newProfit).PadRight(20);


// Your logic here[]
Console.WriteLine(comparisonMessage);