namespace ConsoleApp1.Sorting
{
    class Sort
    {
        public static void SortArray<T>(T[] array) where T : IComparable<T>
        {
            Array.Sort(array);
        }
    }
}
