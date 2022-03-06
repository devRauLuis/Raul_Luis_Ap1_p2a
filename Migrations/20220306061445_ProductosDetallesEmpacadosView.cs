using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductsBlazor.Migrations
{
    public partial class ProductosDetallesEmpacadosView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
CREATE VIEW ProductoDetallesEmpacados AS
SELECT pd.*, p.Descripcion, round((p.Existencia/pd.Cantidad)-0.5) AS ExistenciaEmpacada FROM Productos p INNER JOIN ProductoDetalles pd ON p.ProductoId == pd.ProductoId;
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
drop view ProductoDetallesEmpacados;
");
        }
    }
}
