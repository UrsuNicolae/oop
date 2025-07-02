namespace ConsoleApp1.UTs
{
    public class SimpleCalculator
    {
        public int Add(int i, int b)
        {
            return i + b;
        }

        public int Subtract(int i, int b)
        {
            return i - b;
        }

        public int Mulitply(int i, int b)
        {
            return i * b;
        }

        public int Power(int i, int times)
        {
            var result = 1;
            for(int j = 1; j < times; j++)
            {
                result += i;
            }
            return result;
        }

        public int Divide(int i, int b)
        {
            if(b == 0)
            {
                throw new ArgumentException("Can not divide by zero!");
            }
            return i / b;
        }
    }

}
