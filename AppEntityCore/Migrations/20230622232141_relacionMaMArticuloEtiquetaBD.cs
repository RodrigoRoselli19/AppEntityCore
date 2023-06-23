using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppEntityCore.Migrations
{
    public partial class relacionMaMArticuloEtiquetaBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Etiquetas",
                columns: table => new
                {
                    EtiquetaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etiquetas", x => x.EtiquetaId);
                });

            migrationBuilder.CreateTable(
                name: "pedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaPedido = table.Column<DateTime>(type: "datatime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedido", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticuloEtiqueta",
                columns: table => new
                {
                    ArticuloId = table.Column<int>(type: "int", nullable: false),
                    EtiquetaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloEtiqueta", x => new { x.EtiquetaId, x.ArticuloId });
                    table.ForeignKey(
                        name: "FK_ArticuloEtiqueta_Articulo_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "Articulo",
                        principalColumn: "IdArticulo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticuloEtiqueta_Etiquetas_EtiquetaId",
                        column: x => x.EtiquetaId,
                        principalTable: "Etiquetas",
                        principalColumn: "EtiquetaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloEtiqueta_ArticuloId",
                table: "ArticuloEtiqueta",
                column: "ArticuloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticuloEtiqueta");

            migrationBuilder.DropTable(
                name: "pedido");

            migrationBuilder.DropTable(
                name: "Etiquetas");
        }
    }
}
