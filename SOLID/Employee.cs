using System.Xml.Linq;

namespace ConsoleApp1.SOLID
{
    class Employee
    {
        private string name;
        private decimal salaray;

        public Employee(string name, decimal salaray)
        {
            this.name = name;
            this.salaray = salaray;
        }

        public string Name => name;

        public decimal Sallary => salaray;
    }

    class EmployeePaymentCalculator
    {
        public void CalculatePay(Employee employee)
        {
            Console.WriteLine($"Cacluate pay for {employee.Name}");
            Console.WriteLine($"Saralary for this month is: {employee.Sallary * 2}");
        }
    }

    class EmployeeBonusCalculator : EmployeePaymentCalculator
    {
        public void AppllyBonus(Employee employee)
        {
            CalculatePay(employee);
            Console.WriteLine($"Bonus for {employee.Name} is: {employee.Sallary * 0.5m}");
        }
    }


    interface IEmployeeRepository
    {
        void Save(Employee employee);
        void GetEmployee(string name);
    }


    class EmployeeDbRepository : IEmployeeRepository
    {
        public void Save(Employee employee)
        {
            Console.WriteLine($"Saving employee: {employee.Name} to database");
        }

        public void GetEmployee(string name)
        {
            Console.WriteLine($"Return employee: {name}");
        }
    }

    class EployeeApiRepository : IEmployeeRepository
    {
        public void Save(Employee employee)
        {
            Console.WriteLine("Testing the api connection!");
            Console.WriteLine($"Saving employee: {employee.Name} to api");
        }

        public void GetEmployee(string name)
        {
            Console.WriteLine("Testing the api connection!");
            Console.WriteLine($"Return employee: {name}");
        }
    }


}
