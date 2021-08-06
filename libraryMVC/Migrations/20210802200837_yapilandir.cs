using Microsoft.EntityFrameworkCore.Migrations;

namespace site.Migrations
{
    public partial class yapilandir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emanetler",
                columns: table => new
                {
                    EmanetNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UyeNo = table.Column<int>(type: "INTEGER", nullable: false),
                    KitapNo = table.Column<int>(type: "INTEGER", nullable: false),
                    EmanetVermeTarih = table.Column<string>(type: "TEXT", nullable: true),
                    EmanetGeriAlmaTarih = table.Column<string>(type: "TEXT", nullable: true),
                    EmanetIslemTarih = table.Column<string>(type: "TEXT", nullable: true),
                    EmanetNot = table.Column<string>(type: "TEXT", nullable: true),
                    EmanetTeslimEdildi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emanetler", x => x.EmanetNo);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    KitapNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KitapAd = table.Column<string>(type: "TEXT", nullable: true),
                    KitapYazari = table.Column<string>(type: "TEXT", nullable: true),
                    KitapBaskiYil = table.Column<int>(type: "INTEGER", nullable: false),
                    KitapSayfaSayi = table.Column<int>(type: "INTEGER", nullable: false),
                    KitapDil = table.Column<string>(type: "TEXT", nullable: true),
                    KitapYayinEvi = table.Column<string>(type: "TEXT", nullable: true),
                    KitapAciklama = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.KitapNo);
                });

            migrationBuilder.CreateTable(
                name: "Uyeler",
                columns: table => new
                {
                    UyeNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UyeAd = table.Column<string>(type: "TEXT", nullable: true),
                    UyeSoyad = table.Column<string>(type: "TEXT", nullable: true),
                    UyeTelefon = table.Column<string>(type: "TEXT", nullable: true),
                    UyeEposta = table.Column<string>(type: "TEXT", nullable: true),
                    UyeAdres = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyeler", x => x.UyeNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emanetler");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Uyeler");
        }
    }
}
