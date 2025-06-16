using ConsoleApp1.Discount;
using ConsoleApp1.Employ;
using ConsoleApp1.Events;
using ConsoleApp1.Examples;
using ConsoleApp1.Logging;
using ConsoleApp1.Packages;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var artist1 = new SoloMusician("Jhon", "pop", "guitar");
            var artist2 = new Band("The 5", "Rock", 5);
            var artist3 = new DJ("DJ max", "Electro", "House");

            var event1 = new MainConcert("MainStage", DateTime.Parse("2025-08-16"), artist1);
            var event2 = new AcusticSession("Acusting Room", DateTime.Parse("2025-09-16"), artist2);
            var event3 = new AfterParty("In The Club", DateTime.Parse("2025-08-16"), artist3);

            event1.DisplayDetails();
            event2.DisplayDetails();
            event3.DisplayDetails();
        }

        static void AfiseazaDetalii(Eveniment eveniment)
        {
            eveniment.DisplayDetails();  
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
