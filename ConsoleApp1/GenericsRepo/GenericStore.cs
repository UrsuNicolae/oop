using ConsoleApp1.Linq;

namespace ConsoleApp1.GenericsRepo
{
    public class GenericStore
    {
        private Repository<Order, int> orders = new();
        private Repository<Produs, int> products = new();

        public void ManageOrders()
        {
            var repo = new Repository<Order, int>();
            repo.Add(new Order { Id = 1, Price = 20, Product = "Test", Quantity = 2 });
            repo.GetAll().DisplayGenericArray();
            repo.Update(new Order { Id = 1, Price = 23, Product = "Test1", Quantity = 25 });
            repo.GetAll().DisplayGenericArray();
            repo.Delete(new Order { Id = 1 });
            repo.GetAll().DisplayGenericArray();
        }
    }
}
