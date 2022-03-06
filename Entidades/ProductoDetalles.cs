using System.ComponentModel.DataAnnotations;
namespace ProductsBlazor.Entidades;

public class ProductoDetalles
{

    [Key]
    public int ProductoDetallesId { get; set; }

    [Required]
    [MaxLength(50, ErrorMessage = "La presentacion no puede exceder {1} caracteres")]
    [MinLength(3, ErrorMessage = "La presentacion al menos {1} caracteres")]
    public string? Presentacion { get; set; }

    [Required]
    [Range(0, float.MaxValue, ErrorMessage = "El costo debe ser mayor a {1} y menor a {2}")]
    public float? Cantidad { get; set; }

    [Required]
    [Range(0, float.MaxValue, ErrorMessage = "El precio debe ser mayor a {1} y menor a {2}")]
    public float? Precio { get; set; }
    public Productos Producto { get; set; }




}