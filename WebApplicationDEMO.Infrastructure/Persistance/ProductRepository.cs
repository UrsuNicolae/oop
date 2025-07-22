using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Caching.Memory;
using WebApplicationDEMO.Application.Interfaces;
using WebApplicationDEMO.Domain.Common;
using WebApplicationDEMO.Domain.Entities;
using WebApplicationDEMO.Infrastructure.Data;

namespace WebApplicationDEMO.Infrastructure.Persistance
{
    public class ProductRepository : IProductRepository
    {
        private string KEY = "PRODUCT_{0}";
        private readonly IMemoryCache _cache;
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext, IMemoryCache cache)
        {
            _appDbContext = appDbContext;
            _cache = cache;
        }

        public async Task Create(Product product)
        {
            await _appDbContext.Products.AddAsync(product);
            await _appDbContext.SaveChangesAsync();
            _cache.Set(string.Format(KEY, product.Id), product);
        }

        public async Task DeleteById(int id)
        {
            var key = string.Format(KEY, id);
            if (!_cache.TryGetValue(key, out Product? product))
            {
                product = await _appDbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
            }

            if(product == null)
            {
                throw new KeyNotFoundException($"Product with id: {id} not foun!");
            }

            try
            {
                _appDbContext.Products.Remove(product);
                await _appDbContext.SaveChangesAsync();
                if(_cache.TryGetValue(key, out var prodFromCache))
                {
                    _cache.Remove(key);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task<PaginatedList<Product>> GetAll(int page, int pageSize)
        {
            var totalCount = await _appDbContext.Products.CountAsync();

            if(totalCount == 0)
            {
                return new PaginatedList<Product>(new(), page, totalCount);
            }

            var products = await _appDbContext.Products
                                .AsNoTracking()
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToListAsync();
            return new PaginatedList<Product>(products, page, (int)Math.Ceiling(totalCount / (double)pageSize));
        }

        public async Task<Product> GetById(int id)
        {
            if (!_cache.TryGetValue(string.Format(KEY, id), out Product? product))
            {
                product = await _appDbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
            }

            if (product == null)
            {
                throw new KeyNotFoundException($"Product with id: {id} not foun!");
            }

            return product;
        }

        public async Task Update(Product product)
        {
            _appDbContext.Products.Update(product);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
