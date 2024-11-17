using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SportPit.Models;
namespace SportPit.Data;

public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Cart> Carts { get; set; }
}
