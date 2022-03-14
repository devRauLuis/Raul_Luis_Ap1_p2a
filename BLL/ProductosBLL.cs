using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

using Raul_Luis_Ap2_p2a.DAL;
using Raul_Luis_Ap2_p2a.Entidades;

namespace Raul_Luis_Ap2_p2a.BLL;
public class ProductosBLL
{
    private ProductsContext _context;

    public ProductosBLL(ProductsContext context)
    {
        _context = context;
    }

    public bool Existe(int id)
    {
        try
        {
            return _context.Productos.AsNoTracking().Any(p => p.ProductoId == id);

        }
        catch (System.Exception ex)
        {
            throw;
        }


    }

    public bool Guardar(Productos producto)
    {

        try
        {
            return !Existe(producto.ProductoId) ? Insertar(producto) : Modificar(producto);
        }
        catch (System.Exception ex)
        {

            throw;
        }
    }

    private bool Insertar(Productos producto)
    {
        try
        {
            _context.Productos.Add(producto);
            return _context.SaveChanges() > 0;
        }
        catch (System.Exception ex)
        {
            throw;
        }

    }
    private bool Modificar(Productos producto)
    {

        try
        {
            _context.Update(producto);
            var response = _context.SaveChanges() > 0;
            return response;
        }
        catch (System.Exception ex)
        {
            throw;
        }
    }

    public bool Eliminar(int id)
    {
        var producto = Buscar(id);

        if (producto is not null)
        {
            try
            {
                _context.Entry(producto).State = EntityState.Deleted;
                return _context.SaveChanges() > 0;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        return false;
    }

    public Productos? Buscar(int id)
    {

        try
        {
            return _context.Productos.Include(p => p.ProductoDetalles).AsNoTracking().FirstOrDefault(p => p.ProductoId == id);

        }
        catch (System.Exception ex)
        {
            throw;
        }

    }

    public List<Productos> GetList(Expression<Func<Productos, bool>> criterio)
    {

        try
        {
            return _context.Productos.Where(criterio).Include(p => p.ProductoDetalles).AsNoTracking().ToList();
        }
        catch (System.Exception ex)
        {
            throw;
        }
    }

    public List<ProductoDetallesPresentacion> GetListProductoDetallesPresentacion(Expression<Func<ProductoDetallesPresentacion, bool>> criterio)
    {
        try
        {
            return _context.ProductoDetallesPresentacion.Where(criterio).AsNoTracking().ToList();
        }
        catch (System.Exception ex)
        {
            throw;
        }
    }

    public List<ProductoDetalles> GetListProductoDetalles(Expression<Func<ProductoDetalles, bool>> criterio)
    {
        try
        {
            return _context.ProductoDetalles.Where(criterio).AsNoTracking().ToList();
        }
        catch (System.Exception ex)
        {
            throw;
        }
    }


    public ProductoDetalles? BuscarProductoDetalle(int? id)
    {

        try
        {
            return _context.ProductoDetalles.Include(p => p.Producto).FirstOrDefault(p => p.ProductoDetallesId == id);
        }
        catch (System.Exception ex)
        {
            throw;
        }

    }
    public bool ActualizarProductoDetalle(ProductoDetalles productoDetalle)
    {
        try
        {
            _context.Update(productoDetalle);
            var response = _context.SaveChanges() > 0;
            return response;
        }
        catch (System.Exception ex)
        {
            throw;
        }
    }
    
    public bool  ModificarProductoDetalle(ProductoDetalles productoDetalle)
    {

        try
        {
            _context.Update(productoDetalle);
            var response = _context.SaveChanges() > 0;
            return response;
        }
        catch (System.Exception ex)
        {
            throw;
        }
    }

}

