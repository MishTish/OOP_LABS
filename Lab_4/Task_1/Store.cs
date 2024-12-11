public class Store : ISearchable
{
    private List<Product> products = new List<Product>();
    private List<User> users = new List<User>();
    private List<Order> orders = new List<Order>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public void RemoveProduct(Product product)
    {
        products.Remove(product);
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void RemoveUser(User user) 
    {
        users.Remove(user);
    }

    public void PlaceOrder(User user, Order order)
    {
        orders.Add(order);
        user.AddToPurchaseHistory(order);
    }


    public List<Product> SearchByPrice(decimal minPrice, decimal maxPrice)
    {
        return products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
    }

    public List<Product> SearchByCategory(Category category)
    {
        return products.Where(p => p.Category == category).ToList();
    }

    public List<Product> SearchByRating(double minRating)
    {
        return products.Where(p => p.Rating >= minRating).ToList();
    }


    public void DisplayProducts(List<Product> products)
    {
        foreach (var product in products)
        {
            Console.WriteLine(product);
            Console.WriteLine();
        }
    }
}