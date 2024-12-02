using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presistance.Migrations
{
    /// <inheritdoc />
    public partial class prp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 544, DateTimeKind.Local).AddTicks(2418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 215, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 544, DateTimeKind.Local).AddTicks(516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 215, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 543, DateTimeKind.Local).AddTicks(4652),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 543, DateTimeKind.Local).AddTicks(8253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 215, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 543, DateTimeKind.Local).AddTicks(572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 541, DateTimeKind.Local).AddTicks(5132),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(5847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 213, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(3835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 213, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(1793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 213, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 541, DateTimeKind.Local).AddTicks(9531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 213, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "CatalogItemComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "CatalogItemComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 541, DateTimeKind.Local).AddTicks(1973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 540, DateTimeKind.Local).AddTicks(7006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 211, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 540, DateTimeKind.Local).AddTicks(9656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 541, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 541, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 541, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 541, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 31,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 32,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 33,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 34,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 35,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 36,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 37,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 38,
                column: "InsertTime",
                value: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "CatalogItemComments");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "CatalogItemComments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 215, DateTimeKind.Local).AddTicks(6279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 544, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 215, DateTimeKind.Local).AddTicks(4159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 544, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(8092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 543, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 215, DateTimeKind.Local).AddTicks(1836),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 543, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(4290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 543, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(9061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 541, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 213, DateTimeKind.Local).AddTicks(9325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 213, DateTimeKind.Local).AddTicks(7325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 213, DateTimeKind.Local).AddTicks(5522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 542, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 213, DateTimeKind.Local).AddTicks(3247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 541, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(6386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 541, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 211, DateTimeKind.Local).AddTicks(9037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 540, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(3511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 17, 13, 50, 34, 540, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 31,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 32,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 33,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 34,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 35,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 36,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 37,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 38,
                column: "InsertTime",
                value: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));
        }
    }
}
