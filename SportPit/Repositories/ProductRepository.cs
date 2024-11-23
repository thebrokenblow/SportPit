using Microsoft.EntityFrameworkCore;
using SportPit.Data;
using SportPit.Models;
using SportPit.Repositories.Interfaces;

namespace SportPit.Repositories;

public class ProductRepository(ApplicationContext context) : IProductRepository
{
    public Task<List<Product>> GetAllAsync() =>
        context.Products.ToListAsync();

    public Task<Product> GetByIdAsync(int id) =>
        context.Products.SingleAsync(product => product.Id == id);

    public async Task<List<Product>> GetProductsByListIdAsync(List<int> listId) => 
        await context.Products.Where(x => listId.Contains(x.Id)).ToListAsync();
}