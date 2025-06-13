using ConsoleApp1.Employ;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var empList = new List<Employee>
            {
                new FulltimeEmployee("nicu", 2000),
                new PartimeEmployee("vasile", 2000)
            };
            var manager = new EmployeeManager(empList);
            manager.Add(new FulltimeEmployee("Ion", 3500));
            manager.DisplayAll();
            manager.TellToTakeABreak(empList[0].Id);
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
