namespace ConsoleApp1.DesignPatterns
{
    public interface IVehicle
    {
        void Drive();
    }

    public interface IMotorcycle
    {
        void Ride();
    }

    public class ToyotaCar : IVehicle
    {
        public void Drive() => Console.WriteLine("Driving a Toyota car");
    }

    public class ToyotaMotorcycle : IMotorcycle
    {
        public void Ride()
        {
            Console.WriteLine("Ride a Toyota motorcycle!");
        }
    }

    public class HondaCar : IVehicle
    {
        public void Drive() => Console.WriteLine("Driving a Honda car");
    }

    public class HondaMotorcycle : IMotorcycle
    {
        public void Ride()
        {
            Console.WriteLine("Ride a Honda motorcycle!");
        }
    }

    public interface IVehicleFactory
    {
        IVehicle CreateVehicle();
        IMotorcycle CreateMotorCyle();
    }

    public class ToyotaFactory : IVehicleFactory
    {
        public IMotorcycle CreateMotorCyle()
        {
            return new ToyotaMotorcycle();
        }

        public IVehicle CreateVehicle()
        {
            return new ToyotaCar();
        }
    }

    public class HondaFactory : IVehicleFactory
    {
        public IMotorcycle CreateMotorCyle()
        {
            return new HondaMotorcycle();
        }

        public IVehicle CreateVehicle()
        {
            return new HondaCar();
        }
    }

    public class VehicleStore
    {
        private readonly IVehicleFactory vehicleFactory;
        public VehicleStore(IVehicleFactory vehicleFactory)
        {
            this.vehicleFactory = vehicleFactory;
        }

        public void ShowVehicles()
        {
            var car = vehicleFactory.CreateVehicle();
            var motorCycle = vehicleFactory.CreateMotorCyle();
            car.Drive();
            motorCycle.Ride();
        }
    }
}
