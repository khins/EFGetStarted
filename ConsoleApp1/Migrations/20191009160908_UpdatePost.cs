using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFGetStarted.Migrations
{
    public partial class UpdatePost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateRecordWritten",
                table: "Posts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateRecordWritten",
                table: "Posts");
        }
    }
}
