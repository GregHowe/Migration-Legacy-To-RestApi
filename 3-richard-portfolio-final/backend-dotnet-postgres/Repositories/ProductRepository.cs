using Microsoft.EntityFrameworkCore;
using ProductApi.Data;
using ProductApi.Models;

namespace ProductApi.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _db;
    public ProductRepository(AppDbContext db) => _db = db;

    public async Task<Product> CreateAsync(Product product)
    {
        _db.Products.Add(product);
        await _db.SaveChangesAsync();
        return product;
    }

    public async Task DeleteAsync(int id)
    {
        var e = await _db.Products.FindAsync(id);
        if (e != null) { _db.Products.Remove(e); await _db.SaveChangesAsync(); }
    }

    public async Task<IEnumerable<Product>> GetAllAsync() => await _db.Products.ToListAsync();

    public async Task<Product?> GetByIdAsync(int id) => await _db.Products.FindAsync(id);

    public async Task UpdateAsync(Product product)
    {
        _db.Products.Update(product);
        await _db.SaveChangesAsync();
    }
}
