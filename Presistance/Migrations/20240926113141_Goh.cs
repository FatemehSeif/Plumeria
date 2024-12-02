using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Presistance.Migrations
{
    /// <inheritdoc />
    public partial class Goh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 215, DateTimeKind.Local).AddTicks(6279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 918, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 215, DateTimeKind.Local).AddTicks(4159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 918, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(8092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 215, DateTimeKind.Local).AddTicks(1836),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 918, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(4290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(9061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 916, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 213, DateTimeKind.Local).AddTicks(9325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 213, DateTimeKind.Local).AddTicks(7325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 916, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 213, DateTimeKind.Local).AddTicks(5522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 916, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 213, DateTimeKind.Local).AddTicks(3247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 916, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(6386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 211, DateTimeKind.Local).AddTicks(9037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(3511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "InsertTime" },
                values: new object[] { "تراست پروفشنال", new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "InsertTime" },
                values: new object[] { "تراست اسمارت", new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "InsertTime" },
                values: new object[] { "لایف گارد", new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "InsertTime" },
                values: new object[] { "کلاس یک", new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertTime", "Type" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469), "محصولات تراست" });

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertTime", "Type" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469), "مراقبت از مو" });

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertTime", "ParentCatalogTypeId", "Type" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469), 1, "مراقبت از بدن" });

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertTime", "ParentCatalogTypeId", "Type" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469), 1, "عطر و آرایشی" });

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertTime", "ParentCatalogTypeId", "Type" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469), 1, "مراقبت از دهان و دندان" });

            migrationBuilder.InsertData(
                table: "CatalogType",
                columns: new[] { "Id", "ParentCatalogTypeId", "RemoveTime", "Type", "UpdateTime" },
                values: new object[,]
                {
                    { 6, 1, null, "مراقبت از پوست", null },
                    { 7, null, null, "پن", null },
                    { 8, null, null, "صابون", null },
                    { 9, null, null, "کرم", null },
                    { 10, null, null, "بالم لب", null },
                    { 11, null, null, "ضدآقتاب", null },
                    { 12, null, null, "ماسک صورت", null },
                    { 13, null, null, "ناحیه چشم", null },
                    { 14, null, null, "سرم و روغن", null },
                    { 15, null, null, "کیت ها", null },
                    { 16, null, null, "شامپو", null },
                    { 17, null, null, "ماسک مو", null },
                    { 18, null, null, "تونیک", null },
                    { 19, null, null, "سرم مو", null },
                    { 20, null, null, "روغن مو", null },
                    { 21, null, null, "کیت رویش مجدد موی سر", null },
                    { 22, null, null, "شامپو بدن", null },
                    { 23, null, null, "کرم", null },
                    { 24, null, null, "روغن و لوسیون", null },
                    { 25, null, null, "خوشبو کننده و ضد تعریق", null },
                    { 26, null, null, "مایع دستشویی", null },
                    { 27, null, null, "کرمBB", null },
                    { 28, null, null, "کرمCC", null },
                    { 29, null, null, "کرمDD", null },
                    { 30, null, null, "کانسیلر", null },
                    { 31, null, null, "پرفیوم و ادوپرفیوم", null },
                    { 32, null, null, "بادی میست", null },
                    { 33, null, null, "خمیر دندان", null },
                    { 34, null, null, "دهانشویه", null },
                    { 35, null, null, "خوشبو کننده دهان", null },
                    { 36, null, null, "محصولات تراست", null },
                    { 37, null, null, "خوشبو کننده هوا", null },
                    { 38, null, null, "پاک‌کننده و شوینده", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 918, DateTimeKind.Local).AddTicks(6044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 215, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 918, DateTimeKind.Local).AddTicks(4179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 215, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(8398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 918, DateTimeKind.Local).AddTicks(2033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 215, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(4889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(2331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 214, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 916, DateTimeKind.Local).AddTicks(971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 213, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 916, DateTimeKind.Local).AddTicks(8515),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 213, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 916, DateTimeKind.Local).AddTicks(6878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 213, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 916, DateTimeKind.Local).AddTicks(4842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 213, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(8534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(3791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 211, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(6248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 26, 15, 1, 41, 212, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "InsertTime" },
                values: new object[] { "سامسونگ", new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "InsertTime" },
                values: new object[] { "شیائومی ", new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "InsertTime" },
                values: new object[] { "اپل", new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "CatalogBrand",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "InsertTime" },
                values: new object[] { "هوآوی", new DateTime(2024, 9, 19, 3, 1, 31, 915, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.InsertData(
                table: "CatalogBrand",
                columns: new[] { "Id", "Brand", "RemoveTime", "UpdateTime" },
                values: new object[,]
                {
                    { 5, "نوکیا ", null, null },
                    { 6, "ال جی", null, null }
                });

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertTime", "Type" },
                values: new object[] { new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(2331), "کالای دیجیتال" });

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertTime", "Type" },
                values: new object[] { new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(2331), "لوازم جانبی گوشی" });

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertTime", "ParentCatalogTypeId", "Type" },
                values: new object[] { new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(2331), 2, "پایه نگهدارنده گوشی" });

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertTime", "ParentCatalogTypeId", "Type" },
                values: new object[] { new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(2331), 2, "پاور بانک (شارژر همراه)" });

            migrationBuilder.UpdateData(
                table: "CatalogType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertTime", "ParentCatalogTypeId", "Type" },
                values: new object[] { new DateTime(2024, 9, 19, 3, 1, 31, 917, DateTimeKind.Local).AddTicks(2331), 2, "کیف و کاور گوشی" });
        }
    }
}
