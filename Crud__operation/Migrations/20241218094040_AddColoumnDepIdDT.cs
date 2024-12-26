using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud__operation.Migrations
{
    /// <inheritdoc />
    public partial class AddColoumnDepIdDT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Staffs");
        }
    }
}
