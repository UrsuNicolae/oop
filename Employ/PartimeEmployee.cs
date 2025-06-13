namespace ConsoleApp1.Employ
{
    class PartimeEmployee : Employee
    {
        public PartimeEmployee(string name, double sallary) : base(name, sallary)
        {
        }

        public override void TakeBreak()
        {
            Console.WriteLine($"{Name} is taking a break for 30 minutes");
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is working for 4 hours for a sallary of {Sallary}");
        }
    }
}
