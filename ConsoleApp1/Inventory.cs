namespace ConsoleApp1
{
    public class Inventory
    {
        private List<Produs> products;

        public Inventory(List<Produs> products)
        {
            this.products = products;
        }

        public Produs this[int index]
        {
            get
            {
                if (index >= 0 && index < products.Count)
                {
                    return products[index];
                }
                else throw new IndexOutOfRangeException("Index is not valid!");
            }
            set
            {
                if (index >= 0 && index < products.Count)
                {
                    products[index] = value;
                }
                else throw new IndexOutOfRangeException("Index is not valid!");
            }
        }
    }
}
