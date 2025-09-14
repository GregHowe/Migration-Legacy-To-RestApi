using Moq;
using ProductApi.Models;
using ProductApi.Repositories;
using ProductApi.Services;
using Xunit;

public class ProductServiceTests
{
    [Fact]
    public async Task CreateProduct_CallsRepositoryCreate()
    {
        var mockRepo = new Mock<IProductRepository>();
        mockRepo.Setup(r => r.CreateAsync(It.IsAny<Product>())).ReturnsAsync((Product p) => { p.Id = 1; return p; });
        var service = new ProductService(mockRepo.Object);

        var product = new Product { Name = "Test", Price = 9.99M };
        var created = await service.CreateAsync(product);

        Assert.Equal(1, created.Id);
        mockRepo.Verify(r => r.CreateAsync(It.IsAny<Product>()), Times.Once);
    }
}
