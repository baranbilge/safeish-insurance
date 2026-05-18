using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Safeish.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRealisticFeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Features",
                value: "Yatarak Tedavi Kapsamı, Yoğun Bakım Teminatı, Acil Durum Ambulans Hizmeti, Suni Uzuv Teminatı");

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Features",
                value: "Temel Kapsamlar, Yılda 10 Kez Ayakta Tedavi, Ücretsiz Check-up, %80 İlaç Katılım Payı");

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Features",
                value: "Sınırsız Ayakta ve Yatarak Tedavi, Diş ve Göz Muayenesi, Yurtdışı Teminatı, Özel Oda Giderleri");

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Features",
                value: "Çarpışma ve Çalınma, Araç Yanması, Yılda 1 Kez Çekici Hizmeti, Anahtar Kaybı (Limitli)");

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Features",
                value: "Temel Kapsamlar, Cam Kırılması, Mini Onarım, 7 Gün İkame Araç, Doğal Afetler");

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Features",
                value: "Tüm Kapsamlar, Sınırsız İkame Araç, Hatalı Akaryakıt Dolumu, Orjinal Yedek Parça");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Features",
                value: "Sadece Yatarak Tedavi, Acil Durum Teminatı");

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Features",
                value: "Yatarak Tedavi, Ayakta Tedavi (Limitli), Check-up");

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Features",
                value: "Yatarak Tedavi, Sınırsız Ayakta Tedavi, Diş ve Göz, Yurtdışı Kapsamı");

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Features",
                value: "Çarpışma, Çalınma, Asistans Hizmeti");

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Features",
                value: "Çarpışma, Çalınma, İkame Araç, Doğal Afetler");

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Features",
                value: "Tüm Kapsamlar, Sınırsız İkame Araç, Hatalı Akaryakıt, Kilit Değişimi");
        }
    }
}
