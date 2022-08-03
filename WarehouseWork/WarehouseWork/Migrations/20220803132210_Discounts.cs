using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WarehouseWork.Migrations
{
    public partial class Discounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastDiscountsDependingSeasonDay",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDiscountsDependingSeasonDay",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "discountPercentage",
                table: "Products",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastDiscountsDependingSeasonDay",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StartDiscountsDependingSeasonDay",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "discountPercentage",
                table: "Products");
        }
    }
}
