namespace TestingProject.UTs
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }


    public interface IProductRepository
    {
        Product GetProductById(int productId);
    }


    public class ProductManager
    {
        private IProductRepository _productRepository;


        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public decimal GetProductPrice(int productId)
        {
            var product = _productRepository.GetProductById(productId);
            return product?.Price ?? 0;
        }
    }

}
