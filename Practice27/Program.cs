﻿// string[] values ={"12.3", "45", "ABC", "11","DEF"};
// decimal Total = 0m;
// string message = "";

// foreach (var value in values)
// {   
//     decimal num;
//     if(decimal.TryParse(value, out num))
//     {
//         Total += num;
        
//     }else 
//     {
//         message += value;
//     }

// }
// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {Total}");


int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = 0;
result1 = value1 / (Convert.ToInt32(value2));
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");


// Your code here to set result2
decimal result2 = 0m;
result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = 0.0f;
result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");