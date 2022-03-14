using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Raul_Luis_Ap2_p2a.Migrations
{
    public partial class UpdateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PDPUtilizados_ProductoDetalles_ProductoDetallesId",
                table: "PDPUtilizados");

            migrationBuilder.DropIndex(
                name: "IX_PDPUtilizados_ProductoDetallesId",
                table: "PDPUtilizados");

            migrationBuilder.DropColumn(
                name: "ProductoDetallesId",
                table: "PDPUtilizados");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductoDetallesId",
                table: "PDPUtilizados",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PDPUtilizados_ProductoDetallesId",
                table: "PDPUtilizados",
                column: "ProductoDetallesId");

            migrationBuilder.AddForeignKey(
                name: "FK_PDPUtilizados_ProductoDetalles_ProductoDetallesId",
                table: "PDPUtilizados",
                column: "ProductoDetallesId",
                principalTable: "ProductoDetalles",
                principalColumn: "ProductoDetallesId");
        }
    }
}
