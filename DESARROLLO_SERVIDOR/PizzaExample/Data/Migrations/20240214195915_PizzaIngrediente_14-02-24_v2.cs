using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaExample.Data.Migrations
{
    public partial class PizzaIngrediente_140224_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaIngrediente_Ingredients_IngredienteId",
                table: "PizzaIngrediente");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaIngrediente_Pizzas_PizzaId",
                table: "PizzaIngrediente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PizzaIngrediente",
                table: "PizzaIngrediente");

            migrationBuilder.RenameTable(
                name: "PizzaIngrediente",
                newName: "PizzaIngredients");

            migrationBuilder.RenameIndex(
                name: "IX_PizzaIngrediente_IngredienteId",
                table: "PizzaIngredients",
                newName: "IX_PizzaIngredients_IngredienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PizzaIngredients",
                table: "PizzaIngredients",
                columns: new[] { "PizzaId", "IngredienteId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaIngredients_Ingredients_IngredienteId",
                table: "PizzaIngredients",
                column: "IngredienteId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaIngredients_Pizzas_PizzaId",
                table: "PizzaIngredients",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaIngredients_Ingredients_IngredienteId",
                table: "PizzaIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaIngredients_Pizzas_PizzaId",
                table: "PizzaIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PizzaIngredients",
                table: "PizzaIngredients");

            migrationBuilder.RenameTable(
                name: "PizzaIngredients",
                newName: "PizzaIngrediente");

            migrationBuilder.RenameIndex(
                name: "IX_PizzaIngredients_IngredienteId",
                table: "PizzaIngrediente",
                newName: "IX_PizzaIngrediente_IngredienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PizzaIngrediente",
                table: "PizzaIngrediente",
                columns: new[] { "PizzaId", "IngredienteId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaIngrediente_Ingredients_IngredienteId",
                table: "PizzaIngrediente",
                column: "IngredienteId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaIngrediente_Pizzas_PizzaId",
                table: "PizzaIngrediente",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
