public class User
{
    public string Login { get; set; }
    public string Password { get; set; }
    public List<Order> PurchaseHistory { get; private set; } = new List<Order>();

    public void AddToPurchaseHistory(Order order)
    {
        PurchaseHistory.Add(order);
    }
}