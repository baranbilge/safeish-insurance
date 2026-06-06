using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Safeish.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSeededPackages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 9);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InsurancePackages",
                columns: new[] { "Id", "CoverageAmount", "Features", "InsuranceTypeId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 50000m, "Yatarak Tedavi Kapsamı (Sınırlı), Acil Durum Ambulans Hizmeti", 1, "Temel Sağlık", 3000m },
                    { 2, 150000m, "Temel Kapsamlar, Yılda 10 Kez Ayakta Tedavi, %80 İlaç Katılım Payı", 1, "Standart Sağlık", 6000m },
                    { 3, 500000m, "Sınırsız Ayakta ve Yatarak Tedavi, Diş ve Göz Muayenesi, Yurtdışı Teminatı, Özel Oda Giderleri, Check-up", 1, "Premium Sağlık", 12000m },
                    { 4, 250000m, "Çarpışma, Çalınma, Araç Yanması, Yılda 1 Kez Çekici Hizmeti", 2, "Temel Kasko", 4000m },
                    { 5, 500000m, "Temel Kapsamlar, Cam Kırılması, Mini Onarım, 7 Gün İkame Araç", 2, "Standart Kasko", 7500m },
                    { 6, 1000000m, "Tüm Kapsamlar, Sınırsız İkame Araç, Hatalı Akaryakıt Dolumu, Orjinal Yedek Parça, Doğal Afetler", 2, "Premium Kasko", 11000m },
                    { 7, 500000m, "Yangın, Deprem (DASK Kapsamı Dışı), Yer Kayması", 3, "Temel Konut", 2500m },
                    { 8, 1500000m, "Temel Kapsamlar, Hırsızlık, Su Baskını, Cam Kırılması", 3, "Standart Konut", 4500m },
                    { 9, 3000000m, "Tüm Kapsamlar, Eşya Güvencesi, İzolasyon Hasarları, Ücretsiz Çilingir ve Tesisatçı", 3, "Premium Konut", 8000m }
                });
        }
    }
}
