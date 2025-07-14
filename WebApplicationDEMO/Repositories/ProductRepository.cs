using WebApplicationDEMO.DTOs;

namespace WebApplicationDEMO.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private static List<ProductDto> _products = new List<ProductDto>
        {
            new() {Id = 1, Name = "Test1"},
            new ProductDto{Id = 2, Name = "Test2"},
            new ProductDto{Id = 3, Name = "Test3"}
        };


        public void Create(ProductDto product)
        {
            var productWithSameName = _products.FirstOrDefault(p => p.Name == product.Name);
            if (productWithSameName != null)
            {
                throw new KeyNotFoundException("Product with this name already exists!");
            }
            product.Id = _products.Count();
            _products.Add(product);
        }

        public void DeleteById(int id)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                throw new KeyNotFoundException("Product not found!");
            }
            _products.Remove(existingProduct);
        }

        public List<ProductDto> GetAll()
        {
            return _products;
        }

        public ProductDto GetById(int id)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                throw new KeyNotFoundException("Product not found!");
            }
            return existingProduct;
        }

        public void Update(ProductDto product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct == null)
            {
                throw new KeyNotFoundException("Product not found!");
            }
            existingProduct.Name = product.Name;
        }
    }
}
