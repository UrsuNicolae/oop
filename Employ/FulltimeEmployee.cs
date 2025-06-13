namespace ConsoleApp1.Employ
{
    class FulltimeEmployee : Employee
    {
        public FulltimeEmployee(string name, double sallary) : base(name, sallary)
        {
        }

        public override void TakeBreak()
        {
            Console.WriteLine($"{Name} is taking a break for 1 hour");
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is working for 8 hours for a sallary of {Sallary}");
        }
    }
}
