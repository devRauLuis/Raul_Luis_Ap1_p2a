using System.ComponentModel.DataAnnotations;
namespace Raul_Luis_Ap2_p2a.Entidades;

public class ProductosEmpacados
{

    [Key]
    public int? ProductosEmpacadosId { get; set; }

    [Required]
    [MaxLength(80, ErrorMessage = "El concepto no puede exceder {1} caracteres")]
    [MinLength(3, ErrorMessage = "El concepto debe tener al menos {1} caracteres")]
    public string? Concepto { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime? Fecha { get; set; } = DateTime.Now;

    [Required]
    public ICollection<PDPUtilizados>? Utilizados { get; set; }

    public Productos? Producido { get; set; }

}