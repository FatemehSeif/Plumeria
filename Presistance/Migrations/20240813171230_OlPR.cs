using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presistance.Migrations
{
    /// <inheritdoc />
    public partial class OlPR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 987, DateTimeKind.Local).AddTicks(1831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 630, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 986, DateTimeKind.Local).AddTicks(9940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 630, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 986, DateTimeKind.Local).AddTicks(4168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 629, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 986, DateTimeKind.Local).AddTicks(7661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 630, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 986, DateTimeKind.Local).AddTicks(430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 629, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 985, DateTimeKind.Local).AddTicks(7593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 629, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.AlterColumn<int>(
                name: "PercentDiscount",
                table: "CatalogItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 985, DateTimeKind.Local).AddTicks(280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 628, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CatalogItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 985, DateTimeKind.Local).AddTicks(5487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 628, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 985, DateTimeKind.Local).AddTicks(3498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 628, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 984, DateTimeKind.Local).AddTicks(7833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 628, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 984, DateTimeKind.Local).AddTicks(3152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 627, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 984, DateTimeKind.Local).AddTicks(5656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 628, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 42, 29, 984, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 42, 29, 984, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 42, 29, 984, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 42, 29, 984, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 42, 29, 984, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 42, 29, 984, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 42, 29, 985, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 42, 29, 985, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 42, 29, 985, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 42, 29, 985, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 42, 29, 985, DateTimeKind.Local).AddTicks(7593));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 630, DateTimeKind.Local).AddTicks(5888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 987, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 630, DateTimeKind.Local).AddTicks(4038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 986, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 629, DateTimeKind.Local).AddTicks(8487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 986, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 630, DateTimeKind.Local).AddTicks(2027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 986, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 629, DateTimeKind.Local).AddTicks(4628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 986, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 629, DateTimeKind.Local).AddTicks(1987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 985, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.AlterColumn<int>(
                name: "PercentDiscount",
                table: "CatalogItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 628, DateTimeKind.Local).AddTicks(4673),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 985, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CatalogItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 628, DateTimeKind.Local).AddTicks(9973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 985, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 628, DateTimeKind.Local).AddTicks(7960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 985, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 628, DateTimeKind.Local).AddTicks(2392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 984, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 627, DateTimeKind.Local).AddTicks(7645),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 984, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 20, 38, 30, 628, DateTimeKind.Local).AddTicks(230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 20, 42, 29, 984, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 38, 30, 628, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 38, 30, 628, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 38, 30, 628, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 38, 30, 628, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 38, 30, 628, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 38, 30, 628, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 38, 30, 629, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 38, 30, 629, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 38, 30, 629, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 38, 30, 629, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 20, 38, 30, 629, DateTimeKind.Local).AddTicks(1987));
        }
    }
}
