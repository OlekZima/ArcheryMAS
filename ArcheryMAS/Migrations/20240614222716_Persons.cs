using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArcheryMAS.Migrations
{
    /// <inheritdoc />
    public partial class Persons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Beazle");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Ginger");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Huss");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kai");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kona");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Mars");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Niko");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Nino");

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Jinx",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 91.0, "Easton" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kyan",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 77.0, "PSE" });

            migrationBuilder.InsertData(
                table: "Bow",
                columns: new[] { "NickName", "Force", "Manufacturer" },
                values: new object[,]
                {
                    { "Jax", 41.0, "Mathews" },
                    { "Kane", 15.0, "Polaris" },
                    { "Knox", 64.0, "Easton" },
                    { "Kota", 68.0, "Bear" },
                    { "Kruz", 90.0, "Bear" },
                    { "Mako", 40.0, "Easton" },
                    { "Milo", 42.0, "PSE" },
                    { "Neo", 59.0, "PSE" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "06512252497", 0, "Kyan", new DateTime(2008, 7, 19, 18, 25, 23, 37, DateTimeKind.Local).AddTicks(7497), "Bertrand, Henryka", "Antczak" },
                    { "77553504020", 0, "Jinx", new DateTime(2018, 9, 21, 3, 4, 42, 699, DateTimeKind.Local).AddTicks(8995), "Tacjana, Korneliusz", "Adamowicz" },
                    { "07093601852", 0, "Kota", new DateTime(2016, 1, 22, 19, 53, 17, 507, DateTimeKind.Local).AddTicks(6255), "Antoni, Lilia", "Trzciński" },
                    { "12261960704", 0, "Kruz", new DateTime(2019, 5, 14, 21, 40, 8, 688, DateTimeKind.Local).AddTicks(8924), "Korneli, Aurora", "Miller" },
                    { "32853957397", 0, "Milo", new DateTime(2018, 5, 14, 16, 31, 21, 413, DateTimeKind.Local).AddTicks(7872), "Grzegorz, Cecylia", "Woś" },
                    { "35550755289", 0, "Mako", new DateTime(2013, 12, 6, 14, 10, 13, 680, DateTimeKind.Local).AddTicks(2166), "Orestes, Jeremiasz", "Bielski" },
                    { "66198006684", 0, "Jax", new DateTime(2006, 8, 11, 22, 37, 34, 671, DateTimeKind.Local).AddTicks(6194), "Marek, Bruno", "Herman" },
                    { "69614421316", 0, "Neo", new DateTime(2012, 12, 2, 2, 34, 38, 903, DateTimeKind.Local).AddTicks(3792), "Albert, Łazarz", "Świerczyński" },
                    { "82226925492", 0, "Kane", new DateTime(2012, 5, 20, 17, 56, 23, 834, DateTimeKind.Local).AddTicks(4809), "Edmund, Dariusz", "Siedlecki" },
                    { "84229279756", 0, "Knox", new DateTime(2019, 3, 31, 21, 51, 5, 348, DateTimeKind.Local).AddTicks(5868), "Walery, Ireneusz", "Komorowski" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "06512252497");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "07093601852");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "12261960704");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "32853957397");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "35550755289");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "66198006684");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "69614421316");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "77553504020");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "82226925492");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "84229279756");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Jax");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kane");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Knox");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kota");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kruz");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Mako");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Milo");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Neo");

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Jinx",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 35.0, "Bear" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kyan",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 72.0, "Easton" });

            migrationBuilder.InsertData(
                table: "Bow",
                columns: new[] { "NickName", "Force", "Manufacturer" },
                values: new object[,]
                {
                    { "Beazle", 85.0, "Polaris" },
                    { "Ginger", 90.0, "Polaris" },
                    { "Huss", 47.0, "Mathews" },
                    { "Kai", 58.0, "Mathews" },
                    { "Kona", 89.0, "PSE" },
                    { "Mars", 58.0, "Easton" },
                    { "Niko", 60.0, "Hoyt" },
                    { "Nino", 20.0, "Bear" }
                });
        }
    }
}
