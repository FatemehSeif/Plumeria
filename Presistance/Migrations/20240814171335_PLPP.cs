using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presistance.Migrations
{
    /// <inheritdoc />
    public partial class PLPP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 27, DateTimeKind.Local).AddTicks(1286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 656, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 26, DateTimeKind.Local).AddTicks(8079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 656, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 26, DateTimeKind.Local).AddTicks(2177),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 655, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 26, DateTimeKind.Local).AddTicks(5731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 656, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 25, DateTimeKind.Local).AddTicks(8460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 655, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 25, DateTimeKind.Local).AddTicks(5769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 655, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 24, DateTimeKind.Local).AddTicks(6017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 654, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.AddColumn<int>(
                name: "VisitCount",
                table: "CatalogItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 25, DateTimeKind.Local).AddTicks(3512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 655, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 25, DateTimeKind.Local).AddTicks(1491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 654, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 24, DateTimeKind.Local).AddTicks(9694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 654, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 24, DateTimeKind.Local).AddTicks(3458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 654, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 23, DateTimeKind.Local).AddTicks(8336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 653, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 24, DateTimeKind.Local).AddTicks(1203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 653, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 20, 43, 35, 24, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 20, 43, 35, 24, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 20, 43, 35, 24, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 20, 43, 35, 24, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 20, 43, 35, 24, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 20, 43, 35, 24, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 20, 43, 35, 25, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 20, 43, 35, 25, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 20, 43, 35, 25, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 20, 43, 35, 25, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 14, 20, 43, 35, 25, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CatalogItemId",
                table: "OrderItems",
                column: "CatalogItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_CatalogItems_CatalogItemId",
                table: "OrderItems",
                column: "CatalogItemId",
                principalTable: "CatalogItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_CatalogItems_CatalogItemId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_CatalogItemId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "VisitCount",
                table: "CatalogItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 656, DateTimeKind.Local).AddTicks(6632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 27, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 656, DateTimeKind.Local).AddTicks(4572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 26, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 655, DateTimeKind.Local).AddTicks(9095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 26, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 656, DateTimeKind.Local).AddTicks(2597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 26, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 655, DateTimeKind.Local).AddTicks(5333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 25, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 655, DateTimeKind.Local).AddTicks(2650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 25, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 654, DateTimeKind.Local).AddTicks(2834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 24, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 655, DateTimeKind.Local).AddTicks(192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 25, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 654, DateTimeKind.Local).AddTicks(8041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 25, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 654, DateTimeKind.Local).AddTicks(6283),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 24, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 654, DateTimeKind.Local).AddTicks(438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 24, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 653, DateTimeKind.Local).AddTicks(5401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 23, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 13, 22, 17, 18, 653, DateTimeKind.Local).AddTicks(7953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 14, 20, 43, 35, 24, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 22, 17, 18, 654, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 22, 17, 18, 654, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 22, 17, 18, 654, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 22, 17, 18, 654, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 22, 17, 18, 654, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 22, 17, 18, 654, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 22, 17, 18, 655, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 22, 17, 18, 655, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 22, 17, 18, 655, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 22, 17, 18, 655, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2024, 8, 13, 22, 17, 18, 655, DateTimeKind.Local).AddTicks(2650));
        }
    }
}
