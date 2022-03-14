using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Raul_Luis_Ap2_p2a.Migrations
{
    public partial class UpdatePDP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductoDetallesId",
                table: "PDPUtilizados",
                type: "INTEGER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductoDetallesId",
                table: "PDPUtilizados");
        }
    }
}
