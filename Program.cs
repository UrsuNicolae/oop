using ConsoleApp1.Discount;
using ConsoleApp1.Employ;
using ConsoleApp1.Events;
using ConsoleApp1.Examples;
using ConsoleApp1.Logging;
using ConsoleApp1.Packages;
using ConsoleApp1.Sorting;
using System.Collections;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var binTree = new BinarySearchTree<int>();
            binTree.Insert(5);
            binTree.Insert(2);
            binTree.Insert(7);
            binTree.Insert(10);

            Console.WriteLine("Searching the tree!");
            Console.WriteLine($"Search for 5: {binTree.Search(5)}");
            Console.WriteLine($"Search for 8: {binTree.Search(8)}");
        }

        static void DisplayGenericArray<T>(T[] arr)
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
