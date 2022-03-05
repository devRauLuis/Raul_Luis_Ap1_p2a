using Microsoft.EntityFrameworkCore;
using ProductsBlazor.Entidades;

namespace ProductsBlazor.DAL;
public class ProductsContext : DbContext
{
    public ProductsContext(DbContextOptions<ProductsContext> options) : base(options) { }
    public DbSet<Productos> Productos { get; set; }

}
