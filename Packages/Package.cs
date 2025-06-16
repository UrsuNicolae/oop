using ConsoleApp1.Examples;

namespace ConsoleApp1.Packages
{
    public abstract class Package
    {
        public string Type { get; }
        public double Weight { get; }
        public double Distance { get; }

        protected Package(double weight, double distance, string type)
        {
            Weight = weight;
            Distance = distance;
            Type = type;
        }

        public abstract double CaclulateShipingCost();
    }

    public class StandartPackage : Package
    {
        public StandartPackage(double weight, double distance) : base(weight, distance, nameof(StandartPackage))
        {
        }

        public override double CaclulateShipingCost()
        {
            return 0.5 * Weight + 0.1 * Distance;
        }
    }

    public class PriorityPackage : Package
    {
        public PriorityPackage(double weight, double distance) : base(weight, distance, nameof(PriorityPackage))
        {
        }

        public override double CaclulateShipingCost()
        {
            return 0.8 * Weight + 0.2 * Distance;
        }
    }

    public class FragilePackage : Package
    {
        public FragilePackage(double weight, double distance) : base(weight, distance, nameof(FragilePackage))
        {
        }

        public override double CaclulateShipingCost()
        {
            return 1.2 * Weight + 0.5 * Distance;
        }
    }


}
