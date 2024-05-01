string? readResult;
string valueEntered = "";
bool validNunmber = false;
int numValue = 0;

Console.WriteLine("Enter an integer value between 5 and 10");

do{
    readResult = Console.ReadLine();

if (readResult != null)
{
    valueEntered = readResult;
}

validNunmber = int.TryParse(valueEntered, out numValue);

    if (validNunmber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
        validNunmber = false;
        Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
}while(validNunmber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();