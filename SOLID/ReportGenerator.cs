namespace ConsoleApp1.SOLID
{
    public interface IReportGenerator
    {
        void GenerateReport(Report report);
    }

    class PdfReportGenerator : IReportGenerator
    {
        public void GenerateReport(Report report)
        {
            Console.WriteLine($"Generate PDF report for: {report.Title}");
        }
    }

    class ExceltReportGenerator : IReportGenerator
    {
        public void GenerateReport(Report report)
        {
            Console.WriteLine($"Generate Excel report for: {report.Title}");
        }
    }

    class DocsReportGenerator : IReportGenerator
    {
        public void GenerateReport(Report report)
        {
            Console.WriteLine($"Generate Docs report for: {report.Title}");

        }
    }


}
