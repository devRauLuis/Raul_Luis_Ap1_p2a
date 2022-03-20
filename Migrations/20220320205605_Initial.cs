using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Raul_Luis_Ap2_p2a.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Existencia = table.Column<int>(type: "INTEGER", nullable: true),
                    Costo = table.Column<float>(type: "REAL", nullable: false),
                    ValorInventario = table.Column<float>(type: "REAL", nullable: true),
                    Precio = table.Column<float>(type: "REAL", nullable: false),
                    Ganancia = table.Column<float>(type: "REAL", nullable: true),
                    FechaExpiracion = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Peso = table.Column<float>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                });

            migrationBuilder.CreateTable(
                name: "ProductoDetalles",
                columns: table => new
                {
                    ProductoDetallesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Presentacion = table.Column<string>(type: "TEXT", maxLength: 80, nullable: true),
                    Cantidad = table.Column<float>(type: "REAL", nullable: true),
                    Precio = table.Column<float>(type: "REAL", nullable: true),
                    Peso = table.Column<float>(type: "REAL", nullable: true),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoDetalles", x => x.ProductoDetallesId);
                    table.ForeignKey(
                        name: "FK_ProductoDetalles_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId");
                });

            migrationBuilder.CreateTable(
                name: "ProductosEmpacados",
                columns: table => new
                {
                    ProductosEmpacadosId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Concepto = table.Column<string>(type: "TEXT", maxLength: 80, nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProducidoProductoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosEmpacados", x => x.ProductosEmpacadosId);
                    table.ForeignKey(
                        name: "FK_ProductosEmpacados_Productos_ProducidoProductoId",
                        column: x => x.ProducidoProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId");
                });

            migrationBuilder.CreateTable(
                name: "PDPUtilizados",
                columns: table => new
                {
                    PDPUtilizadosId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CantidadUtilizada = table.Column<int>(type: "INTEGER", nullable: true),
                    ProductoDetallesId = table.Column<int>(type: "INTEGER", nullable: true),
                    ProductosEmpacadosId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PDPUtilizados", x => x.PDPUtilizadosId);
                    table.ForeignKey(
                        name: "FK_PDPUtilizados_ProductosEmpacados_ProductosEmpacadosId",
                        column: x => x.ProductosEmpacadosId,
                        principalTable: "ProductosEmpacados",
                        principalColumn: "ProductosEmpacadosId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PDPUtilizados_ProductosEmpacadosId",
                table: "PDPUtilizados",
                column: "ProductosEmpacadosId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoDetalles_ProductoId",
                table: "ProductoDetalles",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosEmpacados_ProducidoProductoId",
                table: "ProductosEmpacados",
                column: "ProducidoProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PDPUtilizados");

            migrationBuilder.DropTable(
                name: "ProductoDetalles");

            migrationBuilder.DropTable(
                name: "ProductosEmpacados");

            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
