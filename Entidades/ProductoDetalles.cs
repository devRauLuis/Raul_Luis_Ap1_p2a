using System.ComponentModel.DataAnnotations;
namespace Raul_Luis_Ap2_p2a.Entidades;

public class ProductoDetalles
{

    [Key]
    public int ProductoDetallesId { get; set; }

    [MaxLength(80, ErrorMessage = "La presentacion no puede exceder {1} caracteres")]
    [MinLength(3, ErrorMessage = "La presentacion debe tener al menos {1} caracteres")]
    public string? Presentacion { get; set; }

    [Range(0, float.MaxValue, ErrorMessage = "El costo debe ser mayor a {1} y menor a {2}")]
    public float? Cantidad { get; set; }

    [Range(0, float.MaxValue, ErrorMessage = "El precio debe ser mayor a {1} y menor a {2}")]
    public float? Precio { get; set; }

    [Range(0, float.MaxValue, ErrorMessage = "El peso debe ser mayor a {1} y menor a {2}")]
    public float? Peso { get; set; }

    public int? ProductoId { get; set; }
    public Productos? Producto { get; set; }

}