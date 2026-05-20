using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Safeish.Migrations
{
    /// <inheritdoc />
    public partial class UpdateKonutSigortasiAndPackages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Features",
                value: "Yatarak Tedavi Kapsamı (Sınırlı), Acil Durum Ambulans Hizmeti");

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Features",
                value: "Temel Kapsamlar, Yılda 10 Kez Ayakta Tedavi, %80 İlaç Katılım Payı");

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Features",
                value: "Sınırsız Ayakta ve Yatarak Tedavi, Diş ve Göz Muayenesi, Yurtdışı Teminatı, Özel Oda Giderleri, Check-up");

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Features",
                value: "Çarpışma, Çalınma, Araç Yanması, Yılda 1 Kez Çekici Hizmeti");

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Features",
                value: "Temel Kapsamlar, Cam Kırılması, Mini Onarım, 7 Gün İkame Araç");

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Features",
                value: "Tüm Kapsamlar, Sınırsız İkame Araç, Hatalı Akaryakıt Dolumu, Orjinal Yedek Parça, Doğal Afetler");

            migrationBuilder.InsertData(
                table: "InsurancePackages",
                columns: new[] { "Id", "CoverageAmount", "Features", "InsuranceTypeId", "Name", "Price" },
                values: new object[,]
                {
                    { 7, 500000m, "Yangın, Deprem (DASK Kapsamı Dışı), Yer Kayması", 3, "Temel Konut", 2500m },
                    { 8, 1500000m, "Temel Kapsamlar, Hırsızlık, Su Baskını, Cam Kırılması", 3, "Standart Konut", 4500m },
                    { 9, 3000000m, "Tüm Kapsamlar, Eşya Güvencesi, İzolasyon Hasarları, Ücretsiz Çilingir ve Tesisatçı", 3, "Premium Konut", 8000m }
                });

            migrationBuilder.UpdateData(
                table: "InsuranceTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Eviniz için tam koruma", "Konut Sigortası" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "InsuranceTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Zorunlu deprem sigortası", "DASK" });
        }
    }
}
