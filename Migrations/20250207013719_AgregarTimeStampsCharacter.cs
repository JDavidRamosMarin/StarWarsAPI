using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STAR_WARS_API.Migrations
{
    /// <inheritdoc />
    public partial class AgregarTimeStampsCharacter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "Characters",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "Update_at",
                table: "Characters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Update_at",
                table: "Characters");
        }
    }
}
