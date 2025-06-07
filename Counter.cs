namespace ConsoleApp1
{
    public class Counter
    {
        public static int Count = 0;

        public Counter()
        {
            Count++;
        }

        public Counter(int i)
        {
            Count += 2;
        }
    }
}
