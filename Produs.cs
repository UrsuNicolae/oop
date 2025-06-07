namespace ConsoleApp1
{
    public class Produs
    {
        public string Name;
        public decimal Price;

        public Produs(string name, decimal price)
        {
            Name = name;
            Price = price;
            
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}";
        }
    }
}
