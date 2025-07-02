namespace ConsoleApp1.DesignPatterns
{
    // Clasa Product: Mașina
    public class Car
    {
        public string Engine { get; set; }
        public string Wheels { get; set; }
        public string Color { get; set; }

        public void ShowCarDetails()
        {
            Console.WriteLine($"Engine: {Engine}, Wheels: {Wheels}, Color: {Color}");
        }
    }

    // Builder abstract
    public abstract class CarBuilder
    {
        protected Car _car = new Car();

        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildColor();

        public Car GetCar() => _car;
    }

    // Builder concret pentru mașini sport
    public class SportsCarBuilder : CarBuilder
    {
        public override void BuildEngine() => _car.Engine = "V8 Engine";
        public override void BuildWheels() => _car.Wheels = "Sport Wheels";
        public override void BuildColor() => _car.Color = "Red";
    }

    // Builder concret pentru mașini economice
    public class EconomyCarBuilder : CarBuilder
    {
        public override void BuildEngine() => _car.Engine = "V4 Engine";
        public override void BuildWheels() => _car.Wheels = "Economy Wheels";
        public override void BuildColor() => _car.Color = "Blue";
    }

    // Directorul care controlează construirea mașinii
    public class CarDirector
    {
        private readonly CarBuilder _carBuilder;

        public CarDirector(CarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public Car Construct()
        {
            _carBuilder.BuildEngine();
            _carBuilder.BuildWheels();
            _carBuilder.BuildColor();
            return _carBuilder.GetCar();
        }
    }   

}
