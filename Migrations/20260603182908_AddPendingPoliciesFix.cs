using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Safeish.Migrations
{
    /// <inheritdoc />
    public partial class AddPendingPoliciesFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserPolicies",
                columns: new[] { "Id", "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 2001, new DateTime(2025, 6, 3, 12, 0, 0, 0, DateTimeKind.Utc), 1, false, "Tamamlayıcı", new DateTime(2024, 6, 3, 12, 0, 0, 0, DateTimeKind.Utc), "Görüşme bekleniyor", 1001 },
                    { 2002, new DateTime(2025, 6, 3, 12, 0, 0, 0, DateTimeKind.Utc), 5, false, "Genişletilmiş Kasko", new DateTime(2024, 6, 3, 12, 0, 0, 0, DateTimeKind.Utc), "Görüşme bekleniyor", 1002 },
                    { 2003, new DateTime(2025, 6, 3, 12, 0, 0, 0, DateTimeKind.Utc), 14, false, "Avrupa Vize", new DateTime(2024, 6, 3, 12, 0, 0, 0, DateTimeKind.Utc), "Görüşme bekleniyor", 1003 },
                    { 2004, new DateTime(2025, 6, 3, 12, 0, 0, 0, DateTimeKind.Utc), 13, false, "Yurt İçi", new DateTime(2024, 6, 3, 12, 0, 0, 0, DateTimeKind.Utc), "Görüşme bekleniyor", 1004 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 2004);
        }
    }
}
