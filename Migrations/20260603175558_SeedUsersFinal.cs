using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Safeish.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "AlternativePhoneNumber", "CreatedAt", "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber", "ResetPasswordToken", "ResetPasswordTokenExpiry", "Role" },
                values: new object[,]
                {
                    { 1001, null, null, new DateTime(2024, 8, 25, 11, 55, 0, 0, DateTimeKind.Utc), "mert.çelik1@example.com", "Mert", "Çelik", "AQAAAAIAAYagAAAAEPQAAA", "05056495562", null, null, "User" },
                    { 1002, null, null, new DateTime(2024, 6, 27, 12, 52, 0, 0, DateTimeKind.Utc), "burak.öztürk2@example.com", "Burak", "Öztürk", "AQAAAAIAAYagAAAAEPQAAA", "05434457977", null, null, "User" },
                    { 1003, null, null, new DateTime(2024, 6, 23, 17, 38, 0, 0, DateTimeKind.Utc), "gizem.şimşek3@example.com", "Gizem", "Şimşek", "AQAAAAIAAYagAAAAEPQAAA", "05336553620", null, null, "User" },
                    { 1004, null, null, new DateTime(2024, 2, 24, 13, 27, 0, 0, DateTimeKind.Utc), "elif.doğan4@example.com", "Elif", "Doğan", "AQAAAAIAAYagAAAAEPQAAA", "05553472513", null, null, "User" },
                    { 1005, null, null, new DateTime(2024, 4, 1, 17, 25, 0, 0, DateTimeKind.Utc), "deniz.kurt5@example.com", "Deniz", "Kurt", "AQAAAAIAAYagAAAAEPQAAA", "05328098949", null, null, "User" },
                    { 1006, null, null, new DateTime(2024, 8, 11, 13, 2, 0, 0, DateTimeKind.Utc), "can.yıldız6@example.com", "Can", "Yıldız", "AQAAAAIAAYagAAAAEPQAAA", "05324982527", null, null, "User" },
                    { 1007, null, null, new DateTime(2024, 11, 24, 14, 21, 0, 0, DateTimeKind.Utc), "ahmet.kurt7@example.com", "Ahmet", "Kurt", "AQAAAAIAAYagAAAAEPQAAA", "05446818110", null, null, "User" },
                    { 1008, null, null, new DateTime(2024, 8, 14, 16, 43, 0, 0, DateTimeKind.Utc), "hasan.yıldırım8@example.com", "Hasan", "Yıldırım", "AQAAAAIAAYagAAAAEPQAAA", "05556301531", null, null, "User" },
                    { 1009, null, null, new DateTime(2024, 10, 5, 9, 56, 0, 0, DateTimeKind.Utc), "veli.şimşek9@example.com", "Veli", "Şimşek", "AQAAAAIAAYagAAAAEPQAAA", "05052902988", null, null, "User" },
                    { 1010, null, null, new DateTime(2024, 6, 3, 8, 48, 0, 0, DateTimeKind.Utc), "elif.koç10@example.com", "Elif", "Koç", "AQAAAAIAAYagAAAAEPQAAA", "05053356426", null, null, "User" },
                    { 1011, null, null, new DateTime(2024, 4, 21, 8, 8, 0, 0, DateTimeKind.Utc), "burak.şimşek11@example.com", "Burak", "Şimşek", "AQAAAAIAAYagAAAAEPQAAA", "05427413758", null, null, "User" },
                    { 1012, null, null, new DateTime(2024, 11, 2, 12, 14, 0, 0, DateTimeKind.Utc), "hüseyin.kılıç12@example.com", "Hüseyin", "Kılıç", "AQAAAAIAAYagAAAAEPQAAA", "05449521596", null, null, "User" },
                    { 1013, null, null, new DateTime(2024, 9, 1, 15, 41, 0, 0, DateTimeKind.Utc), "furkan.kurt13@example.com", "Furkan", "Kurt", "AQAAAAIAAYagAAAAEPQAAA", "05439355959", null, null, "User" },
                    { 1014, null, null, new DateTime(2024, 10, 22, 11, 55, 0, 0, DateTimeKind.Utc), "ege.aydın14@example.com", "Ege", "Aydın", "AQAAAAIAAYagAAAAEPQAAA", "05448923445", null, null, "User" },
                    { 1015, null, null, new DateTime(2024, 10, 4, 17, 21, 0, 0, DateTimeKind.Utc), "furkan.aydın15@example.com", "Furkan", "Aydın", "AQAAAAIAAYagAAAAEPQAAA", "05427238699", null, null, "User" },
                    { 1016, null, null, new DateTime(2024, 6, 26, 8, 20, 0, 0, DateTimeKind.Utc), "mehmet.şahin16@example.com", "Mehmet", "Şahin", "AQAAAAIAAYagAAAAEPQAAA", "05058235071", null, null, "User" },
                    { 1017, null, null, new DateTime(2024, 6, 6, 14, 51, 0, 0, DateTimeKind.Utc), "gökhan.özkan17@example.com", "Gökhan", "Özkan", "AQAAAAIAAYagAAAAEPQAAA", "05054587986", null, null, "User" },
                    { 1018, null, null, new DateTime(2024, 4, 4, 14, 42, 0, 0, DateTimeKind.Utc), "seda.kaya18@example.com", "Seda", "Kaya", "AQAAAAIAAYagAAAAEPQAAA", "05445556397", null, null, "User" }
                });

            migrationBuilder.InsertData(
                table: "UserPolicies",
                columns: new[] { "Id", "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 1001, new DateTime(2025, 8, 29, 11, 55, 0, 0, DateTimeKind.Utc), 6, false, "Premium Kasko", new DateTime(2024, 8, 29, 11, 55, 0, 0, DateTimeKind.Utc), "Sona erdi", 1001 },
                    { 1002, new DateTime(2025, 6, 29, 12, 52, 0, 0, DateTimeKind.Utc), 1, false, "Tamamlayıcı", new DateTime(2024, 6, 29, 12, 52, 0, 0, DateTimeKind.Utc), "Sona erdi", 1002 },
                    { 1003, new DateTime(2025, 6, 26, 17, 38, 0, 0, DateTimeKind.Utc), 2, true, "Kapsamlı Sağlık", new DateTime(2024, 6, 26, 17, 38, 0, 0, DateTimeKind.Utc), "Aktif", 1003 },
                    { 1004, new DateTime(2025, 2, 27, 13, 27, 0, 0, DateTimeKind.Utc), 8, true, "Evim Güvende", new DateTime(2024, 2, 27, 13, 27, 0, 0, DateTimeKind.Utc), "Aktif", 1004 },
                    { 1005, new DateTime(2025, 4, 2, 17, 25, 0, 0, DateTimeKind.Utc), 5, true, "Genişletilmiş Kasko", new DateTime(2024, 4, 2, 17, 25, 0, 0, DateTimeKind.Utc), "Aktif", 1005 },
                    { 1006, new DateTime(2025, 8, 12, 13, 2, 0, 0, DateTimeKind.Utc), 11, false, "Can Dostum", new DateTime(2024, 8, 12, 13, 2, 0, 0, DateTimeKind.Utc), "Sona erdi", 1006 },
                    { 1007, new DateTime(2025, 11, 25, 14, 21, 0, 0, DateTimeKind.Utc), 12, true, "Premium Pati", new DateTime(2024, 11, 25, 14, 21, 0, 0, DateTimeKind.Utc), "Aktif", 1007 },
                    { 1008, new DateTime(2025, 8, 17, 16, 43, 0, 0, DateTimeKind.Utc), 5, true, "Genişletilmiş Kasko", new DateTime(2024, 8, 17, 16, 43, 0, 0, DateTimeKind.Utc), "Aktif", 1008 },
                    { 1009, new DateTime(2025, 10, 8, 9, 56, 0, 0, DateTimeKind.Utc), 1, true, "Tamamlayıcı", new DateTime(2024, 10, 8, 9, 56, 0, 0, DateTimeKind.Utc), "Aktif", 1009 },
                    { 1010, new DateTime(2025, 6, 6, 8, 48, 0, 0, DateTimeKind.Utc), 10, false, "Pati Koruma", new DateTime(2024, 6, 6, 8, 48, 0, 0, DateTimeKind.Utc), "Sona erdi", 1010 },
                    { 1011, new DateTime(2025, 4, 24, 8, 8, 0, 0, DateTimeKind.Utc), 3, true, "VIP Hayat", new DateTime(2024, 4, 24, 8, 8, 0, 0, DateTimeKind.Utc), "Aktif", 1011 },
                    { 1012, new DateTime(2025, 11, 4, 12, 14, 0, 0, DateTimeKind.Utc), 9, true, "Premium Konak", new DateTime(2024, 11, 4, 12, 14, 0, 0, DateTimeKind.Utc), "Aktif", 1012 },
                    { 1013, new DateTime(2025, 9, 4, 15, 41, 0, 0, DateTimeKind.Utc), 1, true, "Tamamlayıcı", new DateTime(2024, 9, 4, 15, 41, 0, 0, DateTimeKind.Utc), "Aktif", 1013 },
                    { 1014, new DateTime(2025, 10, 26, 11, 55, 0, 0, DateTimeKind.Utc), 6, true, "Premium Kasko", new DateTime(2024, 10, 26, 11, 55, 0, 0, DateTimeKind.Utc), "Aktif", 1014 },
                    { 1015, new DateTime(2025, 10, 5, 17, 21, 0, 0, DateTimeKind.Utc), 11, true, "Can Dostum", new DateTime(2024, 10, 5, 17, 21, 0, 0, DateTimeKind.Utc), "Aktif", 1015 },
                    { 1016, new DateTime(2025, 6, 30, 8, 20, 0, 0, DateTimeKind.Utc), 4, true, "Trafik", new DateTime(2024, 6, 30, 8, 20, 0, 0, DateTimeKind.Utc), "Aktif", 1016 },
                    { 1017, new DateTime(2025, 6, 10, 14, 51, 0, 0, DateTimeKind.Utc), 11, false, "Can Dostum", new DateTime(2024, 6, 10, 14, 51, 0, 0, DateTimeKind.Utc), "Sona erdi", 1017 },
                    { 1018, new DateTime(2025, 4, 8, 14, 42, 0, 0, DateTimeKind.Utc), 6, false, "Premium Kasko", new DateTime(2024, 4, 8, 14, 42, 0, 0, DateTimeKind.Utc), "Sona erdi", 1018 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1018);
        }
    }
}
