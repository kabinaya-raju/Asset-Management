using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Management.Migrations
{
    /// <inheritdoc />
    public partial class Initialdatails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAssets_Assets_AssetId",
                table: "EmployeeAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAssets_Employees_AssetId",
                table: "EmployeeAssets");

            migrationBuilder.AlterColumn<DateTime>(
                name: "IssueDate",
                table: "EmployeeAssets",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAssets_EmployeeId",
                table: "EmployeeAssets",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAssets_Assets_AssetId",
                table: "EmployeeAssets",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "AssetId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAssets_Employees_EmployeeId",
                table: "EmployeeAssets",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAssets_Assets_AssetId",
                table: "EmployeeAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeAssets_Employees_EmployeeId",
                table: "EmployeeAssets");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeAssets_EmployeeId",
                table: "EmployeeAssets");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "IssueDate",
                table: "EmployeeAssets",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAssets_Assets_AssetId",
                table: "EmployeeAssets",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "AssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeAssets_Employees_AssetId",
                table: "EmployeeAssets",
                column: "AssetId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }
    }
}
