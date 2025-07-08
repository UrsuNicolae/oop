using ConsoleApp1.Deletegates;

namespace ConsoleApp1
{

    internal class Program
    {

        public delegate int MathOperation(int x, int y);


        static void Main(string[] args)
        {
            //var operationDelegates = new List<MathOperation>
            //{
            //    StaticDelegated.Add,
            //    StaticDelegated.Subtract,
            //    StaticDelegated.Divide,
            //    StaticDelegated.Multiply
            //};

            //foreach(var operation in operationDelegates)
            //{
            //    Console.WriteLine(operation(1, 2));
            //}

            //var strings = new List<string>
            //{
            //    "apple", 
            //    "banana",
            //    "cherry",
            //    "rasberry",
            //    "pineapple"
            //};

            //var filters = new List<StaticDelegated.StringFilter>
            //{
            //    str => StaticDelegated.StartWithLetter(str, 'a'),
            //    str2 => StaticDelegated.ContainsSubstring(str2, "rry"),
            //    str3 => StaticDelegated.StringIsLongerThan(str3, 6)
            //};

            //foreach(var deleg in filters)
            //{
            //    var filteredResult = StaticDelegated.FilterStrings(strings, deleg);
            //    foreach(var str in filteredResult)
            //    {
            //        Console.Write(str + " ");
            //    }
            //    Console.WriteLine();
            //}

            var products = new List<Product>
            {
                new Product("TV", "Electronics", 3000),
                new Product("Phone", "Electronics", 5000),
                new Product("PhoneCase", "Accesories", 50),
            };

            Console.WriteLine("Cheep Products");
            foreach (var p in ProductDelegates.Filter(products, new ProductDelegates.ProductFilter(ProductDelegates.IsCheap)))
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("Electornic Products");
            foreach (var p in ProductDelegates.Filter(products, new ProductDelegates.ProductFilter(ProductDelegates.IsElectronic)))
            {
                Console.WriteLine(p);
            }

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
