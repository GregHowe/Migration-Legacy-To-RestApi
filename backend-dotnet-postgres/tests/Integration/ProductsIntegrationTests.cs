using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using ProductApi.Models;
using Xunit;

public class ProductsIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    public ProductsIntegrationTests(WebApplicationFactory<Program> factory) => _factory = factory;

    [Fact]
    public async Task GetAll_ReturnsOkAndSeededProducts()
    {
        var client = _factory.CreateClient();
        var res = await client.GetAsync("/api/products");
        Assert.Equal(HttpStatusCode.OK, res.StatusCode);

        var list = await res.Content.ReadFromJsonAsync<Product[]>();
        Assert.NotNull(list);
        Assert.NotEmpty(list);
    }

    [Fact]
    public async Task Create_Update_Delete_Product_EndToEnd()
    {
        var client = _factory.CreateClient();

        // Create
        var create = await client.PostAsJsonAsync("/api/products", new Product { Name = "X", Price = 1 });
        Assert.Equal(HttpStatusCode.Created, create.StatusCode);
        var created = await create.Content.ReadFromJsonAsync<Product>();
        Assert.NotNull(created);

        // Update
        created!.Name = "X2";
        var put = await client.PutAsJsonAsync($"/api/products/{created.Id}", created);
        Assert.Equal(HttpStatusCode.NoContent, put.StatusCode);

        // Delete
        var del = await client.DeleteAsync($"/api/products/{created.Id}");
        Assert.Equal(HttpStatusCode.NoContent, del.StatusCode);
    }
}
