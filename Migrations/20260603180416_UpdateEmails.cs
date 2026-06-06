using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Safeish.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 8, 28, 11, 55, 0, 0, DateTimeKind.Utc), 3, true, "VIP Hayat", new DateTime(2024, 8, 28, 11, 55, 0, 0, DateTimeKind.Utc), "Aktif" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 11, 18, 16, 58, 0, 0, DateTimeKind.Utc), 6, true, "Premium Kasko", new DateTime(2024, 11, 18, 16, 58, 0, 0, DateTimeKind.Utc), "Aktif" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 11, 19, 9, 36, 0, 0, DateTimeKind.Utc), 8, "Evim Güvende", new DateTime(2024, 11, 19, 9, 36, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 21, 10, 29, 0, 0, DateTimeKind.Utc), 13, "Yurt İçi", new DateTime(2024, 6, 21, 10, 29, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 25, 10, 50, 0, 0, DateTimeKind.Utc), 11, "Can Dostum", new DateTime(2024, 1, 25, 10, 50, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 5, 22, 8, 10, 0, 0, DateTimeKind.Utc), 14, true, "Avrupa Vize", new DateTime(2024, 5, 22, 8, 10, 0, 0, DateTimeKind.Utc), "Aktif" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 20, 8, 17, 0, 0, DateTimeKind.Utc), 14, "Avrupa Vize", new DateTime(2024, 9, 20, 8, 17, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 19, 10, 57, 0, 0, DateTimeKind.Utc), 15, "Global Gezgin", new DateTime(2024, 6, 19, 10, 57, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 7, 16, 16, 28, 0, 0, DateTimeKind.Utc), 10, false, "Pati Koruma", new DateTime(2024, 7, 16, 16, 28, 0, 0, DateTimeKind.Utc), "Sona erdi" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 30, 11, 44, 0, 0, DateTimeKind.Utc), 11, "Can Dostum", new DateTime(2024, 6, 30, 11, 44, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 7, 28, 8, 26, 0, 0, DateTimeKind.Utc), 9, "Premium Konak", new DateTime(2024, 7, 28, 8, 26, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 4, 15, 41, 0, 0, DateTimeKind.Utc), 13, "Yurt İçi", new DateTime(2024, 9, 4, 15, 41, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 12, 17, 32, 0, 0, DateTimeKind.Utc), 13, "Yurt İçi", new DateTime(2024, 9, 12, 17, 32, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 11, 12, 12, 40, 0, 0, DateTimeKind.Utc), 2, false, "Kapsamlı Sağlık", new DateTime(2024, 11, 12, 12, 40, 0, 0, DateTimeKind.Utc), "Sona erdi" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 4, 19, 16, 12, 0, 0, DateTimeKind.Utc), 15, "Global Gezgin", new DateTime(2024, 4, 19, 16, 12, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 7, 14, 14, 12, 0, 0, DateTimeKind.Utc), 6, false, "Premium Kasko", new DateTime(2024, 7, 14, 14, 12, 0, 0, DateTimeKind.Utc), "Sona erdi" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 6, 14, 9, 58, 0, 0, DateTimeKind.Utc), 5, true, "Genişletilmiş Kasko", new DateTime(2024, 6, 14, 9, 58, 0, 0, DateTimeKind.Utc), "Aktif" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 6, 10, 9, 56, 0, 0, DateTimeKind.Utc), 12, true, "Premium Pati", new DateTime(2024, 6, 10, 9, 56, 0, 0, DateTimeKind.Utc), "Aktif" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Email",
                value: "mert.çelik1@gmail.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 11, 14, 16, 58, 0, 0, DateTimeKind.Utc), "hüseyin.özdemir2@gmail.com", "Hüseyin", "Özdemir", "05421315720" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 11, 18, 9, 36, 0, 0, DateTimeKind.Utc), "burak.koç3@hotmail.com", "Burak", "Koç", "05328146083" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 6, 20, 10, 29, 0, 0, DateTimeKind.Utc), "gizem.arslan4@hotmail.com", "Gizem", "Arslan", "05426308663" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 1, 22, 10, 50, 0, 0, DateTimeKind.Utc), "seda.aydın5@gmail.com", "Seda", "Aydın", "05336283477" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 5, 20, 8, 10, 0, 0, DateTimeKind.Utc), "ahmet.kaya6@hotmail.com", "Ahmet", "Kaya", "05328939428" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 9, 17, 8, 17, 0, 0, DateTimeKind.Utc), "burak.kılıç7@gmail.com", "Burak", "Kılıç", "05426775786" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "CreatedAt", "Email", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 6, 18, 10, 57, 0, 0, DateTimeKind.Utc), "can.yıldırım8@gmail.com", "Can", "05552491446" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 7, 13, 16, 28, 0, 0, DateTimeKind.Utc), "mehmet.kılıç9@hotmail.com", "Mehmet", "Kılıç", "05321302610" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 6, 27, 11, 44, 0, 0, DateTimeKind.Utc), "ayşe.kılıç10@gmail.com", "Ayşe", "Kılıç", "05322362902" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 7, 26, 8, 26, 0, 0, DateTimeKind.Utc), "ege.öztürk11@hotmail.com", "Ege", "Öztürk", "05336117725" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 15, 41, 0, 0, DateTimeKind.Utc), "furkan.kurt12@gmail.com", "Furkan", "Kurt", "05439355959" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "CreatedAt", "Email", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 9, 10, 17, 32, 0, 0, DateTimeKind.Utc), "zeynep.kurt13@gmail.com", "Zeynep", "05434088918" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 40, 0, 0, DateTimeKind.Utc), "gizem.demir14@gmail.com", "Gizem", "Demir", "05055962508" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 4, 18, 16, 12, 0, 0, DateTimeKind.Utc), "seda.yılmaz15@hotmail.com", "Seda", "Yılmaz", "05058409011" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 7, 11, 14, 12, 0, 0, DateTimeKind.Utc), "deniz.kurt16@gmail.com", "Deniz", "Kurt", "05439446215" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 6, 10, 9, 58, 0, 0, DateTimeKind.Utc), "emre.arslan17@hotmail.com", "Emre", "Arslan", "05054079848" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 6, 7, 9, 56, 0, 0, DateTimeKind.Utc), "fatma.şahin18@hotmail.com", "Fatma", "Şahin", "05059403498" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 8, 29, 11, 55, 0, 0, DateTimeKind.Utc), 6, false, "Premium Kasko", new DateTime(2024, 8, 29, 11, 55, 0, 0, DateTimeKind.Utc), "Sona erdi" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 52, 0, 0, DateTimeKind.Utc), 1, false, "Tamamlayıcı", new DateTime(2024, 6, 29, 12, 52, 0, 0, DateTimeKind.Utc), "Sona erdi" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 26, 17, 38, 0, 0, DateTimeKind.Utc), 2, "Kapsamlı Sağlık", new DateTime(2024, 6, 26, 17, 38, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 27, 13, 27, 0, 0, DateTimeKind.Utc), 8, "Evim Güvende", new DateTime(2024, 2, 27, 13, 27, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 4, 2, 17, 25, 0, 0, DateTimeKind.Utc), 5, "Genişletilmiş Kasko", new DateTime(2024, 4, 2, 17, 25, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 8, 12, 13, 2, 0, 0, DateTimeKind.Utc), 11, false, "Can Dostum", new DateTime(2024, 8, 12, 13, 2, 0, 0, DateTimeKind.Utc), "Sona erdi" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 11, 25, 14, 21, 0, 0, DateTimeKind.Utc), 12, "Premium Pati", new DateTime(2024, 11, 25, 14, 21, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 8, 17, 16, 43, 0, 0, DateTimeKind.Utc), 5, "Genişletilmiş Kasko", new DateTime(2024, 8, 17, 16, 43, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 10, 8, 9, 56, 0, 0, DateTimeKind.Utc), 1, true, "Tamamlayıcı", new DateTime(2024, 10, 8, 9, 56, 0, 0, DateTimeKind.Utc), "Aktif" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 6, 6, 8, 48, 0, 0, DateTimeKind.Utc), 10, "Pati Koruma", new DateTime(2024, 6, 6, 8, 48, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 4, 24, 8, 8, 0, 0, DateTimeKind.Utc), 3, "VIP Hayat", new DateTime(2024, 4, 24, 8, 8, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 11, 4, 12, 14, 0, 0, DateTimeKind.Utc), 9, "Premium Konak", new DateTime(2024, 11, 4, 12, 14, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 9, 4, 15, 41, 0, 0, DateTimeKind.Utc), 1, "Tamamlayıcı", new DateTime(2024, 9, 4, 15, 41, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 10, 26, 11, 55, 0, 0, DateTimeKind.Utc), 6, true, "Premium Kasko", new DateTime(2024, 10, 26, 11, 55, 0, 0, DateTimeKind.Utc), "Aktif" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 10, 5, 17, 21, 0, 0, DateTimeKind.Utc), 11, "Can Dostum", new DateTime(2024, 10, 5, 17, 21, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 6, 30, 8, 20, 0, 0, DateTimeKind.Utc), 4, true, "Trafik", new DateTime(2024, 6, 30, 8, 20, 0, 0, DateTimeKind.Utc), "Aktif" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 6, 10, 14, 51, 0, 0, DateTimeKind.Utc), 11, false, "Can Dostum", new DateTime(2024, 6, 10, 14, 51, 0, 0, DateTimeKind.Utc), "Sona erdi" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 4, 8, 14, 42, 0, 0, DateTimeKind.Utc), 6, false, "Premium Kasko", new DateTime(2024, 4, 8, 14, 42, 0, 0, DateTimeKind.Utc), "Sona erdi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Email",
                value: "mert.çelik1@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 52, 0, 0, DateTimeKind.Utc), "burak.öztürk2@example.com", "Burak", "Öztürk", "05434457977" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 38, 0, 0, DateTimeKind.Utc), "gizem.şimşek3@example.com", "Gizem", "Şimşek", "05336553620" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 2, 24, 13, 27, 0, 0, DateTimeKind.Utc), "elif.doğan4@example.com", "Elif", "Doğan", "05553472513" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 25, 0, 0, DateTimeKind.Utc), "deniz.kurt5@example.com", "Deniz", "Kurt", "05328098949" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 2, 0, 0, DateTimeKind.Utc), "can.yıldız6@example.com", "Can", "Yıldız", "05324982527" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 11, 24, 14, 21, 0, 0, DateTimeKind.Utc), "ahmet.kurt7@example.com", "Ahmet", "Kurt", "05446818110" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "CreatedAt", "Email", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 14, 16, 43, 0, 0, DateTimeKind.Utc), "hasan.yıldırım8@example.com", "Hasan", "05556301531" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 10, 5, 9, 56, 0, 0, DateTimeKind.Utc), "veli.şimşek9@example.com", "Veli", "Şimşek", "05052902988" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 6, 3, 8, 48, 0, 0, DateTimeKind.Utc), "elif.koç10@example.com", "Elif", "Koç", "05053356426" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 4, 21, 8, 8, 0, 0, DateTimeKind.Utc), "burak.şimşek11@example.com", "Burak", "Şimşek", "05427413758" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 11, 2, 12, 14, 0, 0, DateTimeKind.Utc), "hüseyin.kılıç12@example.com", "Hüseyin", "Kılıç", "05449521596" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "CreatedAt", "Email", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 9, 1, 15, 41, 0, 0, DateTimeKind.Utc), "furkan.kurt13@example.com", "Furkan", "05439355959" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 10, 22, 11, 55, 0, 0, DateTimeKind.Utc), "ege.aydın14@example.com", "Ege", "Aydın", "05448923445" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 10, 4, 17, 21, 0, 0, DateTimeKind.Utc), "furkan.aydın15@example.com", "Furkan", "Aydın", "05427238699" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 6, 26, 8, 20, 0, 0, DateTimeKind.Utc), "mehmet.şahin16@example.com", "Mehmet", "Şahin", "05058235071" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 6, 6, 14, 51, 0, 0, DateTimeKind.Utc), "gökhan.özkan17@example.com", "Gökhan", "Özkan", "05054587986" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 4, 4, 14, 42, 0, 0, DateTimeKind.Utc), "seda.kaya18@example.com", "Seda", "Kaya", "05445556397" });
        }
    }
}
