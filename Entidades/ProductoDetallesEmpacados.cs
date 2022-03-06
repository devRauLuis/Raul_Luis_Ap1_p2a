namespace ProductsBlazor.Entidades;
public class ProductoDetallesEmpacados
{
    public int ProductoDetallesId { get; set; }
    public string? Descripcion { get; set; }
    public string? Presentacion { get; set; }
    public float? Cantidad { get; set; }
    public float? Precio { get; set; }
    public int ProductoId { get; set; }
    public float ExistenciaEmpacada { get; set; }
}
