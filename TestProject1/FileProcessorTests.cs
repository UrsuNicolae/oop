using Moq;
using TestingProject.UTs;

namespace TestProject1
{
    public class FileProcessorTests
    {
        [Theory]
        [InlineData("invalidPath")]
        [InlineData("testPath")]
        [InlineData("nonExistingPath")]
        [InlineData("sdlkfjlks")]
        public void CountLinesInFileShouldReturnZeroIfNotFound(string path)
        {
            var fileProcessorMock = new Mock<IFileReader>();
            fileProcessorMock.Setup(_ => _.ReadFile(It.IsAny<string>()))
                .Returns(string.Empty);

            var fileProcessor = new FileProcessor(fileProcessorMock.Object);
            var nrOfLines = fileProcessor.CountLinesInFile(path);

            Assert.Equal(0, nrOfLines);
        }

        [Theory]
        [InlineData("validpath1", "\n",1)]
        [InlineData("validpath2", "\ntest\n", 2)]
        [InlineData("validpath3", "\n_", 1)]
        [InlineData("validpath4", "", 0)]
        public void CountLinesInFileShouldReturnReturnCorectNrOfLineWhenFileFound(string path, string content, int nrLines)
        {
            var fileProcessorMock = new Mock<IFileReader>();
            fileProcessorMock.Setup(_ => _.ReadFile(path))
                .Returns(content);

            var fileProcessor = new FileProcessor(fileProcessorMock.Object);
            var nrOfLines = fileProcessor.CountLinesInFile(path);

            Assert.Equal(nrLines, nrOfLines);
        }

        [Theory]
        [InlineData("validpath1", "\n", 1)]
        [InlineData("validpath2", "\ntest\n", 2)]
        [InlineData("validpath3", "\n_", 1)]
        [InlineData("validpath4", "", 0)]
        public void CountLinesInFileShouldBeInvokedExaclyOnce(string path, string content, int nrLines)
        {
            var fileProcessorMock = new Mock<IFileReader>();
            fileProcessorMock.Setup(_ => _.ReadFile(path))
                .Returns(content);

            var fileProcessor = new FileProcessor(fileProcessorMock.Object);
            var nrOfLines = fileProcessor.CountLinesInFile(path);

            Assert.Equal(nrLines, nrOfLines);

            fileProcessorMock.Verify(_ => _.ReadFile(path), Times.Once);
        }

    }
}
