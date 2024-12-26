using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud__operation.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDepId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "Staffs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
