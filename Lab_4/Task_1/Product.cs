public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public Category Category { get; set; }
    public double Rating { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Category}: ${Price} - Rating: {Rating}/5\nDescription: {Description}";
    }
}

