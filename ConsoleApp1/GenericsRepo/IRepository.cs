namespace ConsoleApp1.GenericsRepo
{
    interface IRepository<T>
    {
        void Add(T value);
        List<T> GetAll();

        void Delete(T value);

        void Update(T value);
    }

    public class Repository<T, Tkey> : IRepository<T>
        where T : BaseEntity<Tkey>
    {
        private Dictionary<Tkey, T> data = new();

        public void Add(T value)
        {
            if (data.ContainsKey(value.Id))
            {
                Console.WriteLine(value + " Already exists!");
                return;
            }
            data.Add(value.Id, value);
        }

        public void Delete(T value)
        {
            if (!data.ContainsKey(value.Id))
            {
                Console.WriteLine(value + " Not found!");
                return;
            }
            data.Remove(value.Id);
        }

        public List<T> GetAll()
        {
            return data.Select(e => e.Value).ToList();
        }

        public void Update(T value)
        {
            if (!data.ContainsKey(value.Id))
            {
                Console.WriteLine(value + " Not found!");
                return;
            }
            data[value.Id] = value;
        }
    }
}
