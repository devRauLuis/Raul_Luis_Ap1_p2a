using Microsoft.EntityFrameworkCore;
using ProductsBlazor.Entidades;

namespace ProductsBlazor.DAL;
public class ProductsContext : DbContext
{
    public ProductsContext(DbContextOptions<ProductsContext> options) : base(options) { }
    public DbSet<Productos> Productos { get; set; }

    public DbSet<ProductoDetallesEmpacados> ProductoDetallesEmpacados { get; set; }

    #region Required
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductoDetallesEmpacados>().ToView(nameof(ProductoDetallesEmpacados)).HasKey(p => p.ProductoDetallesId);
    }
    #endregion

}
