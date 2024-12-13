using Task_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tech Product Factory Application\n");

        while (true)
        {
            Console.WriteLine("Choose a product type to create:");
            Console.WriteLine("1. Smartphone");
            Console.WriteLine("2. Laptop");
            Console.WriteLine("3. Tablet");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            ITechProductFactory factory = null;

            switch (choice)
            {
                case "1":
                    factory = new SmartphoneFactory();
                    break;
                case "2":
                    factory = new LaptopFactory();
                    break;
                case "3":
                    factory = new TabletFactory();
                    break;
                case "4":
                    Console.WriteLine("Exiting application.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            IScreen screen = factory.CreateScreen();
            IProcessor processor = factory.CreateProcessor();
            ICamera camera = factory.CreateCamera();

            Console.WriteLine("\nAssembled Product Components:");
            Console.WriteLine($"Screen: {screen.GetScreenType()}");
            Console.WriteLine($"Processor: {processor.GetProcessorType()}");
            Console.WriteLine($"Camera: {camera.GetCameraType()}\n");
        }
    }
}