namespace ConsoleApp1.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine($"ERROR: {message}");
        }

        public void LogInformation(string message)
        {
            Console.WriteLine($"INFO: {message}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"WARNING: {message}");
        }
    }
}
