using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STAR_WARS_API.Migrations
{
    /// <inheritdoc />
    public partial class CreateDirectorsTab : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birth_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    biography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Directors");
        }
    }
}
