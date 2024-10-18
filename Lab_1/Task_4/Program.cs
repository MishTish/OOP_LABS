//##### 4 #####

using Task_4;

bool loop1 = true;

Console.WriteLine("\n##### 4 #### \n### User ###\n");

Console.WriteLine("ACCOUNT INITIALIZATION");
Console.Write("Enter login: ");
string userLogin = Console.ReadLine();
Console.Write("Enter first name: ");
string userFirstName = Console.ReadLine();
Console.Write("Enter last name: ");
string userLastname = Console.ReadLine();

int userAge = 0;
while (loop1)
{
    try
    {
        Console.Write("Enter your age: ");
        userAge = Convert.ToInt32(Console.ReadLine());
        loop1 = false;
    }
    catch (FormatException)
    {
        Console.WriteLine("age must be an integer");
        loop1 = true;
    }
}
User someUser = new User(userLogin, userFirstName, userLastname, userAge);

Console.WriteLine("\nAccount succesfully created!\n");
Console.WriteLine("\nACCOUNT INFO:\n");
someUser.Display();


