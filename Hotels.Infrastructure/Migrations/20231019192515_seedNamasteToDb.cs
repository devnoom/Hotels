using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotels.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedNamasteToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Namastes",
                columns: new[] { "Id", "Created_Date", "Description", "ImgUrl", "Name", "Occupancy", "Price", "Sqft", "Updated_Date" },
                values: new object[,]
                {
                    { 1, null, "Namaste tbilis one of the best hotel", "https://placehold.co/600x400", "Namaste Tbilisi", 6, 300.0, 550, null },
                    { 2, null, "Namaste Batumi one of the best hotel", "https://placehold.co/600x401", "Namaste Batumi", 8, 400.0, 650, null },
                    { 3, null, "Namaste Yazbegi one of the best hotel", "https://placehold.co/600x402", "Namaste Yazbegi", 12, 700.0, 850, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Namastes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Namastes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Namastes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
