using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

using ProductsBlazor.DAL;
using ProductsBlazor.Entidades;

namespace ProductsBlazor.BLL;
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
            return _context.Productos.Any(p => p.ProductoId == id);

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

    public bool Insertar(Productos producto)
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

    public bool Modificar(Productos producto)
    {

        try
        {
            _context.Entry(producto).State = EntityState.Modified;
            return _context.SaveChanges() > 0;

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
                _context.Productos.Remove(producto);
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
            return _context.Productos.Find(id);

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
            return _context.Productos.Where(criterio).Include(p => p.ProductoDetalles).ToList();
        }
        catch (System.Exception ex)
        {
            throw;
        }
    }

    public List<ProductoDetallesEmpacados> GetListProductoDetallesEmpacados(Expression<Func<ProductoDetallesEmpacados, bool>> criterio)
    {
        try
        {
            return _context.ProductoDetallesEmpacados.Where(criterio).ToList();
        }
        catch (System.Exception ex)
        {
            throw;
        }
    }
}

