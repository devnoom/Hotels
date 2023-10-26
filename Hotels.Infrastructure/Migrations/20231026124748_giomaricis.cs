using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotels.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class giomaricis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Namastes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Sqft = table.Column<int>(type: "int", nullable: false),
                    Occupancy = table.Column<int>(type: "int", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Namastes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NamasteNumbers",
                columns: table => new
                {
                    Namaste_Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamasteId = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NamasteNumbers", x => x.Namaste_Number);
                    table.ForeignKey(
                        name: "FK_NamasteNumbers_Namastes_NamasteId",
                        column: x => x.NamasteId,
                        principalTable: "Namastes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "NamasteNumbers",
                columns: new[] { "Namaste_Number", "NamasteId", "SpecialDetails" },
                values: new object[,]
                {
                    { 101, 15, null },
                    { 102, 15, null },
                    { 103, 15, null },
                    { 201, 16, null },
                    { 202, 16, null },
                    { 203, 16, null },
                    { 301, 17, null },
                    { 302, 17, null },
                    { 303, 17, null }
                });

            migrationBuilder.InsertData(
                table: "Namastes",
                columns: new[] { "Id", "Created_Date", "Description", "ImgUrl", "Name", "Occupancy", "Price", "Sqft", "Updated_Date" },
                values: new object[,]
                {
                    { 1, null, "Namaste tbilis one of the best hotel", "https://placehold.co/600x400", "Namaste Tbilisi", 6, 300.0, 550, null },
                    { 2, null, "Namaste Batumi one of the best hotel", "https://placehold.co/600x401", "Namaste Batumi", 8, 400.0, 650, null },
                    { 3, null, "Namaste Yazbegi one of the best hotel", "https://placehold.co/600x402", "Namaste Yazbegi", 12, 700.0, 850, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NamasteNumbers_NamasteId",
                table: "NamasteNumbers",
                column: "NamasteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NamasteNumbers");

            migrationBuilder.DropTable(
                name: "Namastes");
        }
    }
}
