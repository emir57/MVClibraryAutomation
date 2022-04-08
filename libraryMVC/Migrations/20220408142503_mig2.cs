using Microsoft.EntityFrameworkCore.Migrations;

namespace site.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UyeEposta",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Kitaplar",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Kitaplar");

            migrationBuilder.AddColumn<string>(
                name: "UyeEposta",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);
        }
    }
}
