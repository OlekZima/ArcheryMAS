using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArcheryMAS.Migrations
{
    /// <inheritdoc />
    public partial class ArrowSetPersonArcher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Ginger");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "JB");

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
                keyValue: "Koda");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kona");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Mako");

            migrationBuilder.InsertData(
                table: "ArrowSet",
                columns: new[] { "ID", "ArrowLength", "ArrowQuantity", "MinQuantity", "State" },
                values: new object[,]
                {
                    { 45, 21.626989992822278, 7, 0, "New" },
                    { 46, 27.01799470280951, 11, 0, "New" },
                    { 47, 35.049556551780029, 12, 0, "Used" },
                    { 48, 21.196336160921078, 11, 0, "Broken" },
                    { 49, 25.016616769294309, 6, 0, "Used" },
                    { 50, 27.230507344967869, 6, 0, "New" },
                    { 51, 24.740968673315816, 7, 0, "Broken" },
                    { 52, 24.131572812209161, 7, 0, "Broken" },
                    { 53, 33.273050573475942, 11, 0, "Used" },
                    { 54, 28.569796632465682, 11, 0, "Used" }
                });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Jax",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 14.875844532830811, "Hoyt" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Niko",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 58.165808858714179, "Polaris" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Nile",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 62.830509980330355, "Polaris" });

            migrationBuilder.InsertData(
                table: "Bow",
                columns: new[] { "NickName", "Force", "Manufacturer" },
                values: new object[,]
                {
                    { "Bam", 62.187577921779372, "Easton" },
                    { "Barron", 56.390257621081673, "Mathews" },
                    { "Huss", 73.737640423218053, "Polaris" },
                    { "Knox", 24.058152986072969, "PSE" },
                    { "Moby", 59.324385575773647, "Bear" },
                    { "Nash", 15.954864261802102, "PSE" },
                    { "Nino", 14.634206157050144, "Easton" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "32745399630", 51, "Moby", new DateTime(1977, 1, 7, 3, 0, 52, 288, DateTimeKind.Local).AddTicks(1623), "Mateusz, Mateusz", "Staszewski" },
                    { "34565394197", 49, "Nash", new DateTime(1962, 12, 22, 18, 9, 29, 423, DateTimeKind.Local).AddTicks(5379), "Aleksandra, Aleksandra", "Łuczak" },
                    { "36012710454", 47, "Nile", new DateTime(1963, 4, 7, 8, 19, 24, 955, DateTimeKind.Local).AddTicks(5339), "Eugeniusz, Eugeniusz", "Duszyński" },
                    { "37977504032", 54, "Huss", new DateTime(1999, 7, 14, 12, 20, 30, 525, DateTimeKind.Local).AddTicks(268), "Nadzieja, Nadzieja", "Kubiak" },
                    { "40693627556", 50, "Niko", new DateTime(1969, 2, 12, 7, 41, 55, 477, DateTimeKind.Local).AddTicks(4162), "Innocenty, Innocenty", "Ziółkowski" },
                    { "46571807247", 45, "Knox", new DateTime(1967, 5, 5, 21, 55, 58, 479, DateTimeKind.Local).AddTicks(5598), "Katarzyna, Katarzyna", "Mazurkiewicz" },
                    { "68827910906", 46, "Bam", new DateTime(1985, 10, 17, 7, 43, 26, 800, DateTimeKind.Local).AddTicks(3039), "Gabriel, Gabriel", "Muszyński" },
                    { "81434779931", 48, "Barron", new DateTime(1981, 5, 4, 2, 3, 10, 363, DateTimeKind.Local).AddTicks(2235), "Ludwika, Ludwika", "Szymczyk" },
                    { "87049174607", 53, "Jax", new DateTime(1966, 3, 11, 10, 17, 24, 829, DateTimeKind.Local).AddTicks(213), "Roman, Roman", "Przybysz" },
                    { "97240929374", 52, "Nino", new DateTime(1955, 2, 23, 17, 55, 46, 262, DateTimeKind.Local).AddTicks(9772), "Józef, Józef", "Dróżdż" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[,]
                {
                    { "34565394197", null, "Cadet" },
                    { "46571807247", null, "Cadet" },
                    { "81434779931", null, "Cadet" },
                    { "87049174607", null, "Senior" },
                    { "97240929374", null, "Junior" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "34565394197");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "46571807247");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "81434779931");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "87049174607");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "97240929374");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "32745399630");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "36012710454");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "37977504032");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "40693627556");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "68827910906");

            migrationBuilder.DeleteData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Bam");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Huss");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Moby");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "34565394197");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "46571807247");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "81434779931");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "87049174607");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "97240929374");

            migrationBuilder.DeleteData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Barron");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Knox");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Nash");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Nino");

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Jax",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 79.660188688116747, "PSE" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Niko",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 51.811446980085286, "Mathews" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Nile",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 49.881938341900671, "PSE" });

            migrationBuilder.InsertData(
                table: "Bow",
                columns: new[] { "NickName", "Force", "Manufacturer" },
                values: new object[,]
                {
                    { "Ginger", 83.667728707670094, "PSE" },
                    { "JB", 60.581451359478272, "PSE" },
                    { "Kai", 27.061067505680814, "Bear" },
                    { "Kip", 66.725081222875303, "Mathews" },
                    { "Koda", 19.793066423654764, "Bear" },
                    { "Kona", 17.79957357514877, "PSE" },
                    { "Mako", 21.876868033532027, "Easton" }
                });
        }
    }
}
