namespace ConsoleApp1.Deletegates
{
    public class Product
    {
        public Product(string name, string category, double price)
        {
            Name = name;
            Category = category;
            Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Category: {Category}";
        }
    }
    public class ProductDelegates
    {
        public delegate bool ProductFilter(Product product);

        public static bool IsCheap(Product product) => product.Price < 100;
        public static bool IsElectronic(Product product) => product.Category == "Electronics";

        public static List<Product> Filter(List<Product> products, ProductFilter filter)
        {
            return products.Where(p => filter(p)).ToList();
        }
    }
}
