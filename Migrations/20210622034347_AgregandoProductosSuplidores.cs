using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroPedidos.Migrations
{
    public partial class AgregandoProductosSuplidores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Costo", "Descripcion", "Inventario" },
                values: new object[] { 1, 10.0, "Pan", 15 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Costo", "Descripcion", "Inventario" },
                values: new object[] { 2, 150.0, "Café", 10 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Costo", "Descripcion", "Inventario" },
                values: new object[] { 3, 210.0, "Cremola", 5 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Costo", "Descripcion", "Inventario" },
                values: new object[] { 4, 20.0, "Azúcar", 17 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Costo", "Descripcion", "Inventario" },
                values: new object[] { 5, 5.0, "Chupeta", 25 });

            migrationBuilder.InsertData(
                table: "Suplidores",
                columns: new[] { "SuplidorId", "Nombres" },
                values: new object[] { 1, "Ernesto Juan" });

            migrationBuilder.InsertData(
                table: "Suplidores",
                columns: new[] { "SuplidorId", "Nombres" },
                values: new object[] { 2, "Kamila Santos" });

            migrationBuilder.InsertData(
                table: "Suplidores",
                columns: new[] { "SuplidorId", "Nombres" },
                values: new object[] { 3, "Enel Brito" });

            migrationBuilder.InsertData(
                table: "Suplidores",
                columns: new[] { "SuplidorId", "Nombres" },
                values: new object[] { 4, "Robinson Manuel" });

            migrationBuilder.InsertData(
                table: "Suplidores",
                columns: new[] { "SuplidorId", "Nombres" },
                values: new object[] { 5, "Candy Sarante" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Suplidores",
                keyColumn: "SuplidorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suplidores",
                keyColumn: "SuplidorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suplidores",
                keyColumn: "SuplidorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suplidores",
                keyColumn: "SuplidorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Suplidores",
                keyColumn: "SuplidorId",
                keyValue: 5);
        }
    }
}
