string[] names = {"Fizz", "Buzz"};
for (int i = 1; i <= 100; i++)
{   

    if((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine($"{i} - {names[0]}{names[1]}");
    }
    else if ( i % 3 == 0 )
    {
        Console.WriteLine($"{i} - {names[0]}");
    }
    else if ( i % 5 == 0 )
    {
        Console.WriteLine($"{i} - {names[1]}");
    }
    else 
    {
        Console.WriteLine($"{i}");
    }

}
