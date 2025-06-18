namespace ConsoleApp1.Sorting
{
    class Find
    {
        public static T FindItem<T>(List<T> list, Func<T, bool> predicat)
        {
            return list.FirstOrDefault(predicat);
        }
    }
}
