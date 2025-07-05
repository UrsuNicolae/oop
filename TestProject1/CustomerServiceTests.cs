using Moq;
using TestingProject.UTs;

namespace TestProject1
{
    public class CustomerServiceTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void GetCustomerNameShouldReturnUnknowWhenUserNotFound(int customerId)
        {
            var customerRepositoryMock = new Mock<ICustomerRepository>();
            customerRepositoryMock.Setup(_ => _.GetCustomerById(It.IsAny<int>())).Returns(new Customer
            {
                CustomerId = customerId,
                Name = null
            });
            var customerService = new CustomerService(customerRepositoryMock.Object);
            var name = customerService.GetCustomerName(customerId);

            Assert.Equal("Unknown", name);
        }

        [Fact]
        public void GetCustomerNameShouldReturnItsNameWhenFound()
        {
            var expected = "Ion";
            var customerRepositoryMock = new Mock<ICustomerRepository>();
            customerRepositoryMock.Setup(_ => _.GetCustomerById(It.IsAny<int>())).Returns(new Customer
            {
                CustomerId = 1,
                Name = expected
            });
            var customerService = new CustomerService(customerRepositoryMock.Object);
            var name = customerService.GetCustomerName(1);

            Assert.Equal(expected, name);
        }

        [Theory]
        [InlineData(1, "Ion")]
        [InlineData(4, "Vasile")]
        [InlineData(5, "Nicu")]
        [InlineData(6, "Gheorge")]
        public void GetCustomerNameShouldInvokeExactlyOnceGetCustomerById(int customerId, string name)
        {
            var customerRepositoryMock = new Mock<ICustomerRepository>();
            customerRepositoryMock.Setup(_ => _.GetCustomerById(customerId)).Returns(new Customer
            {
                CustomerId = customerId,
                Name = name
            });
            var customerService = new CustomerService(customerRepositoryMock.Object);
            var returnedName = customerService.GetCustomerName(customerId);

            Assert.Equal(name, returnedName);


            customerRepositoryMock.Verify(_ => _.GetCustomerById(customerId), Times.Once);
        }
    }
}
