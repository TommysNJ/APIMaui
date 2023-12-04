using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIMaui.Migrations
{
    /// <inheritdoc />
    public partial class FinalizarAPI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Producto");

            migrationBuilder.RenameColumn(
                name: "Cantidad",
                table: "Producto",
                newName: "cantidad");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cantidad",
                table: "Producto",
                newName: "Cantidad");

            migrationBuilder.AddColumn<float>(
                name: "Precio",
                table: "Producto",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 1,
                column: "Precio",
                value: 12f);
        }
    }
}
