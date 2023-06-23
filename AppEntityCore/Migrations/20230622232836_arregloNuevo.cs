using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppEntityCore.Migrations
{
    public partial class arregloNuevo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_Categoria_CategoriaId",
                table: "Articulo");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticuloEtiqueta_Articulo_ArticuloId",
                table: "ArticuloEtiqueta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articulo",
                table: "Articulo");

            migrationBuilder.RenameTable(
                name: "Articulo",
                newName: "Articulos");

            migrationBuilder.RenameIndex(
                name: "IX_Articulo_CategoriaId",
                table: "Articulos",
                newName: "IX_Articulos_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articulos",
                table: "Articulos",
                column: "IdArticulo");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticuloEtiqueta_Articulos_ArticuloId",
                table: "ArticuloEtiqueta",
                column: "ArticuloId",
                principalTable: "Articulos",
                principalColumn: "IdArticulo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Categoria_CategoriaId",
                table: "Articulos",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticuloEtiqueta_Articulos_ArticuloId",
                table: "ArticuloEtiqueta");

            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Categoria_CategoriaId",
                table: "Articulos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articulos",
                table: "Articulos");

            migrationBuilder.RenameTable(
                name: "Articulos",
                newName: "Articulo");

            migrationBuilder.RenameIndex(
                name: "IX_Articulos_CategoriaId",
                table: "Articulo",
                newName: "IX_Articulo_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articulo",
                table: "Articulo",
                column: "IdArticulo");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_Categoria_CategoriaId",
                table: "Articulo",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticuloEtiqueta_Articulo_ArticuloId",
                table: "ArticuloEtiqueta",
                column: "ArticuloId",
                principalTable: "Articulo",
                principalColumn: "IdArticulo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
