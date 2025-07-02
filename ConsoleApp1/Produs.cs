using ConsoleApp1.GenericsRepo;

namespace ConsoleApp1
{
    public class Produs : BaseEntity<int>
    {
        public string Name;
        public decimal Price;
        private static int count = 0;

        public Produs(string name, decimal price)
        {
            Name = name;
            Price = price;
            Id = ++count;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}";
        }
    }
}
