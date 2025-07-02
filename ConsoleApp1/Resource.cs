namespace ConsoleApp1
{
    public class Resource
    {
        private StreamWriter streamWriter;

        public Resource(string filePath)
        {
            try
            {
                streamWriter = new StreamWriter(filePath, true);
                Console.WriteLine("Resursa este ocupata");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UseResurce(string message)
        {
            if(streamWriter != null)
            {
                streamWriter.Write(message);
                Console.WriteLine($"Append message: {message}");
            }
            else
            {
                Console.WriteLine("Resource is not available");
            }
        }

        ~Resource()
        {
            if(streamWriter != null)
            {
                streamWriter.Close();
                Console.WriteLine("Resoure is free!");
            }
        }
    }
}
