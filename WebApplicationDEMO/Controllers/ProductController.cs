using Microsoft.AspNetCore.Mvc;
using WebApplicationDEMO.DTOs;

namespace WebApplicationDEMO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<ProductDto> _products = new List<ProductDto>
        {
            new() {Id = 1, Name = "Test1"},
            new ProductDto{Id = 2, Name = "Test2"},
            new ProductDto{Id = 3, Name = "Test3"}
        };

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var productToReturn = _products.FirstOrDefault(p => p.Id == id);
            if(productToReturn == null)
            {
                return NotFound($"Product with id: {id} not found!");
            }
            return Ok(productToReturn);
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_products);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductDto product)
        {

            var productWithSameName = _products.FirstOrDefault(p => p.Name == product.Name);
            if(productWithSameName != null)
            {
                return BadRequest("Product with this name already exists!");
            }
            product.Id = _products.Count();
            _products.Add(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpPut]
        public IActionResult UpdateProduct(ProductDto product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct == null)
            {
                return NotFound("Product not found!");
            }
            existingProduct.Name = product.Name;
            
            return Ok("Updated!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var productToReturn = _products.FirstOrDefault(p => p.Id == id);
            if (productToReturn == null)
            {
                return NotFound($"Product with id: {id} not found!");
            }
            _products.Remove(productToReturn);
            return Ok("Delete!");
        }
    }
}
