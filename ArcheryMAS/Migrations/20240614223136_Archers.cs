using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArcheryMAS.Migrations
{
    /// <inheritdoc />
    public partial class Archers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "Jinx");

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

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kyan",
                column: "Force",
                value: 43.0);

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Neo",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 94.0, "Polaris" });

            migrationBuilder.InsertData(
                table: "Bow",
                columns: new[] { "NickName", "Force", "Manufacturer" },
                values: new object[,]
                {
                    { "Barron", 25.0, "PSE" },
                    { "Mack", 69.0, "Easton" },
                    { "Moby", 94.0, "Polaris" },
                    { "Moe", 33.0, "Bear" },
                    { "Nash", 72.0, "Polaris" },
                    { "Niko", 62.0, "Mathews" },
                    { "Nino", 69.0, "Polaris" },
                    { "The Balloon Buster", 17.0, "Easton" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "00896811344", 0, "Neo", new DateTime(2024, 3, 7, 17, 47, 33, 878, DateTimeKind.Local).AddTicks(1844), "Zachary, Melania", "Łukasiewicz" },
                    { "01270081646", 0, "Kyan", new DateTime(2018, 2, 13, 14, 30, 36, 645, DateTimeKind.Local).AddTicks(9544), "Jeremiasz, Barbara", "Podgórski" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[] { "01270081646", null, "Cadet" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "05214380164", 0, "Niko", new DateTime(2005, 1, 23, 22, 7, 22, 241, DateTimeKind.Local).AddTicks(2974), "Eudoksja, Bertram", "Wróblewski" },
                    { "10426673524", 0, "Mack", new DateTime(2007, 4, 23, 5, 41, 9, 91, DateTimeKind.Local).AddTicks(2968), "Nazary, Mojżesz", "Pluta" },
                    { "13587117771", 0, "Moe", new DateTime(2014, 12, 23, 18, 44, 14, 233, DateTimeKind.Local).AddTicks(5255), "Nikola, Zygmunt", "Jezierski" },
                    { "25332412701", 0, "Nash", new DateTime(2006, 10, 18, 6, 22, 59, 347, DateTimeKind.Local).AddTicks(8036), "Zuzanna, Hanna", "Szymczak" },
                    { "76258169695", 0, "The Balloon Buster", new DateTime(2017, 7, 8, 18, 17, 18, 602, DateTimeKind.Local).AddTicks(8547), "Rufina, Cecylia", "Grześkowiak" },
                    { "92616833959", 0, "Barron", new DateTime(2009, 5, 3, 21, 11, 53, 619, DateTimeKind.Local).AddTicks(8527), "Damian, Tomasz", "Kuciński" },
                    { "93805491645", 0, "Moby", new DateTime(2020, 2, 16, 1, 35, 16, 933, DateTimeKind.Local).AddTicks(1513), "Agrypina, Ariadna", "Marciniak" },
                    { "93920951762", 0, "Nino", new DateTime(2023, 7, 22, 1, 4, 54, 7, DateTimeKind.Local).AddTicks(4101), "Helena, Leon", "Kurek" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[,]
                {
                    { "05214380164", null, "Junior" },
                    { "10426673524", null, "Senior" },
                    { "13587117771", null, "Senior" },
                    { "92616833959", null, "Senior" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "01270081646");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "05214380164");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "10426673524");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "13587117771");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "92616833959");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "00896811344");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "25332412701");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "76258169695");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "93805491645");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "93920951762");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Moby");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Nash");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Nino");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "The Balloon Buster");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "01270081646");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "05214380164");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "10426673524");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "13587117771");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "92616833959");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Barron");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Mack");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Moe");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Niko");

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kyan",
                column: "Force",
                value: 77.0);

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Neo",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 59.0, "PSE" });

            migrationBuilder.InsertData(
                table: "Bow",
                columns: new[] { "NickName", "Force", "Manufacturer" },
                values: new object[,]
                {
                    { "Jax", 41.0, "Mathews" },
                    { "Jinx", 91.0, "Easton" },
                    { "Kane", 15.0, "Polaris" },
                    { "Knox", 64.0, "Easton" },
                    { "Kota", 68.0, "Bear" },
                    { "Kruz", 90.0, "Bear" },
                    { "Mako", 40.0, "Easton" },
                    { "Milo", 42.0, "PSE" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "06512252497", 0, "Kyan", new DateTime(2008, 7, 19, 18, 25, 23, 37, DateTimeKind.Local).AddTicks(7497), "Bertrand, Henryka", "Antczak" },
                    { "69614421316", 0, "Neo", new DateTime(2012, 12, 2, 2, 34, 38, 903, DateTimeKind.Local).AddTicks(3792), "Albert, Łazarz", "Świerczyński" },
                    { "07093601852", 0, "Kota", new DateTime(2016, 1, 22, 19, 53, 17, 507, DateTimeKind.Local).AddTicks(6255), "Antoni, Lilia", "Trzciński" },
                    { "12261960704", 0, "Kruz", new DateTime(2019, 5, 14, 21, 40, 8, 688, DateTimeKind.Local).AddTicks(8924), "Korneli, Aurora", "Miller" },
                    { "32853957397", 0, "Milo", new DateTime(2018, 5, 14, 16, 31, 21, 413, DateTimeKind.Local).AddTicks(7872), "Grzegorz, Cecylia", "Woś" },
                    { "35550755289", 0, "Mako", new DateTime(2013, 12, 6, 14, 10, 13, 680, DateTimeKind.Local).AddTicks(2166), "Orestes, Jeremiasz", "Bielski" },
                    { "66198006684", 0, "Jax", new DateTime(2006, 8, 11, 22, 37, 34, 671, DateTimeKind.Local).AddTicks(6194), "Marek, Bruno", "Herman" },
                    { "77553504020", 0, "Jinx", new DateTime(2018, 9, 21, 3, 4, 42, 699, DateTimeKind.Local).AddTicks(8995), "Tacjana, Korneliusz", "Adamowicz" },
                    { "82226925492", 0, "Kane", new DateTime(2012, 5, 20, 17, 56, 23, 834, DateTimeKind.Local).AddTicks(4809), "Edmund, Dariusz", "Siedlecki" },
                    { "84229279756", 0, "Knox", new DateTime(2019, 3, 31, 21, 51, 5, 348, DateTimeKind.Local).AddTicks(5868), "Walery, Ireneusz", "Komorowski" }
                });
        }
    }
}
