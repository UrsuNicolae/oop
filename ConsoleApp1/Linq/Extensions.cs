using ConsoleApp1.Employ;

namespace ConsoleApp1.Linq
{
    public static class Extensions
    {
        //public static List<ShortDescriptionEmployee> FilterEmployesBySallary(this List<Employee> employees)
        //{
        //    var result = employees.Where(e => e.Sallary > 50000)
        //        .OrderBy(e => e.Name)
        //        .Select(e => new ShortDescriptionEmployee { Name = e.Name, Sallary = e.Sallary });
        //    return result.ToList();
        //}

        public static List<OrderTotal> CalcuateOrderToatl (this List<Order> orders)
        {
            var result = orders.GroupBy(o => o.Product)
                .Select(g => new OrderTotal
                {
                    Product = g.Key,
                    TotalQuantity = g.Sum(s => s.Quantity),
                    TotalSum = g.Sum(s => s.Price)
                })
                .ToList();
            return result;
        }

        public static List<int> ConcatWithoutDuplicates(this List<int> current, List<int> second)
        {
            return current.Concat(second).Distinct().ToList();
        }

        public static List<Eminent> GetEminents(this List<Student> students)
        {
            return students.Where(s => s.Grades.Average() > 8)
                .Select(s => new Eminent
                {
                    Name = s.Name,
                    AverageGrade = s.Grades.Average()
                })
                .ToList();
        }

        public static void DisplayGenericArray<T>(this List<T> arr) where T : new()
        {
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
