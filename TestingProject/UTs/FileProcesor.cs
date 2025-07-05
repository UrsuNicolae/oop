namespace TestingProject.UTs
{
    public interface IFileReader
    {
        string ReadFile(string filePath);
    }


    public class FileProcessor
    {
        private IFileReader _fileReader;


        public FileProcessor(IFileReader fileReader)
        {
            _fileReader = fileReader;
        }


        public int CountLinesInFile(string filePath)
        {
            var fileContent = _fileReader.ReadFile(filePath);
            if (string.IsNullOrEmpty(fileContent))
            {
                return 0;
            }


            var i = 0;
            var count = 0;
            while(i < fileContent.Length)
            {
                if (fileContent[i] == '\n')
                {
                    count++;
                }
                i++;
            }
            return count;
        }
    }

}
