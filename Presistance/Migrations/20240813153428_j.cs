using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presistance.Migrations
{
    /// <inheritdoc />
    public partial class j : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 934, DateTimeKind.Local).AddTicks(2449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 861, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 934, DateTimeKind.Local).AddTicks(347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 861, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 933, DateTimeKind.Local).AddTicks(4757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 861, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.AddColumn<int>(
                name: "AppliedDiscountId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountAmount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 933, DateTimeKind.Local).AddTicks(8316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 861, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 933, DateTimeKind.Local).AddTicks(985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 860, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 932, DateTimeKind.Local).AddTicks(7806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 860, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 931, DateTimeKind.Local).AddTicks(7547),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 859, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 932, DateTimeKind.Local).AddTicks(3510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 860, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 932, DateTimeKind.Local).AddTicks(956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 860, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 931, DateTimeKind.Local).AddTicks(5217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 859, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 931, DateTimeKind.Local).AddTicks(363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 859, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.AddColumn<int>(
                name: "AppliedDiscountId",
                table: "Baskets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiscountAmount",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 931, DateTimeKind.Local).AddTicks(3095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 859, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 19, 4, 27, 931, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 19, 4, 27, 931, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 19, 4, 27, 931, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 19, 4, 27, 931, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 19, 4, 27, 931, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 19, 4, 27, 931, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 19, 4, 27, 932, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 19, 4, 27, 932, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 19, 4, 27, 932, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 19, 4, 27, 932, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 19, 4, 27, 932, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppliedDiscountId",
                table: "Orders",
                column: "AppliedDiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_AppliedDiscountId",
                table: "Baskets",
                column: "AppliedDiscountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Discount_AppliedDiscountId",
                table: "Baskets",
                column: "AppliedDiscountId",
                principalTable: "Discount",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Discount_AppliedDiscountId",
                table: "Orders",
                column: "AppliedDiscountId",
                principalTable: "Discount",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Discount_AppliedDiscountId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Discount_AppliedDiscountId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AppliedDiscountId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_AppliedDiscountId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "AppliedDiscountId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DiscountAmount",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AppliedDiscountId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "DiscountAmount",
                table: "Baskets");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 861, DateTimeKind.Local).AddTicks(8565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 934, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 861, DateTimeKind.Local).AddTicks(6686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 934, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 861, DateTimeKind.Local).AddTicks(1908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 933, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 861, DateTimeKind.Local).AddTicks(4815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 933, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 860, DateTimeKind.Local).AddTicks(9512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 933, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 860, DateTimeKind.Local).AddTicks(7256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 932, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 859, DateTimeKind.Local).AddTicks(9988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 931, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 860, DateTimeKind.Local).AddTicks(5229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 932, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 860, DateTimeKind.Local).AddTicks(3198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 932, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 859, DateTimeKind.Local).AddTicks(7843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 931, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 859, DateTimeKind.Local).AddTicks(3318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 931, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 0, 34, 2, 859, DateTimeKind.Local).AddTicks(5634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 19, 4, 27, 931, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 0, 34, 2, 859, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 0, 34, 2, 859, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 0, 34, 2, 859, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 0, 34, 2, 859, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 0, 34, 2, 859, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 0, 34, 2, 859, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 0, 34, 2, 860, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 0, 34, 2, 860, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 0, 34, 2, 860, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 0, 34, 2, 860, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 0, 34, 2, 860, DateTimeKind.Local).AddTicks(7256));
        }
    }
}
