using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Safeish.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEndDatesTo2028 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1001,
                column: "EndDate",
                value: new DateTime(2028, 5, 14, 17, 28, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2028, 3, 17, 9, 46, 0, 0, DateTimeKind.Utc), 13, "Yurt İçi", new DateTime(2024, 5, 4, 9, 22, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2028, 8, 24, 11, 1, 0, 0, DateTimeKind.Utc), new DateTime(2024, 7, 6, 16, 31, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2028, 1, 2, 12, 43, 0, 0, DateTimeKind.Utc), 11, "Can Dostum", new DateTime(2024, 1, 25, 10, 50, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2028, 1, 9, 11, 37, 0, 0, DateTimeKind.Utc), 10, "Pati Koruma", new DateTime(2024, 1, 27, 17, 52, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2028, 2, 26, 14, 12, 0, 0, DateTimeKind.Utc), 15, "Global Gezgin", new DateTime(2024, 9, 21, 13, 18, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 7, 16, 16, 28, 0, 0, DateTimeKind.Utc), 10, false, "Pati Koruma", new DateTime(2024, 7, 16, 16, 28, 0, 0, DateTimeKind.Utc), "Sona erdi" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 6, 30, 11, 44, 0, 0, DateTimeKind.Utc), 11, false, "Can Dostum", new DateTime(2024, 6, 30, 11, 44, 0, 0, DateTimeKind.Utc), "Sona erdi" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2028, 10, 24, 16, 0, 0, 0, DateTimeKind.Utc), 9, true, "Premium Konak", new DateTime(2024, 7, 28, 8, 26, 0, 0, DateTimeKind.Utc), "Aktif" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2028, 12, 15, 16, 20, 0, 0, DateTimeKind.Utc), 13, true, "Yurt İçi", new DateTime(2024, 10, 28, 8, 50, 0, 0, DateTimeKind.Utc), "Aktif" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2028, 1, 3, 10, 28, 0, 0, DateTimeKind.Utc), 11, "Can Dostum", new DateTime(2024, 9, 16, 16, 7, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2028, 8, 24, 14, 23, 0, 0, DateTimeKind.Utc), 15, "Global Gezgin", new DateTime(2024, 4, 19, 16, 12, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2028, 2, 27, 14, 20, 0, 0, DateTimeKind.Utc), 9, "Premium Konak", new DateTime(2024, 11, 28, 8, 21, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2028, 8, 22, 15, 32, 0, 0, DateTimeKind.Utc), 15, true, "Global Gezgin", new DateTime(2024, 5, 29, 9, 14, 0, 0, DateTimeKind.Utc), "Aktif" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2028, 9, 9, 14, 49, 0, 0, DateTimeKind.Utc), 11, "Can Dostum", new DateTime(2024, 10, 26, 9, 15, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2028, 9, 6, 8, 54, 0, 0, DateTimeKind.Utc), 12, true, "Premium Pati", new DateTime(2024, 6, 10, 12, 42, 0, 0, DateTimeKind.Utc), "Aktif" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 4, 26, 9, 44, 0, 0, DateTimeKind.Utc), 13, false, "Yurt İçi", new DateTime(2024, 4, 26, 9, 44, 0, 0, DateTimeKind.Utc), "Sona erdi" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 6, 25, 10, 46, 0, 0, DateTimeKind.Utc), 6, false, "Premium Kasko", new DateTime(2024, 6, 25, 10, 46, 0, 0, DateTimeKind.Utc), "Sona erdi" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "InsurancePackageId", "PackageName" },
                values: new object[] { 2, "Kapsamlı Sağlık" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "InsurancePackageId", "PackageName" },
                values: new object[] { 7, "Temel Güvence" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "InsurancePackageId", "PackageName" },
                values: new object[] { 3, "VIP Hayat" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "InsurancePackageId", "PackageName" },
                values: new object[] { 6, "Premium Kasko" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 5, 1, 9, 22, 0, 0, DateTimeKind.Utc), "gizem.şimşek2@hotmail.com", "Gizem", "Şimşek", "05439704917" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "CreatedAt", "Email", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 7, 3, 16, 31, 0, 0, DateTimeKind.Utc), "burak.özdemir3@gmail.com", "Özdemir", "05447639866" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 1, 22, 10, 50, 0, 0, DateTimeKind.Utc), "seda.aydın4@gmail.com", "Seda", "Aydın", "05336283477" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 1, 24, 17, 52, 0, 0, DateTimeKind.Utc), "ahmet.çelik5@hotmail.com", "Ahmet", "Çelik", "05054306517" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 9, 20, 13, 18, 0, 0, DateTimeKind.Utc), "elif.kurt6@gmail.com", "Elif", "Kurt", "05446840182" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "CreatedAt", "Email", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 7, 13, 16, 28, 0, 0, DateTimeKind.Utc), "mehmet.kılıç7@hotmail.com", "Mehmet", "05321302610" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 6, 27, 11, 44, 0, 0, DateTimeKind.Utc), "ayşe.kılıç8@gmail.com", "Ayşe", "Kılıç", "05322362902" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 7, 26, 8, 26, 0, 0, DateTimeKind.Utc), "ege.öztürk9@hotmail.com", "Ege", "Öztürk", "05336117725" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 10, 26, 8, 50, 0, 0, DateTimeKind.Utc), "furkan.aslan10@gmail.com", "Furkan", "Aslan", "05446989068" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 9, 13, 16, 7, 0, 0, DateTimeKind.Utc), "elif.koç11@gmail.com", "Elif", "Koç", "05434327342" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 4, 18, 16, 12, 0, 0, DateTimeKind.Utc), "seda.yılmaz12@hotmail.com", "Seda", "Yılmaz", "05058409011" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 11, 26, 8, 21, 0, 0, DateTimeKind.Utc), "ege.şahin13@hotmail.com", "Ege", "Şahin", "05327021453" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 14, 0, 0, DateTimeKind.Utc), "ege.yıldırım14@gmail.com", "Ege", "Yıldırım", "05443193600" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 10, 24, 9, 15, 0, 0, DateTimeKind.Utc), "mehmet.yıldırım15@hotmail.com", "Mehmet", "Yıldırım", "05426265923" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 6, 9, 12, 42, 0, 0, DateTimeKind.Utc), "hasan.çelik16@hotmail.com", "Hasan", "Çelik", "05334785495" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 4, 23, 9, 44, 0, 0, DateTimeKind.Utc), "gökhan.şimşek17@hotmail.com", "Gökhan", "Şimşek", "05334500857" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 6, 23, 10, 46, 0, 0, DateTimeKind.Utc), "hasan.yıldız18@gmail.com", "Hasan", "Yıldız", "05054759324" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1001,
                column: "EndDate",
                value: new DateTime(2025, 8, 28, 11, 55, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 11, 18, 16, 58, 0, 0, DateTimeKind.Utc), 6, "Premium Kasko", new DateTime(2024, 11, 18, 16, 58, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 11, 19, 9, 36, 0, 0, DateTimeKind.Utc), new DateTime(2024, 11, 19, 9, 36, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "EndDate", "InsurancePackageId", "PackageName", "StartDate" },
                values: new object[] { new DateTime(2025, 5, 22, 8, 10, 0, 0, DateTimeKind.Utc), 14, "Avrupa Vize", new DateTime(2024, 5, 22, 8, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 9, 20, 8, 17, 0, 0, DateTimeKind.Utc), 14, true, "Avrupa Vize", new DateTime(2024, 9, 20, 8, 17, 0, 0, DateTimeKind.Utc), "Aktif" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 6, 19, 10, 57, 0, 0, DateTimeKind.Utc), 15, true, "Global Gezgin", new DateTime(2024, 6, 19, 10, 57, 0, 0, DateTimeKind.Utc), "Aktif" });

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
                columns: new[] { "EndDate", "InsurancePackageId", "IsActive", "PackageName", "StartDate", "Status" },
                values: new object[] { new DateTime(2025, 6, 30, 11, 44, 0, 0, DateTimeKind.Utc), 11, false, "Can Dostum", new DateTime(2024, 6, 30, 11, 44, 0, 0, DateTimeKind.Utc), "Sona erdi" });

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
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "InsurancePackageId", "PackageName" },
                values: new object[] { 1, "Tamamlayıcı" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "InsurancePackageId", "PackageName" },
                values: new object[] { 5, "Genişletilmiş Kasko" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "InsurancePackageId", "PackageName" },
                values: new object[] { 14, "Avrupa Vize" });

            migrationBuilder.UpdateData(
                table: "UserPolicies",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "InsurancePackageId", "PackageName" },
                values: new object[] { 13, "Yurt İçi" });

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
                columns: new[] { "CreatedAt", "Email", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 11, 18, 9, 36, 0, 0, DateTimeKind.Utc), "burak.koç3@hotmail.com", "Koç", "05328146083" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 9, 17, 8, 17, 0, 0, DateTimeKind.Utc), "burak.kılıç7@gmail.com", "Burak", "05426775786" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 6, 18, 10, 57, 0, 0, DateTimeKind.Utc), "can.yıldırım8@gmail.com", "Can", "Yıldırım", "05552491446" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 9, 10, 17, 32, 0, 0, DateTimeKind.Utc), "zeynep.kurt13@gmail.com", "Zeynep", "Kurt", "05434088918" });

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
    }
}
