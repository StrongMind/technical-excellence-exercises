using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaServer.Models.Migrations
{
    public partial class ToppingName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Toppings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Toppings");
        }
    }
}
