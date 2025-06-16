namespace ConsoleApp1.Logging
{
    public class ConsoleLogger<T> : ILogger<T>
    {
        public void LogError(T message)
        {
            Console.WriteLine($"ERROR: {message}");
        }

        public void LogInformation(T message)
        {
            Console.WriteLine($"INFO: {message}");
        }

        public void LogWarning(T message)
        {
            Console.WriteLine($"WARNING: {message}");
        }
    }
}
