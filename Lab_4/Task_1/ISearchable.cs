public interface ISearchable
{
    List<Product> SearchByPrice(decimal minPrice, decimal maxPrice);
    List<Product> SearchByCategory(Category category);
    List<Product> SearchByRating(double minRating);
}