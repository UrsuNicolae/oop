namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("WV", "Passat", 2000, 0);
            Console.WriteLine(car.GetAge);
        }

    }
}
