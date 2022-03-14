using System.ComponentModel.DataAnnotations;

namespace Raul_Luis_Ap2_p2a.Entidades;
public class ProductoDetallesPresentacion
{
    public int? ProductoDetallesId { get; set; }
    public string? Descripcion { get; set; }
    public string? Presentacion { get; set; }
    public float? Cantidad { get; set; }
    public float? Precio { get; set; }
    public float? Peso { get; set; }
    public int? ProductoId { get; set; }
    public float? ExistenciaEmpacada { get; set; }

}
