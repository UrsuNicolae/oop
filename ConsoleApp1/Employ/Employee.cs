//namespace ConsoleApp1.Employ
//{
//    public class ShortDescriptionEmployee
//    {
//        public string Name { get; set; }
//        public double Sallary { get; set; }
//    }

//    public class Employee : IEmploy
//    {
//        private readonly string name;
//        private readonly int id;
//        private readonly double sallary;

//        private static int StaticId = 1;
//        public Employee(string name, double sallary)
//        {
//            this.name = name;
//            this.id = StaticId++;
//            this.sallary = sallary;
//        }

//        public string Name => name;
//        public int Id => id;
//        public double Sallary => sallary;


//        public virtual void DisplayInfo()
//        {
//            Console.WriteLine($"Name: {name} Sallary: {sallary} ID: {id}");
//        }

//        public virtual void TakeBreak() { }

//        public virtual void Work() { }
//    }
//}
