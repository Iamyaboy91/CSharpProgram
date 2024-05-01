string? readResult;
string roleName = ""; 
bool enteredName = false;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do
{
    readResult = Console.ReadLine();
    if( readResult != null )
    {
        roleName = readResult.Trim();
    }

    if(roleName.ToLower() == "administrator" || roleName.ToLower() == "manger" || roleName.ToLower() == "user")
        {
            enteredName = true;
        }else
        {
            Console.WriteLine($"The role name that you entered, \"{roleName}\" is not valid. Enter your role name (Administrator, Manager, or User)");
        }
}while(enteredName == false);
Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();
