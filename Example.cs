namespace ConsoleApp1
{
    public class Test
    {

        private int test;
        public int MyProperty
        {
            get { return test; }
            set { test = value; }
        }


        public int MyProperty1 { get; set; }
    }

    public class Example
    {
        //public void Display(object a, decimal b)
        //{
        //    Console.WriteLine((int)a + b);
        //}

        public void Display(string a)
        {
            Console.WriteLine(a);
        }

        public void Display(int a, decimal b)
        {
            Console.WriteLine(a + b);
        }

        public void Display(int a)
        {
            switch (a)
            {
                case 2: Console.WriteLine(2); break;
                default:
                    Console.WriteLine("nustriu ce");
                    break;
            }

        }


    }
}
