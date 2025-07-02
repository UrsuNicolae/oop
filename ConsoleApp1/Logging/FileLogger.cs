namespace ConsoleApp1.Logging
{

    //public abstract class Logger : ILogger
    //{
    //    public abstract void LogError(string message);

    //    public void LogInformation(string message)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void LogWarning(string message)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    public class FileLogger : ILogger<string>
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
