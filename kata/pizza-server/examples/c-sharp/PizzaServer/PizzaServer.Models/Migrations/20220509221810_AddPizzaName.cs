using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaServer.Models.Migrations
{
    public partial class AddPizzaName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Pizzas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Pizzas");
        }
    }
}
