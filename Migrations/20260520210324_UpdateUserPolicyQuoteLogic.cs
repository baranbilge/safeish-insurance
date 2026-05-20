using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Safeish.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserPolicyQuoteLogic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPolicies_InsurancePackages_InsurancePackageId",
                table: "UserPolicies");

            migrationBuilder.AlterColumn<int>(
                name: "InsurancePackageId",
                table: "UserPolicies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "PackageName",
                table: "UserPolicies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "UserPolicies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPolicies_InsurancePackages_InsurancePackageId",
                table: "UserPolicies",
                column: "InsurancePackageId",
                principalTable: "InsurancePackages",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPolicies_InsurancePackages_InsurancePackageId",
                table: "UserPolicies");

            migrationBuilder.DropColumn(
                name: "PackageName",
                table: "UserPolicies");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "UserPolicies");

            migrationBuilder.AlterColumn<int>(
                name: "InsurancePackageId",
                table: "UserPolicies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPolicies_InsurancePackages_InsurancePackageId",
                table: "UserPolicies",
                column: "InsurancePackageId",
                principalTable: "InsurancePackages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
