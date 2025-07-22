using WebApplicationDEMO.Domain.Common;
using WebApplicationDEMO.Domain.Entities;

namespace WebApplicationDEMO.Application.Interfaces
{
    public interface IProductRepository
    {
        public Task<Product> GetById(int id);
        public Task<PaginatedList<Product>> GetAll(int page, int pageSize);
        public Task DeleteById(int id);

        public Task Update(Product product);

        public Task Create(Product product);
    }
}
