using Microsoft.EntityFrameworkCore.Migrations;

namespace Weaver.Migrations
{
    public partial class idk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValueComponent<DateTime>_Value",
                table: "JournalComponents");

            migrationBuilder.AddColumn<bool>(
                name: "EnableTime",
                table: "JournalComponents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnableTime",
                table: "JournalComponents");

            migrationBuilder.AddColumn<string>(
                name: "ValueComponent<DateTime>_Value",
                table: "JournalComponents",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
