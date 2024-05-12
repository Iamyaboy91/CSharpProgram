string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] splitOrder = orderStream.Split(',');
Array.Sort(splitOrder);
string[] newOrderStream = new string [splitOrder.Length];


for (int i = 0; i < splitOrder.Length; ++i)
{
            newOrderStream[i] = new string(splitOrder[i]);
    do{

        if(newOrderStream[i].Length == 4)
        {
            Console.WriteLine($"{newOrderStream[i]}");
            
        }else if(newOrderStream[i].Length <= 4) 
        {
            Console.WriteLine($"{newOrderStream[i]} \t- Error");
        }else if(newOrderStream[i].Length >= 4)
        {
            Console.WriteLine($"{newOrderStream[i]} \t- Error");
        }
    }while(newOrderStream[i].Length == splitOrder.Length);
    
}
