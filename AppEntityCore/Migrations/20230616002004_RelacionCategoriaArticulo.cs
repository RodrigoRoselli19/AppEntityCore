using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppEntityCore.Migrations
{
    public partial class RelacionCategoriaArticulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "articulo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_articulo_CategoriaId",
                table: "articulo",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_articulo_categoria_CategoriaId",
                table: "articulo",
                column: "CategoriaId",
                principalTable: "categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_articulo_categoria_CategoriaId",
                table: "articulo");

            migrationBuilder.DropIndex(
                name: "IX_articulo_CategoriaId",
                table: "articulo");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "articulo");
        }
    }
}
