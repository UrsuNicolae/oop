namespace ConsoleApp1.SOLID
{
    public class ReportRepository
    {
        private List<Report> reports = new();

        public void Save(Report report)
        {
            reports.Add(report);
        }

        public void Generate(Report report, IReportGenerator reportGenerator)
        {
            reportGenerator.GenerateReport(report);
        }
    }
}
