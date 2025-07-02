namespace ConsoleApp1.DesignPatterns
{
    // Interfața abstractă pentru produse
    public interface ISmartphone
    {
        void GetDetails();
    }

    public interface ITablet
    {
        void GetDetails();
    }

    // Produse concrete pentru Apple
    public class AppleSmartphone : ISmartphone
    {
        public void GetDetails() => Console.WriteLine("Apple Smartphone - iPhone 13");
    }

    public class AppleTablet : ITablet
    {
        public void GetDetails() => Console.WriteLine("Apple Tablet - iPad Pro");
    }

    // Produse concrete pentru Samsung
    public class SamsungSmartphone : ISmartphone
    {
        public void GetDetails() => Console.WriteLine("Samsung Smartphone - Galaxy S21");
    }

    public class SamsungTablet : ITablet
    {
        public void GetDetails() => Console.WriteLine("Samsung Tablet - Galaxy Tab S7");
    }

    // Abstract Factory
    public interface IElectronicsFactory
    {
        ISmartphone CreateSmartphone();
        ITablet CreateTablet();
    }

    // Fabrici concrete pentru fiecare brand
    public class AppleFactory : IElectronicsFactory
    {
        public ISmartphone CreateSmartphone() => new AppleSmartphone();
        public ITablet CreateTablet() => new AppleTablet();
    }

    public class SamsungFactory : IElectronicsFactory
    {
        public ISmartphone CreateSmartphone() => new SamsungSmartphone();
        public ITablet CreateTablet() => new SamsungTablet();
    }

    // Clientul care utilizează Abstract Factory
    public class ElectronicsStore
    {
        private readonly IElectronicsFactory _factory;

        public ElectronicsStore(IElectronicsFactory factory)
        {
            _factory = factory;
        }

        public void ShowProducts()
        {
            var smartphone = _factory.CreateSmartphone();
            var tablet = _factory.CreateTablet();

            smartphone.GetDetails();
            tablet.GetDetails();
        }
    }

}
