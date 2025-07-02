namespace ConsoleApp1.GenericsRepo
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
    }


}
