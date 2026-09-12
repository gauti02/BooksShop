using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksShopWeb.Migrations;

/// <inheritdoc />
public partial class _20260912142539_UpdateColumnNametoID : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameColumn(
            name: "CategoryIdentification",
            table: "Categories",
            newName: "Id");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameColumn(
            name: "Id",
            table: "Categories",
            newName: "CategoryIdentification");
    }
}
