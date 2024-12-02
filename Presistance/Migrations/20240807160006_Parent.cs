using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presistance.Migrations
{
    /// <inheritdoc />
    public partial class Parent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 7, 19, 30, 6, 417, DateTimeKind.Local).AddTicks(8327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 7, 15, 57, 11, 982, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.AddColumn<int>(
                name: "ParentCatalogTypeId",
                table: "CatalogType",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 7, 19, 30, 6, 417, DateTimeKind.Local).AddTicks(6493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 7, 15, 57, 11, 982, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.CreateIndex(
                name: "IX_CatalogType_ParentCatalogTypeId",
                table: "CatalogType",
                column: "ParentCatalogTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogType_CatalogType_ParentCatalogTypeId",
                table: "CatalogType",
                column: "ParentCatalogTypeId",
                principalTable: "CatalogType",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogType_CatalogType_ParentCatalogTypeId",
                table: "CatalogType");

            migrationBuilder.DropIndex(
                name: "IX_CatalogType_ParentCatalogTypeId",
                table: "CatalogType");

            migrationBuilder.DropColumn(
                name: "ParentCatalogTypeId",
                table: "CatalogType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 7, 15, 57, 11, 982, DateTimeKind.Local).AddTicks(5066),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 7, 19, 30, 6, 417, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 7, 15, 57, 11, 982, DateTimeKind.Local).AddTicks(3265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 7, 19, 30, 6, 417, DateTimeKind.Local).AddTicks(6493));
        }
    }
}
