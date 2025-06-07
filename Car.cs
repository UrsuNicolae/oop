namespace ConsoleApp1
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public uint Year { get; set; }
    }

    public class Car : Vehicle, IMovable
    {
        public uint NrOfDors { get; set; }

        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class Truck : Vehicle, IMovable
    {
        public uint CargoCapacity { get; set; }

        public void Move()
        {
            Console.WriteLine("Truck is moving");
        }
    }
}
