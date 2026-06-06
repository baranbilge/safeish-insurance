using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Safeish.Migrations
{
    /// <inheritdoc />
    public partial class InitialSqlite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InsuranceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    IconUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    AlternativePhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    ResetPasswordToken = table.Column<string>(type: "TEXT", nullable: true),
                    ResetPasswordTokenExpiry = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsurancePackages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InsuranceTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CoverageAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Features = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsurancePackages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsurancePackages_InsuranceTypes_InsuranceTypeId",
                        column: x => x.InsuranceTypeId,
                        principalTable: "InsuranceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPolicies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    InsurancePackageId = table.Column<int>(type: "INTEGER", nullable: true),
                    PackageName = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPolicies_InsurancePackages_InsurancePackageId",
                        column: x => x.InsurancePackageId,
                        principalTable: "InsurancePackages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserPolicies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "InsuranceTypes",
                columns: new[] { "Id", "Description", "IconUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Kapsamlı sağlık güvencesi", "bi-heart-pulse", "Sağlık Sigortası" },
                    { 2, "Aracınız için tam koruma", "bi-car-front", "Kasko Sigortası" },
                    { 3, "Eviniz için tam koruma", "bi-house", "Konut Sigortası" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePackages_InsuranceTypeId",
                table: "InsurancePackages",
                column: "InsuranceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPolicies_InsurancePackageId",
                table: "UserPolicies",
                column: "InsurancePackageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPolicies_UserId",
                table: "UserPolicies",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserPolicies");

            migrationBuilder.DropTable(
                name: "InsurancePackages");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "InsuranceTypes");
        }
    }
}
