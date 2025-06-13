using System.Runtime.Serialization.Formatters;

namespace ConsoleApp1.Logging
{
    public class FileLogger : ILogger
    {
        private readonly string filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }
        public void LogError(string message)
        {
            LogToFile($"ERROR: {message}");
        }

        public void LogInformation(string message)
        {
            LogToFile($"INFO: {message}");
        }

        public void LogWarning(string message)
        {
            LogToFile($"WARNING: {message}");
        }

        private void LogToFile(string message)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
    }
}
