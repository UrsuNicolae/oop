using Microsoft.Extensions.Caching.Memory;
using System.Text;
using WebApplicationDEMO.Application.Interfaces;
using WebApplicationDEMO.Domain.Common;
using WebApplicationDEMO.Domain.Entities;

namespace WebApplicationDEMO.Infrastructure.Persistance
{
    public class ProductRepository : IProductRepository
    {
        private const string KEY = "products";
        private static List<Product> _products = new()
        {
            new(){Id = 1, Name = "Test1"},
            new(){Id = 2, Name = "Test2"},
            new(){Id = 3, Name = "Test3"}
        };
        private readonly IMemoryCache _cache;

        public ProductRepository(IMemoryCache cache)
        {
            _cache = cache;
            _cache.Set(KEY, _products, TimeSpan.FromMinutes(1));
        }

        public void Create(Product product)
        {
            if (!_cache.TryGetValue(KEY, out List<Product> productSource))
            {
                productSource = _products;
            }
            var productWithSameName = productSource.FirstOrDefault(p => p.Name == product.Name);
            if (productWithSameName != null)
            {
                throw new KeyNotFoundException("Product with this name already exists!");
            }
            product.Id = productSource.Count();
            productSource.Add(product);
            _cache.Set(KEY, productSource);
        }

        public void DeleteById(int id)
        {
            if (!_cache.TryGetValue(KEY, out List<Product> productSource))
            {
                productSource = _products;
            }
            var existingProduct = productSource.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                throw new KeyNotFoundException("Product not found!");
            }
            productSource.Remove(existingProduct);
            _cache.Set(KEY, productSource);
        }

        public PaginatedList<Product> GetAll(int page, int pageSize)
        {
            if (!_cache.TryGetValue(KEY, out List<Product> productSource))
            {
                productSource = _products;
            }
            var products = productSource
                                .OrderBy(p => p.Id)
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToList();
            var totalPages = (int)Math.Ceiling(productSource.Count() / (double)pageSize);
            return new PaginatedList<Product>(products, page, totalPages);
        }

        public Product GetById(int id)
        {
            if (!_cache.TryGetValue(KEY, out List<Product> productSource))
            {
                productSource = _products;
            }
            var existingProduct = productSource.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                throw new KeyNotFoundException("Product not found!");
            }
            return existingProduct;
        }

        public void Update(Product product)
        {
            if (!_cache.TryGetValue(KEY, out List<Product> productSource))
            {
                productSource = _products;
            }
            var existingProduct = productSource.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct == null)
            {
                throw new KeyNotFoundException("Product not found!");
            }
            existingProduct.Name = product.Name;
            _cache.Set(KEY, productSource);
        }
    }
}
