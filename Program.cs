using ConsoleApp1.Discount;
using ConsoleApp1.Employ;
using ConsoleApp1.Events;
using ConsoleApp1.Examples;
using ConsoleApp1.GenericsRepo;
using ConsoleApp1.Linq;
using ConsoleApp1.Lists;
using ConsoleApp1.Logging;
using ConsoleApp1.Packages;
using ConsoleApp1.SOLID;
using ConsoleApp1.Sorting;
using System.Collections;
using System.Data.SqlTypes;
using System.Linq.Expressions;
using System.Numerics;

namespace ConsoleApp1
{
    public class MathOperations<T> where T : INumber<T>
    {
        public T Add(T a, T b)
        {
            return a + b;
        }

        public T Subtract(T a, T b)
        {
            return a - b;
        }

        public T Multiply(T a, T b)
        {
            return a * b;
        }

        public T Divide(T a, T b)
        {
            return a / b;
        }
    }

    internal class Program
    {
        class Test
        {
            public int Prop1 { get; set; }

            public List<Test2> Test2Values { get; set; }
        }

        class Test2
        {
            public int Prop2 { get; set; }
        }



        static void Main(string[] args)
        {
            var reportRepo = new ReportRepository();
            var pdfReport = new Report
            {
                Title = "tEST",
                Content = "Test content"
            };
            reportRepo.Save(pdfReport);
            reportRepo.Generate(pdfReport, new PdfReportGenerator());
        }

        

        static void RenderUI(List<IRender> renders)
        {
            foreach (var render in renders)
            {
                render.Render();
            }
        }

    }
}
