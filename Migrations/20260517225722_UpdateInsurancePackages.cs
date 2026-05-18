using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Safeish.Migrations
{
    /// <inheritdoc />
    public partial class UpdateInsurancePackages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoverageAmount", "Features", "Name", "Price" },
                values: new object[] { 50000m, "Sadece Yatarak Tedavi, Acil Durum Teminatı", "Temel Sağlık", 3000m });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoverageAmount", "Features", "Name", "Price" },
                values: new object[] { 150000m, "Yatarak Tedavi, Ayakta Tedavi (Limitli), Check-up", "Standart Sağlık", 6000m });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoverageAmount", "Features", "InsuranceTypeId", "Name", "Price" },
                values: new object[] { 500000m, "Yatarak Tedavi, Sınırsız Ayakta Tedavi, Diş ve Göz, Yurtdışı Kapsamı", 1, "Premium Sağlık", 12000m });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoverageAmount", "Features", "InsuranceTypeId", "Name", "Price" },
                values: new object[] { 250000m, "Çarpışma, Çalınma, Asistans Hizmeti", 2, "Temel Kasko", 4000m });

            migrationBuilder.InsertData(
                table: "InsurancePackages",
                columns: new[] { "Id", "CoverageAmount", "Features", "InsuranceTypeId", "Name", "Price" },
                values: new object[,]
                {
                    { 5, 500000m, "Çarpışma, Çalınma, İkame Araç, Doğal Afetler", 2, "Standart Kasko", 7500m },
                    { 6, 1000000m, "Tüm Kapsamlar, Sınırsız İkame Araç, Hatalı Akaryakıt, Kilit Değişimi", 2, "Premium Kasko", 11000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoverageAmount", "Features", "Name", "Price" },
                values: new object[] { 100000m, "Ayakta Tedavi, Yatarak Tedavi", "Standart Sağlık", 5000m });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoverageAmount", "Features", "Name", "Price" },
                values: new object[] { 500000m, "Ayakta Tedavi, Yatarak Tedavi, Diş, Göz", "VIP Sağlık", 12000m });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoverageAmount", "Features", "InsuranceTypeId", "Name", "Price" },
                values: new object[] { 800000m, "Çarpışma, Çalınma, Doğal Afet, İkame Araç", 2, "Genişletilmiş Kasko", 8000m });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CoverageAmount", "Features", "InsuranceTypeId", "Name", "Price" },
                values: new object[] { 300000m, "Deprem Hasarı", 3, "Standart DASK", 500m });
        }
    }
}
