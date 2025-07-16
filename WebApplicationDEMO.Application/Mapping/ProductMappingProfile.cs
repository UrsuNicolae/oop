using WebApplicationDEMO.Application.DTOs;
using WebApplicationDEMO.Domain.Entities;

namespace WebApplicationDEMO.Application.Mapping
{
    public static class ProductMappingProfile
    {
        public static ProductDto MapToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name
            };
        }

        public static Product MapToProduct(ProductDto product)
        {
            return new Product
            {
                Id = product.Id,
                Name = product.Name
            };
        }
    }
}
