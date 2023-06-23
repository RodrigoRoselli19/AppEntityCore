using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppEntityCore.Migrations
{
    public partial class RelacionUnoAUnoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_articulo_categoria_CategoriaId",
                table: "articulo");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_categoria_CategoriaId",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categoria",
                table: "categoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_articulo",
                table: "articulo");

            migrationBuilder.RenameTable(
                name: "categoria",
                newName: "Categoria");

            migrationBuilder.RenameTable(
                name: "articulo",
                newName: "Articulo");

            migrationBuilder.RenameIndex(
                name: "IX_articulo_CategoriaId",
                table: "Articulo",
                newName: "IX_Articulo_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articulo",
                table: "Articulo",
                column: "IdArticulo");

            migrationBuilder.CreateTable(
                name: "DetalleUsuario",
                columns: table => new
                {
                    DetalleUsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    Deporte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mascota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleUsuario", x => x.DetalleUsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: true),
                    DetalleUsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_DetalleUsuario_DetalleUsuarioId",
                        column: x => x.DetalleUsuarioId,
                        principalTable: "DetalleUsuario",
                        principalColumn: "DetalleUsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_DetalleUsuarioId",
                table: "Usuario",
                column: "DetalleUsuarioId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_Categoria_CategoriaId",
                table: "Articulo",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categoria_CategoriaId",
                table: "Productos",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_Categoria_CategoriaId",
                table: "Articulo");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categoria_CategoriaId",
                table: "Productos");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "DetalleUsuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articulo",
                table: "Articulo");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "categoria");

            migrationBuilder.RenameTable(
                name: "Articulo",
                newName: "articulo");

            migrationBuilder.RenameIndex(
                name: "IX_Articulo_CategoriaId",
                table: "articulo",
                newName: "IX_articulo_CategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categoria",
                table: "categoria",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_articulo",
                table: "articulo",
                column: "IdArticulo");

            migrationBuilder.AddForeignKey(
                name: "FK_articulo_categoria_CategoriaId",
                table: "articulo",
                column: "CategoriaId",
                principalTable: "categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_categoria_CategoriaId",
                table: "Productos",
                column: "CategoriaId",
                principalTable: "categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
