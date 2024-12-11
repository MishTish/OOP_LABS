public class Order
{
    public List<(Product Product, int Quantity)> Products { get; private set; } = new List<(Product, int)>();
    public decimal TotalCost => Products.Sum(p => p.Product.Price * p.Quantity);
    public string Status { get; set; } = "Pending";

    public void AddProduct(Product product, int quantity)
    {
        Products.Add((product, quantity));
    }

    public override string ToString()
    {
        var productList = string.Join("\n", Products.Select(p => $"{p.Product.Name} x{p.Quantity} (${p.Product.Price * p.Quantity})"));
        return $"Order Status: {Status}\nTotal Cost: ${TotalCost}\nProducts:\n{productList}";
    }
}