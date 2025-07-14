
using WebApplicationDEMO.DTOs;

namespace WebApplicationDEMO.Repositories
{
    public interface IProductRepository
    {
        public ProductDto GetById(int id);
        public List<ProductDto> GetAll();
        public void DeleteById(int id);

        public void Update(ProductDto product);

        public void Create(ProductDto product);
    }
}
