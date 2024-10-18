
// ##### 3 #####

using Task_3;

string firstName;
string lastName;
bool loop1;
bool loop2;
bool loop3 = true;
string selector;


Console.WriteLine("\n##### 3 #### \n# Employee #\n");

Console.WriteLine("EMPLOYEE INITIALIZATION");
Console.Write("Enter first name: ");
firstName = Console.ReadLine();
Console.Write("Enter last name: ");
lastName = Console.ReadLine();
Employee someEmployee = new Employee(firstName, lastName);

loop1 = true;
while (loop1)
{
    loop2 = true;
    Console.WriteLine($"\nCurrent employee: {someEmployee.LastName} {someEmployee.FirstName}\n");
    Console.WriteLine("1. Show details");
    Console.WriteLine("2. Change details");
    Console.WriteLine("3. EXIT");
    selector = Console.ReadLine();
    switch (selector)
    {
        case "1":
            {
                someEmployee.Display();
                Console.WriteLine("\n(Press any key to return...)");
                Console.ReadKey();
                break;

            }

        case "2":
            {
                while (loop2)
                {
                    Console.WriteLine($"\nEditing employee: {someEmployee.LastName} {someEmployee.FirstName}\n");

                    Console.WriteLine("1. Change name");
                    Console.WriteLine("2. Change position");
                    Console.WriteLine("3. Change time employed");
                    Console.WriteLine("4. EXIT editor");
                    selector = Console.ReadLine();
                    switch (selector)
                    {
                        case "1":
                            Console.Write("Enter NEW first name: ");
                            string newFirstName = Console.ReadLine();
                            someEmployee.FirstName = newFirstName;
                            Console.WriteLine($"First name is now {someEmployee.FirstName}");
                            Console.Write("Enter NEW last name: ");
                            string newLastname = Console.ReadLine();
                            someEmployee.LastName = newLastname;
                            Console.WriteLine($"Last name is now {someEmployee.LastName}");
                            break;
                        case "2":
                            while (loop3)
                            {
                                Console.WriteLine("New Position: \n");
                                Console.WriteLine("1. Technician");
                                Console.WriteLine("2. Team lead");
                                Console.WriteLine("3. Manager");
                                selector = Console.ReadLine();
                                if (selector == "1")
                                {
                                    someEmployee.Position = "Technician";
                                    loop3 = false;
                                    break;
                                }
                                else if (selector == "2")
                                {
                                    someEmployee.Position = "Team lead";
                                    loop3 = false;
                                    break;
                                }
                                else if (selector == "3")
                                {
                                    someEmployee.Position = "Manager";
                                    Console.WriteLine("");
                                    loop3 = false;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("ERROR: incorrect input");
                                    loop3 = true;
                                }
                            }
                            Console.WriteLine($"New position is now {someEmployee.Position}");
                            break;
                        case "3":
                            try
                            {
                                Console.Write("Enter NEW time employed (in months): ");
                                int newEmployedMonths = Convert.ToInt32(Console.ReadLine());
                                someEmployee.EmployedMonths = newEmployedMonths;
                                Console.WriteLine($"Time empoloyed is now {someEmployee.EmployedMonths} months");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("ERROR: incorrect input");
                            }

                            break;

                        case "4":
                            loop2 = false;
                            break;
                        default:
                            Console.WriteLine("ERROR: incorrect input");
                            break;
                    }
                }
                break;
            }

        case "3":
            {
                loop1 = false;
                break;
            }

        default:
            Console.WriteLine("ERROR: incorrect input");
            break;
    }
}
