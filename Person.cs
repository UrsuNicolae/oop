namespace ConsoleApp1
{
    //public class Person
    //{
    //    public string Name;
    //    public int Age;

    //    public Person()
    //    {
    //        Name = "Unitialized Name";
    //        Age = -1;
    //    }

    //    public Person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }

    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine($"Name: {Name}, Age: {Age}");
    //    }
    //}

    public class Person
    {
        static Person()
        {
            Console.WriteLine("Static constructor");
        }

        public Person()
        {
            Console.WriteLine("Instance Constructor");
        }

        public Person(string p)
        {
            Console.WriteLine($"Instance costructor with param: {p}");
        }
    }

}
