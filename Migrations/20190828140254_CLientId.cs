using Microsoft.EntityFrameworkCore.Migrations;

namespace final.Migrations
{
    public partial class CLientId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Clientes",
                newName: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Clientes",
                newName: "ID");
        }
    }
}
