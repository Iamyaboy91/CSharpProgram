string? roleName;
string enteredName = "";
bool validName = false;
do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    roleName = Console.ReadLine();
    if (roleName != null)
    {
        enteredName = roleName.Trim();
    }
    if(enteredName.ToLower() == "administrator" || enteredName.ToLower() == "manager" || enteredName.ToLower() == "user")
    {
        validName = true;
    }
    else
    {
    Console.WriteLine($"The role name that you entered \"{enteredName}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }
}while(validName == false);
Console.WriteLine($"Your input value ({enteredName}) has been accepted.");
roleName = Console.ReadLine();