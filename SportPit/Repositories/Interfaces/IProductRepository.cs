using SportPit.Models;

namespace SportPit.Repositories.Interfaces;

public interface IProductRepository
{
    Task<Product> GetByIdAsync(int id);
    Task<List<Product>> GetAllAsync();
    Task<List<Product>> GetProductsByListIdAsync(List<int> listId);
}