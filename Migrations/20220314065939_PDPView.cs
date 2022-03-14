using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Raul_Luis_Ap2_p2a.Migrations
{
    public partial class PDPView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
CREATE VIEW ProductoDetallesPresentacion AS
SELECT pd.*, p.Descripcion, case when round((p.Existencia/pd.Cantidad)-0.5) < 0 then 0 else round((p.Existencia/pd.Cantidad)-0.5) END AS ExistenciaEmpacada FROM Productos p INNER JOIN ProductoDetalles pd ON p.ProductoId == pd.ProductoId;
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
drop view ProductoDetallesPresentacion;
");
        }
    }
}
