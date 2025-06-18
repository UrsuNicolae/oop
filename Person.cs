namespace ConsoleApp1
{
    public class Person : IComparable<Person>
    {
        public string Name;
        public int Age;

        public Person()
        {
            Name = "Unitialized Name";
            Age = -1;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person? other)
        {
            if (other == null) return 1;
            return Name.Length.CompareTo(other.Name.Length);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age} \n";
        }
    }

    //public class Person
    //{
    //    static Person()
    //    {
    //        Console.WriteLine("Static constructor");
    //    }

    //    public Person()
    //    {
    //        Console.WriteLine("Instance Constructor");
    //    }

    //    public Person(string p)
    //    {
    //        Console.WriteLine($"Instance costructor with param: {p}");
    //    }
    //}

}
