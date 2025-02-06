using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VillaApi.Migrations
{
    /// <inheritdoc />
    public partial class seedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rate",
                table: "Villas",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Occupancy",
                table: "Villas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sqft",
                table: "Villas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Russia is reportedly poised to begin serial production of a new derivative of the Iskander-M tactical ballistic missile with a range of 1,000 km. Reports about the existence of a 1,000 km range variant of the Iskander-M first surfaced in July 2024.", "https://www.eurasiantimes.com/wp-content/uploads/2022/03/Iskander-M.jpg?resize=696,464", "Royal Villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Iskander-M missile has a warhead that weighs between 710–800 kg. It is unlikely that the Iskander-1000 has a lighter warhead because a lighter warhead would not be effective against the types of high-value targets that the Iskander-M system is designed to attack.", "https://upload.wikimedia.org/wikipedia/commons/0/0d/Maiden_launch_of_Very_Short_Range_Air_Defence_System_%28VSHORADS%29_missile_%28cropped%29.jpg", "Diamond Villa", 3, 200.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In a big boost to the ‘Make in India’ initiative, the Defense Research and Development Organisation (DRDO) demonstrated its prowess by successfully testing the Very Short Range Air Defense System (VSHORAD).", "https://upload.wikimedia.org/wikipedia/commons/0/0d/Maiden_launch_of_Very_Short_Range_Air_Defence_System_%28VSHORADS%29_missile_%28cropped%29.jpg", "Platinum Villa", 2, 500.0, 1000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VSHORADS is a fourth-generation Man Portable Air Defense System (MANPAD). In general, MANPADS are lightweight anti-aircraft weapons intended for rapid deployment by ground forces. They are cost-effective, compact, and mobile, requiring only a single operator for use.", "https://upload.wikimedia.org/wikipedia/commons/0/0d/Maiden_launch_of_Very_Short_Range_Air_Defence_System_%28VSHORADS%29_missile_%28cropped%29.jpg", "Platinum Duper Villa", 2, 700.0, 1000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Occupancy",
                table: "Villas");

            migrationBuilder.DropColumn(
                name: "Sqft",
                table: "Villas");

            migrationBuilder.AlterColumn<string>(
                name: "Rate",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
