namespace ConsoleApp1
{
    public class Outer
    {
        public void Run()
        {
            while (true)
            {
                var i = int.Parse(Console.ReadLine());
                var j = int.Parse(Console.ReadLine());
                var s = int.Parse(Console.ReadLine());
                var l = int.Parse(Console.ReadLine());
                var e = int.Parse(Console.ReadLine());
                double result = 0.15 * i + 0.15 * j + 0.1 * s + 0.2 * l + 0.4 * e;
                Console.WriteLine($"NotaFinala: {result}" );
            }
        }

        private class Inier
        {

            public void ShowMessage()
            {
                Console.WriteLine("Message from inner class!");
            }
        }
    }
}
