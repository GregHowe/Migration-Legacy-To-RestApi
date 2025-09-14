using ProductApi.Models;
using ProductApi.Repositories;

namespace ProductApi.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repo;
    public ProductService(IProductRepository repo) => _repo = repo;

    public Task<Product> CreateAsync(Product product) => _repo.CreateAsync(product);

    public Task DeleteAsync(int id) => _repo.DeleteAsync(id);

    public Task<IEnumerable<Product>> GetAllAsync() => _repo.GetAllAsync();

    public Task<Product?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);

    public Task UpdateAsync(Product product) => _repo.UpdateAsync(product);
}
