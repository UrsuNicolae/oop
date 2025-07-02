using ConsoleApp1.GenericsRepo;

namespace ConsoleApp1.Linq
{
    public class Order : BaseEntity<int>
    {
        public string Product { get; set; }
        public double Price{ get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"OrderID: {Id}, Product: {Product}, Price: {Price}";
        }
    }

    public class OrderTotal
    {
        public double TotalSum { get; set; }
        public int TotalQuantity { get; set; }

        public string Product { get; set; }
    }
}
