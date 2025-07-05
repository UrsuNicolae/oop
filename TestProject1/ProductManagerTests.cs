using Moq;
using TestingProject.UTs;

namespace TestProject1
{
    public class ProductManagerTests
    {
        [Fact]
        public void TestGetProductPrice_ProductExists()
        {
            // Aranjare
            var productRepositoryMock = new Mock<IProductRepository>();
            var productManager = new ProductManager(productRepositoryMock.Object);


            var productId = 1;
            var product = new Product { ProductId = productId, Name = "Sample Product", Price = 10.99M };
            productRepositoryMock.Setup(repo => repo.GetProductById(productId)).Returns(product);


            // Acțiune
            var result = productManager.GetProductPrice(productId);


            // Asertare
            Assert.Equal(10.99M, result);
        }


        [Fact]
        public void TestGetProductPrice_ProductNotFound()
        {
            // Aranjare
            var productRepositoryMock = new Mock<IProductRepository>();
            var productManager = new ProductManager(productRepositoryMock.Object);


            var productId = 2;
            productRepositoryMock.Setup(repo => repo.GetProductById(productId)).Returns((Product)null);


            // Acțiune
            var result = productManager.GetProductPrice(productId);


            // Asertare
            Assert.Equal(0, result);
        }
    }

}
