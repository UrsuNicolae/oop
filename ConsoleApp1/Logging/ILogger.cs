namespace ConsoleApp1.Logging
{
    public interface ILogger<T>
    {
        void LogInformation(T message);
        void LogWarning(T message);
        void LogError(T message);
    }
}
