using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Raul_Luis_Ap2_p2a.DAL;
using Raul_Luis_Ap2_p2a.Entidades;

namespace Raul_Luis_Ap2_p2a.BLL;

public class ProductosEmpacadosBLL
{

    private ProductsContext _context;

    public ProductosEmpacadosBLL(ProductsContext context)
    {
        _context = context;
    }

    public bool Existe(int id)
    {
        try
        {
            return _context.ProductosEmpacados.AsNoTracking().Any(p => p.ProductosEmpacadosId == id);

        }
        catch (System.Exception ex)
        {
            throw;
        }
    }

    public bool Guardar(ProductosEmpacados productoEmpacado)
    {

        try
        {
            var id = productoEmpacado.ProductosEmpacadosId;
            return !Existe(id != null ? (int)id : 0) ? Insertar(productoEmpacado) : Modificar(productoEmpacado);
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            throw;
        }
    }

    public bool Insertar(ProductosEmpacados productosEmpacados)
    {
        try
        {
            _context.Entry(productosEmpacados).State = EntityState.Added;
            _context.SaveChanges();
            return true;
        }
        catch (System.Exception)
        {
            return false;
        }
    }

    private bool Modificar(ProductosEmpacados productoEmpacado)
    {

        try
        {
            _context.Entry(productoEmpacado).State = EntityState.Modified;
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
        var productoEmpacado = Buscar(id);

        if (productoEmpacado is not null)
        {
            try
            {
                _context.ProductosEmpacados.Remove(productoEmpacado);
                return _context.SaveChanges() > 0;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        return false;
    }

    public ProductosEmpacados? Buscar(int id)
    {

        try
        {
            return _context.ProductosEmpacados.Include(pe => pe.Utilizados).Include(pe => pe.Producido).ThenInclude(pd => pd.Producto).AsNoTracking().FirstOrDefault(p => p.ProductosEmpacadosId == id);
        }
        catch (System.Exception ex)
        {
            throw;
        }

    }

    public List<ProductosEmpacados> GetList(Expression<Func<ProductosEmpacados, bool>> criterio)
    {

        try
        {
            return _context.ProductosEmpacados.Where(criterio).Include(pe => pe.Utilizados).AsNoTracking().ToList();
        }
        catch (System.Exception ex)
        {
            throw;
        }
    }

}