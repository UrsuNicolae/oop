namespace ConsoleApp1
{
    public interface IA
    {
        void DoWork();
    }

    public interface IB
    {
        void DoWork();
    }

    public interface IC : IA, IB
    {
        new void DoWork();
    }

    public class Diamond : IC
    {
        public void DoWork()
        {
            Console.WriteLine("Do work!");
        }
    }
}
