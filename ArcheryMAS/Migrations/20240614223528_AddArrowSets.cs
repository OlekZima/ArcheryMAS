using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArcheryMAS.Migrations
{
    /// <inheritdoc />
    public partial class AddArrowSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "Nash");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Neo");

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
                keyValue: "Kyan");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Mack");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Niko");

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Barron",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 43.0, "Hoyt" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Moby",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 47.0, "Hoyt" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Moe",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 66.0, "Mathews" });

            migrationBuilder.InsertData(
                table: "Bow",
                columns: new[] { "NickName", "Force", "Manufacturer" },
                values: new object[,]
                {
                    { "Bam", 76.0, "Hoyt" },
                    { "Jax", 99.0, "Hoyt" },
                    { "Jinx", 26.0, "Hoyt" },
                    { "Kai", 39.0, "Bear" },
                    { "Kip", 27.0, "Polaris" },
                    { "Kruz", 35.0, "Hoyt" },
                    { "Mars", 86.0, "Polaris" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "01159055248", 0, "Moby", new DateTime(2021, 10, 11, 9, 7, 35, 769, DateTimeKind.Local).AddTicks(2118), "Konstanty, Ewa", "Wąsowski" },
                    { "18540233708", 0, "Moe", new DateTime(2024, 6, 4, 21, 29, 35, 429, DateTimeKind.Local).AddTicks(4567), "Bibiana, Dina", "Szulc" },
                    { "26676578951", 0, "Barron", new DateTime(2012, 12, 16, 21, 20, 47, 89, DateTimeKind.Local).AddTicks(6320), "Lilia, Emil", "Mróz" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[] { "26676578951", null, "Cadet" });

            migrationBuilder.InsertData(
                table: "ArrowSet",
                columns: new[] { "ID", "ArrowLength", "ArrowQuantity", "Person_PESEL", "State" },
                values: new object[] { 74, 0.0, 0, "26676578951", "Broken" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "07523261586", 0, "Jinx", new DateTime(2007, 3, 23, 12, 43, 15, 64, DateTimeKind.Local).AddTicks(7797), "Natalia, Tekla", "Borkowski" },
                    { "13862601160", 0, "Kai", new DateTime(2009, 11, 18, 4, 59, 20, 450, DateTimeKind.Local).AddTicks(7696), "Nadzieja, Lucjan", "Augustyniak" },
                    { "14984350782", 0, "Kip", new DateTime(2015, 12, 30, 8, 8, 33, 958, DateTimeKind.Local).AddTicks(752), "Jakubina, Hubert", "Krukowski" },
                    { "17817556077", 0, "Bam", new DateTime(2006, 9, 20, 22, 34, 6, 660, DateTimeKind.Local).AddTicks(8707), "Gedeon, Matylda", "Stawicki" },
                    { "48704357137", 0, "Jax", new DateTime(2015, 12, 25, 19, 33, 51, 651, DateTimeKind.Local).AddTicks(7020), "Eliasz, Artur", "Cieślik" },
                    { "67514893904", 0, "Kruz", new DateTime(2023, 2, 5, 6, 8, 7, 166, DateTimeKind.Local).AddTicks(6141), "Aida, Żaneta", "Kurek" },
                    { "72000074957", 0, "Mars", new DateTime(2009, 12, 8, 15, 59, 12, 820, DateTimeKind.Local).AddTicks(4596), "Benedykt, Józef", "Palacz" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[,]
                {
                    { "07523261586", null, "Junior" },
                    { "13862601160", null, "Junior" },
                    { "14984350782", null, "Junior" },
                    { "67514893904", null, "Senior" }
                });

            migrationBuilder.InsertData(
                table: "ArrowSet",
                columns: new[] { "ID", "ArrowLength", "ArrowQuantity", "Person_PESEL", "State" },
                values: new object[,]
                {
                    { 37, 0.0, 0, "14984350782", "Broken" },
                    { 42, 0.0, 0, "13862601160", "Broken" },
                    { 54, 0.0, 0, "67514893904", "New" },
                    { 71, 0.0, 0, "07523261586", "Broken" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "07523261586");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "13862601160");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "14984350782");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "26676578951");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "67514893904");

            migrationBuilder.DeleteData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "01159055248");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "17817556077");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "18540233708");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "48704357137");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "72000074957");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Bam");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Jax");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Mars");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "07523261586");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "13862601160");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "14984350782");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "26676578951");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "67514893904");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Jinx");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kai");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kip");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kruz");

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Barron",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 25.0, "PSE" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Moby",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 94.0, "Polaris" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Moe",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 33.0, "Bear" });

            migrationBuilder.InsertData(
                table: "Bow",
                columns: new[] { "NickName", "Force", "Manufacturer" },
                values: new object[,]
                {
                    { "Kyan", 43.0, "PSE" },
                    { "Mack", 69.0, "Easton" },
                    { "Nash", 72.0, "Polaris" },
                    { "Neo", 94.0, "Polaris" },
                    { "Niko", 62.0, "Mathews" },
                    { "Nino", 69.0, "Polaris" },
                    { "The Balloon Buster", 17.0, "Easton" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "13587117771", 0, "Moe", new DateTime(2014, 12, 23, 18, 44, 14, 233, DateTimeKind.Local).AddTicks(5255), "Nikola, Zygmunt", "Jezierski" },
                    { "92616833959", 0, "Barron", new DateTime(2009, 5, 3, 21, 11, 53, 619, DateTimeKind.Local).AddTicks(8527), "Damian, Tomasz", "Kuciński" },
                    { "93805491645", 0, "Moby", new DateTime(2020, 2, 16, 1, 35, 16, 933, DateTimeKind.Local).AddTicks(1513), "Agrypina, Ariadna", "Marciniak" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[,]
                {
                    { "13587117771", null, "Senior" },
                    { "92616833959", null, "Senior" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "00896811344", 0, "Neo", new DateTime(2024, 3, 7, 17, 47, 33, 878, DateTimeKind.Local).AddTicks(1844), "Zachary, Melania", "Łukasiewicz" },
                    { "01270081646", 0, "Kyan", new DateTime(2018, 2, 13, 14, 30, 36, 645, DateTimeKind.Local).AddTicks(9544), "Jeremiasz, Barbara", "Podgórski" },
                    { "05214380164", 0, "Niko", new DateTime(2005, 1, 23, 22, 7, 22, 241, DateTimeKind.Local).AddTicks(2974), "Eudoksja, Bertram", "Wróblewski" },
                    { "10426673524", 0, "Mack", new DateTime(2007, 4, 23, 5, 41, 9, 91, DateTimeKind.Local).AddTicks(2968), "Nazary, Mojżesz", "Pluta" },
                    { "25332412701", 0, "Nash", new DateTime(2006, 10, 18, 6, 22, 59, 347, DateTimeKind.Local).AddTicks(8036), "Zuzanna, Hanna", "Szymczak" },
                    { "76258169695", 0, "The Balloon Buster", new DateTime(2017, 7, 8, 18, 17, 18, 602, DateTimeKind.Local).AddTicks(8547), "Rufina, Cecylia", "Grześkowiak" },
                    { "93920951762", 0, "Nino", new DateTime(2023, 7, 22, 1, 4, 54, 7, DateTimeKind.Local).AddTicks(4101), "Helena, Leon", "Kurek" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[,]
                {
                    { "01270081646", null, "Cadet" },
                    { "05214380164", null, "Junior" },
                    { "10426673524", null, "Senior" }
                });
        }
    }
}
