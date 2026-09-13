using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksShopWeb.Migrations;

/// <inheritdoc />
public partial class _20260912144621_AddDisplayOrderColumntoCategoriesTable : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<int>(
            name: "DisplayOrder",
            table: "Categories",
            type: "int",
            nullable: false,
            defaultValue: 0);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "Id",
            keyValue: 1,
            column: "DisplayOrder",
            value: 1);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "Id",
            keyValue: 2,
            column: "DisplayOrder",
            value: 2);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "Id",
            keyValue: 3,
            column: "DisplayOrder",
            value: 3);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "Id",
            keyValue: 4,
            column: "DisplayOrder",
            value: 4);

        migrationBuilder.UpdateData(
            table: "Categories",
            keyColumn: "Id",
            keyValue: 5,
            column: "DisplayOrder",
            value: 5);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "DisplayOrder",
            table: "Categories");
    }
}
