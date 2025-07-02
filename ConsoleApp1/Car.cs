namespace ConsoleApp1
{
    public class Vehicle
    {
        public Vehicle()
        {
            
        }
        public Vehicle(string make, string model, uint year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public string Make { get; init; }
        public string Model { get; init; }
        public uint Year { get; init; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Display general info about car");
        }
    }

    public class Car : Vehicle, IMovable
    {
        private int speed;
        public Car(string make, string model, uint year, int speed) : base(make, model, year)
        {
            this.speed = speed;
        }

        public Car(Car car): base(car.Make, car.Model, car.Year)
        {
            speed = car.speed;
        }

        ~Car()
        {
            Console.WriteLine("Free memory from destructor!");
        }

        public uint NrOfDors { get; set; }

        public void Move()
        {
            Console.WriteLine("Car is moving");
        }

        public int Speed
        {
            get => speed;
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException($"Invalid value for speed: {value}");
                }
            }
        }

        public string GetAge
        {
            get
            {
                var age = DateTime.UtcNow.Year - Year;
                return $"Age of the car is : {age}";
            }
        }

        public override void DisplayInfo()
        {
            if(speed > 0)
            {
                Console.WriteLine($"Car is mooving with speed of: {speed}");
            }
            else
            {
                Console.WriteLine("Car is stoped!");
            }
        }




        public void Accelerate(int acceleration)
        {
            Speed += acceleration;
        }

        public void Break(int breakValue)
        {
            Speed -= breakValue;
            if(Speed < 0)
            {
                Speed = 0;
            }
        }


    }


    //public class Bike : Vehicle
    //{
    //    public new void DisplayInfo()
    //    {
    //        Console.WriteLine($"This is a bike");
    //    }
    //}
    //public class Truck : Vehicle, IMovable
    //{
    //    public uint CargoCapacity { get; set; }

    //    public void Move()
    //    {
    //        Console.WriteLine("Truck is moving");
    //    }
    //}
}
