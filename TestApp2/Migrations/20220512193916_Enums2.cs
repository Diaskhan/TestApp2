using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApp2.Migrations
{
    public partial class Enums2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Tasks",
                newName: "TaskStatus");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Projects",
                newName: "ProjectStatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaskStatus",
                table: "Tasks",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "ProjectStatus",
                table: "Projects",
                newName: "Status");
        }
    }
}
