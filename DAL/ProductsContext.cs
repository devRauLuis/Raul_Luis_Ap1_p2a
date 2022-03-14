using Microsoft.EntityFrameworkCore;
using Raul_Luis_Ap2_p2a.Entidades;

namespace Raul_Luis_Ap2_p2a.DAL;
public class ProductsContext : DbContext
{
    public ProductsContext(DbContextOptions<ProductsContext> options) : base(options) { }
    public DbSet<Productos> Productos { get; set; }
    public DbSet<ProductoDetallesPresentacion> ProductoDetallesPresentacion { get; set; }
    public DbSet<ProductosEmpacados> ProductosEmpacados { get; set; }
    public DbSet<ProductoDetalles> ProductoDetalles { get; set; }

    #region Required
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductoDetallesPresentacion>().ToView(nameof(ProductoDetallesPresentacion)).HasKey(p => p.ProductoDetallesId);
    }
    #endregion

}
