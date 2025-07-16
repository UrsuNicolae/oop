using Microsoft.AspNetCore.Mvc;
using WebApplicationDEMO.Application.Interfaces;
using WebApplicationDEMO.Application.DTOs;
using WebApplicationDEMO.Application.Mapping;
using WebApplicationDEMO.Domain.Common;
using Microsoft.Extensions.Caching.Memory;

namespace WebApplicationDEMO.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMemoryCache _cache;
        private readonly IProductRepository _productRepository;

        public ProductController(
            IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Client)]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(ProductMappingProfile.MapToDto(_productRepository.GetById(id)));
        }

        [HttpGet]
        public IActionResult GetProducts(int page, int pageSize)
        {
            var paginatedResult = _productRepository.GetAll(page, pageSize);
            var productsDtos = paginatedResult.Items.Select(ProductMappingProfile.MapToDto).ToList();
            return Ok(new PaginatedList<ProductDto>(productsDtos, page, paginatedResult.TotalPages));
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductDto product)
        {
            var productToCreate = ProductMappingProfile.MapToProduct(product);
            _productRepository.Create(productToCreate);
            return CreatedAtAction(nameof(GetById), new { id = productToCreate.Id }, productToCreate);
        }

        [HttpPut]
        public IActionResult UpdateProduct(ProductDto product)
        {
            _productRepository.Update(ProductMappingProfile.MapToProduct(product));

            return Ok("Updated!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            _productRepository.DeleteById(id);
            return Ok("Delete!");
        }
    }
}
