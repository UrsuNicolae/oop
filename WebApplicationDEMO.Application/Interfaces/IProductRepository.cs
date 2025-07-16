using WebApplicationDEMO.Domain.Common;
using WebApplicationDEMO.Domain.Entities;

namespace WebApplicationDEMO.Application.Interfaces
{
    public interface IProductRepository
    {
        public Product GetById(int id);
        public PaginatedList<Product> GetAll(int page, int pageSize);
        public void DeleteById(int id);

        public void Update(Product product);

        public void Create(Product product);
    }
}
