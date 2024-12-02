using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presistance.Migrations
{
    /// <inheritdoc />
    public partial class Jhope : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "src",
                table: "CatalogItemImage",
                newName: "Src");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 918, DateTimeKind.Local).AddTicks(6044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 904, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 918, DateTimeKind.Local).AddTicks(4179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 904, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(8398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 904, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 918, DateTimeKind.Local).AddTicks(2033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 904, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(4889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 903, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(2331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 903, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 916, DateTimeKind.Local).AddTicks(971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 902, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 903, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 916, DateTimeKind.Local).AddTicks(8515),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 902, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 916, DateTimeKind.Local).AddTicks(6878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 902, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 916, DateTimeKind.Local).AddTicks(4842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 902, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(8534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 901, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(3791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 901, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(6248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 901, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(2331));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Src",
                table: "CatalogItemImage",
                newName: "src");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 904, DateTimeKind.Local).AddTicks(7774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 918, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 904, DateTimeKind.Local).AddTicks(5878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 918, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 904, DateTimeKind.Local).AddTicks(170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 904, DateTimeKind.Local).AddTicks(3654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 918, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 903, DateTimeKind.Local).AddTicks(6572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 903, DateTimeKind.Local).AddTicks(3608),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 902, DateTimeKind.Local).AddTicks(614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 916, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 903, DateTimeKind.Local).AddTicks(1220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 902, DateTimeKind.Local).AddTicks(8737),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 916, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 902, DateTimeKind.Local).AddTicks(6937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 916, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 902, DateTimeKind.Local).AddTicks(4558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 916, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 901, DateTimeKind.Local).AddTicks(8025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 901, DateTimeKind.Local).AddTicks(3446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 22, 7, 20, 901, DateTimeKind.Local).AddTicks(5911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 17, 22, 7, 20, 901, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 17, 22, 7, 20, 901, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 17, 22, 7, 20, 901, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 17, 22, 7, 20, 901, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 17, 22, 7, 20, 901, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 17, 22, 7, 20, 901, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 17, 22, 7, 20, 903, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 17, 22, 7, 20, 903, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 17, 22, 7, 20, 903, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 17, 22, 7, 20, 903, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 17, 22, 7, 20, 903, DateTimeKind.Local).AddTicks(3608));
        }
    }
}
