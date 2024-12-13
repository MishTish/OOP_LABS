using Task_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Configuration Manager Application\n");

        ConfigurationManager configManager = ConfigurationManager.Instance;

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. View all settings");
            Console.WriteLine("2. Get a specific setting");
            Console.WriteLine("3. Set a new setting");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    configManager.DisplaySettings();
                    break;
                case "2":
                    Console.Write("Enter the key: ");
                    string key = Console.ReadLine();
                    Console.WriteLine($"Value: {configManager.GetSetting(key)}");
                    break;
                case "3":
                    Console.Write("Enter the key: ");
                    string newKey = Console.ReadLine();
                    Console.Write("Enter the value: ");
                    string newValue = Console.ReadLine();
                    configManager.SetSetting(newKey, newValue);
                    Console.WriteLine("Setting updated successfully.");
                    break;
                case "4":
                    Console.WriteLine("Exiting application.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}