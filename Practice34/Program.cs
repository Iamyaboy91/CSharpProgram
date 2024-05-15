//複合書式設定
// Console.WriteLine("{0} {1}", first, second) 
//文字列補間 
// Console.WriteLine($"{first} {second}");
// 通常は文字列補間
decimal price1 = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price1:C} (Save{discount:C})");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

decimal price2 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2 - salePrice), price2);
Console.WriteLine(yourDiscount);

yourDiscount += $"A discount of {((price2 - salePrice)/price2):P2}!"; //inserted
Console.WriteLine(yourDiscount);