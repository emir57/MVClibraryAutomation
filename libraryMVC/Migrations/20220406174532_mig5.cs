using Microsoft.EntityFrameworkCore.Migrations;

namespace site.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UyeNo",
                table: "Emanetler",
                newName: "UyeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UyeId",
                table: "Emanetler",
                newName: "UyeNo");
        }
    }
}
