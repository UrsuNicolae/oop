using Microsoft.AspNetCore.Mvc;
using WebApplicationDEMO.DTOs;
using WebApplicationDEMO.Repositories;

namespace WebApplicationDEMO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_productRepository.GetById(id));
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_productRepository.GetAll());
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductDto product)
        {

            _productRepository.Create(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpPut]
        public IActionResult UpdateProduct(ProductDto product)
        {
            _productRepository.Update(product);

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
