using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Peter_sToDoManager.Migrations
{
    /// <inheritdoc />
    public partial class AddedCompleteAndDeletedToTaskModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Complete",
                table: "Tasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Tasks",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Complete",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Tasks");
        }
    }
}
