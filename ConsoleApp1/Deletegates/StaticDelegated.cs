namespace ConsoleApp1.Deletegates
{
    public class StaticDelegated
    {
        public delegate bool StringFilter(string str);

        public static int Add(int x, int y)
        {
            Console.WriteLine($"Add {x} with {y}");
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            Console.WriteLine($"Subtract {x} from {y}");

            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            Console.WriteLine($"Multiply {x} with {y}");

            return x * y;
        }

        public static int Divide(int x, int y)
        {
            Console.WriteLine($"Divide {x} by {y}");

            if (y == 0)
            {
                throw new ArgumentException("Divide by zero is not possible!");
            }
            return x / y;
        }

        public static bool StartWithLetter(string str, char letter) =>
            str.StartsWith(letter);
        public static bool ContainsSubstring(string str, string substring) =>
            str.Contains(substring);

        public static bool StringIsLongerThan(string str, int length) =>
            str.Length > length;

        public static List<string> FilterStrings(List<string> strings,
            StringFilter filter)
        {
            List<string> result = new List<string>();
            foreach(var str in strings)
            {
                if (filter(str))
                {
                    result.Add(str);
                }
            }
            return result;
        }


    }
}
