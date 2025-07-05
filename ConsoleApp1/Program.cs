using ConsoleApp1.DesignPatterns;

namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var toyotaStore = new VehicleStore(new ToyotaFactory());
            toyotaStore.ShowVehicles();

            var hondaStore = new VehicleStore(new HondaFactory());
            hondaStore.ShowVehicles();
        }



        static void RenderUI(List<IRender> renders)
        {
            foreach (var render in renders)
            {
                render.Render();
            }
        }

    }
}
