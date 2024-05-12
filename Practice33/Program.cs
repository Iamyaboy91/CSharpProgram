string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] splitOrder = orderStream.Split(',');
Array.Sort(splitOrder);

foreach (string item in splitOrder)
{
    if(item.Length == 4)
    {
        Console.WriteLine($"{item}");
    }else if(item.Length >= 4 || item.Length <= 4)
    {
        Console.WriteLine($"{item} \t-Error");
    }
}