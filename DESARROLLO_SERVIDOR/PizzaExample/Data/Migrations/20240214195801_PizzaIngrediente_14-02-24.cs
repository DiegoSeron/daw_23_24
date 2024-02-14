using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaExample.Data.Migrations
{
    public partial class PizzaIngrediente_140224 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Pizzas_PizzaId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_PizzaId",
                table: "Ingredients");

            migrationBuilder.CreateTable(
                name: "PizzaIngrediente",
                columns: table => new
                {
                    PizzaId = table.Column<int>(type: "int", nullable: false),
                    IngredienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaIngrediente", x => new { x.PizzaId, x.IngredienteId });
                    table.ForeignKey(
                        name: "FK_PizzaIngrediente_Ingredients_IngredienteId",
                        column: x => x.IngredienteId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PizzaIngrediente_Pizzas_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizzas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PizzaIngrediente",
                columns: new[] { "IngredienteId", "PizzaId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 4, 1 },
                    { 1, 2 },
                    { 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PizzaIngrediente_IngredienteId",
                table: "PizzaIngrediente",
                column: "IngredienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaIngrediente");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_PizzaId",
                table: "Ingredients",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Pizzas_PizzaId",
                table: "Ingredients",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
