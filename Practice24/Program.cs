﻿// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");
// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;
// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");
// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);
// string  first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);
// string value1 = "5";
// string value2 = "7";
// int sum = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(sum);
int value1 = (int) 1.5m; // casting truncates
Console.WriteLine(value1);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);