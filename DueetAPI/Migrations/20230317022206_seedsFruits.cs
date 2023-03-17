using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DueetAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedsFruits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fruit",
                columns: new[] { "Id", "description", "name", "tax", "value" },
                values: new object[,]
                {
                    { 1, "Maçã fresquinha, direto do pomar para a sua mesa!", "Maça", 20.3m, 1.45m },
                    { 2, "Banana madura e doce, perfeita para lanches e sobremesas.", "Banana", 18.5m, 2.35m },
                    { 3, "Morangos vermelhos e suculentos, ideais para saladas e doces.", "Morango", 22.7m, 3.15m },
                    { 4, "Pera fresca e crocante, perfeita para comer ao natural ou em saladas.", "Pera", 21.2m, 1.95m },
                    { 5, "Laranjas suculentas e doces, ricas em vitamina C.", "Laranja", 20.5m, 1.85m },
                    { 6, "Abacaxi fresco e doce, ideal para sucos e sobremesas.", "Abacaxi", 26.8m, 4.25m },
                    { 7, "Uvas maduras e saborosas, perfeitas para comer ao natural ou em sobremesas.", "Uva", 25.4m, 3.95m },
                    { 8, "Manga doce e suculenta, ideal para sucos e sobremesas.", "Manga", 19.8m, 2.75m },
                    { 9, "Kiwi fresco e ácido, rico em vitamina C e ideal para saladas.", "Kiwi", 17.6m, 2.15m },
                    { 10, "Abacaxi tropical, suculento e doce, perfeito para o verão!", "Abacaxi", 15.8m, 4.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fruit",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fruit",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fruit",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fruit",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fruit",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fruit",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Fruit",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Fruit",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Fruit",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Fruit",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
