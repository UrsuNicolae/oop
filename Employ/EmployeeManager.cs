namespace ConsoleApp1.Employ
{
    class EmployeeManager
    {
        private readonly List<Employee> employees;

        public EmployeeManager(List<Employee> employees)
        {
            this.employees = employees;
        }

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public void Remove(Employee employee)
        {
            employees.Remove(employee);
        }

        public void DisplayAll()
        {
            foreach(var emp in employees)
            {
                emp.DisplayInfo();
            }
        }

        public void TellToTakeABreak(int employeeId)
        {
            var employee = employees.FirstOrDefault(e => e.Id == employeeId);
            if(employee != null)
            {
                employee.TakeBreak();
                employee.Work();
            }
        }
    }
}
