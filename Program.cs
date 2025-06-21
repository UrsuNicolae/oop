using ConsoleApp1.Discount;
using ConsoleApp1.Employ;
using ConsoleApp1.Events;
using ConsoleApp1.Examples;
using ConsoleApp1.Lists;
using ConsoleApp1.Logging;
using ConsoleApp1.Packages;
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
            return  a +  b;
        }

        public T Subtract(T a, T b)
        {
            return  a -  b;
        }

        public T Multiply(T a, T b)
        {
            return  a *  b;
        }

        public T Divide(T a, T b)
        {
            return  a /  b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //var products = new List<Product>
            //{
            //    new Product("test", 23, false, 10, "test"),
            //    new Product("best", 23, false, 10, "test"),
            //    new Product("nest", 23, false, 10, "test1"),
            //    new Product("ok", 23, false, 10, "test2"),
            //};
            //var testProducts = Find.GetByCategory(products, p => p.Category == "test3");
            //products[0].Category = "test3";

            //foreach(var p in testProducts)
            //{
            //    Console.WriteLine(p);
            //}
            //var st = "ng";
            //var st1 = "String";
            //var st2 = "Stri" + st;
            //Console.WriteLine(st1 == st2);
            //Console.WriteLine(object.ReferenceEquals(st1, st2));

            var cursManagement = new CursManagement();
            cursManagement.Gestiune();
        }

        static void DisplayGenericArray<T>(T[] arr) where T : new()
        {
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
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
