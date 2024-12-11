class Program
{
    static void Main(string[] args)
    {

        var store = new Store();

        store.AddProduct(new Product { Name = "Laptop", Price = 1200m, Description = "High-performance laptop", Category = Category.Electronics, Rating = 4.5 });
        store.AddProduct(new Product { Name = "Headphones", Price = 200m, Description = "Noise-cancelling headphones", Category = Category.Electronics, Rating = 4.7 });
        store.AddProduct(new Product { Name = "Coffee Maker", Price = 100m, Description = "Programmable coffee maker", Category = Category.Appliances, Rating = 4.2 });
        store.AddProduct(new Product { Name = "Microwave", Price = 250m, Description = "Compact microwave oven", Category = Category.Appliances, Rating = 4.1 });
        store.AddProduct(new Product { Name = "Bed", Price = 200, Description = "A simple bed", Category = Category.Furniture, Rating = 3.8 });


        while (true)
        {
            Console.WriteLine("\n==== Product Search Interface ====");
            Console.WriteLine("1. Search by Price");
            Console.WriteLine("2. Search by Category");
            Console.WriteLine("3. Search by Rating");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter minimum price: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal minPrice))
                    {
                        Console.Write("Enter maximum price: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal maxPrice))
                        {
                            var productsByPrice = store.SearchByPrice(minPrice, maxPrice);
                            Console.WriteLine("\nProducts within price range:");
                            store.DisplayProducts(productsByPrice);
                        }
                        else
                        {
                            Console.WriteLine("Invalid maximum price.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid minimum price.");
                    }
                    break;

                case "2":
                    Console.Write("Enter category (Electronics, Appliances, Furniture): ");
                    var categoryInput = Console.ReadLine();
                    if (Enum.TryParse(categoryInput, true, out Category category))
                    {
                        var productsByCategory = store.SearchByCategory(category);
                        Console.WriteLine($"\nProducts in category '{category}':");
                        store.DisplayProducts(productsByCategory);
                    }
                    else
                    {
                        Console.WriteLine("Invalid category.");
                    }
                    break;

                case "3":
                    Console.Write("Enter minimum rating (0-5): ");
                    if (double.TryParse(Console.ReadLine(), out double minRating))
                    {
                        var productsByRating = store.SearchByRating(minRating);
                        Console.WriteLine($"\nProducts with rating >= {minRating}:");
                        store.DisplayProducts(productsByRating);
                    }
                    else
                    {
                        Console.WriteLine("Invalid rating.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Exiting search interface. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
