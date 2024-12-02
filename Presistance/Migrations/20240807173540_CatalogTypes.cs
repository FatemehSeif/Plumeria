using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Presistance.Migrations
{
    /// <inheritdoc />
    public partial class CatalogTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 7, 21, 5, 40, 379, DateTimeKind.Local).AddTicks(5636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 7, 19, 30, 6, 417, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 7, 21, 5, 40, 379, DateTimeKind.Local).AddTicks(3416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 7, 19, 30, 6, 417, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.InsertData(
                table: "CatalogBrand",
                columns: new[] { "Id", "Brand", "RemoveTime", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "سامسونگ", null, null },
                    { 2, "شیائومی ", null, null },
                    { 3, "اپل", null, null },
                    { 4, "هوآوی", null, null },
                    { 5, "نوکیا ", null, null },
                    { 6, "ال جی", null, null }
                });

            migrationBuilder.InsertData(
                table: "CatalogType",
                columns: new[] { "Id", "ParentCatalogTypeId", "RemoveTime", "Type", "UpdateTime" },
                values: new object[,]
                {
                    { 1, null, null, "کالای دیجیتال", null },
                    { 2, 1, null, "لوازم جانبی گوشی", null },
                    { 3, 2, null, "پایه نگهدارنده گوشی", null },
                    { 4, 2, null, "پاور بانک (شارژر همراه)", null },
                    { 5, 2, null, "کیف و کاور گوشی", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 7, 19, 30, 6, 417, DateTimeKind.Local).AddTicks(8327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 7, 21, 5, 40, 379, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 7, 19, 30, 6, 417, DateTimeKind.Local).AddTicks(6493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 7, 21, 5, 40, 379, DateTimeKind.Local).AddTicks(3416));
        }
    }
}
