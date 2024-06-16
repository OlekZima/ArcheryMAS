using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArcheryMAS.Migrations
{
    /// <inheritdoc />
    public partial class FixName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Huss");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Moby");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Niko");

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
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Barron");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Jax");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Knox");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Nino");

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "ArrowLength", "ArrowQuantity" },
                values: new object[] { 31.202022359485682, 6 });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 28.790868543778348, 10, "Broken" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 34.266556707575653, 9, "Broken" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "ArrowLength", "State" },
                values: new object[] { 33.305163011060145, "Used" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 36.972003646064877, 9, "Broken" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 22.52871953834233, 8, "Broken" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 39.117178503798236, 10, "New" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 26.374453501102575, 11, "Used" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "ArrowLength", "ArrowQuantity" },
                values: new object[] { 32.33969771780103, 8 });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 25.642501563257621, 8, "Broken" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Bam",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 39.630445426448652, "PSE" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Nash",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 25.271686831546461, "Hoyt" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Nile",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 25.199545992582856, "Easton" });

            migrationBuilder.InsertData(
                table: "Bow",
                columns: new[] { "NickName", "Force", "Manufacturer" },
                values: new object[,]
                {
                    { "Bo", 59.425499819124468, "PSE" },
                    { "Ginger", 78.155260500288009, "Bear" },
                    { "Jinx", 76.446941078189312, "Easton" },
                    { "Kip", 25.522169910746822, "Hoyt" },
                    { "Koda", 83.805043784932948, "Easton" },
                    { "Mack", 45.128274872978253, "Easton" },
                    { "Neo", 47.127804667112322, "Bear" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "66299831239", 51, "Bam", new DateTime(1961, 9, 25, 3, 24, 31, 957, DateTimeKind.Local).AddTicks(6003), "Justyna, Tomasz", "Pająk" },
                    { "81329863211", 54, "Nile", new DateTime(1991, 1, 15, 9, 58, 52, 668, DateTimeKind.Local).AddTicks(5389), "Onufry, Kleopatra", "Milewski" },
                    { "98245229845", 50, "Nash", new DateTime(1971, 6, 16, 18, 5, 18, 666, DateTimeKind.Local).AddTicks(5098), "Hieronim, Ida", "Wnuk" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[,]
                {
                    { "66299831239", null, "Junior" },
                    { "81329863211", null, "Senior" },
                    { "98245229845", null, "Junior" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "16709791766", 45, "Bo", new DateTime(1984, 1, 3, 20, 56, 27, 290, DateTimeKind.Local).AddTicks(6732), "Eustracjusz, Kamila", "Leśniewski" },
                    { "44676240041", 49, "Kip", new DateTime(1958, 5, 22, 5, 48, 34, 386, DateTimeKind.Local).AddTicks(1640), "Karolina, Lea", "Przybył" },
                    { "45004851850", 47, "Ginger", new DateTime(1965, 4, 19, 18, 38, 48, 807, DateTimeKind.Local).AddTicks(12), "Prokop, Agrypina", "Łuczak" },
                    { "50540141027", 52, "Jinx", new DateTime(1999, 7, 17, 8, 10, 30, 98, DateTimeKind.Local).AddTicks(9858), "Diana, Nikodem", "Maślanka" },
                    { "50910221135", 48, "Koda", new DateTime(1988, 10, 27, 23, 1, 48, 545, DateTimeKind.Local).AddTicks(3119), "Hubert, Larysa", "Marchewka" },
                    { "74198294289", 53, "Neo", new DateTime(2002, 12, 7, 7, 44, 6, 123, DateTimeKind.Local).AddTicks(9048), "Walenty, Jakubina", "Żmuda" },
                    { "84096874650", 46, "Mack", new DateTime(2003, 1, 3, 20, 15, 26, 635, DateTimeKind.Local).AddTicks(263), "Arystarch, Luiza", "Janusz" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[,]
                {
                    { "50910221135", null, "Cadet" },
                    { "74198294289", null, "Senior" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "50910221135");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "66299831239");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "74198294289");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "81329863211");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "98245229845");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "16709791766");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "44676240041");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "45004851850");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "50540141027");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "84096874650");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Bo");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Ginger");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Jinx");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kip");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Mack");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "50910221135");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "66299831239");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "74198294289");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "81329863211");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "98245229845");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Koda");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Neo");

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "ArrowLength", "ArrowQuantity" },
                values: new object[] { 21.626989992822278, 7 });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 27.01799470280951, 11, "New" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 35.049556551780029, 12, "Used" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "ArrowLength", "State" },
                values: new object[] { 21.196336160921078, "Broken" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 25.016616769294309, 6, "Used" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 27.230507344967869, 6, "New" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 24.740968673315816, 7, "Broken" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 24.131572812209161, 7, "Broken" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "ArrowLength", "ArrowQuantity" },
                values: new object[] { 33.273050573475942, 11 });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 28.569796632465682, 11, "Used" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Bam",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 62.187577921779372, "Easton" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Nash",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 15.954864261802102, "PSE" });

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
                    { "Barron", 56.390257621081673, "Mathews" },
                    { "Huss", 73.737640423218053, "Polaris" },
                    { "Jax", 14.875844532830811, "Hoyt" },
                    { "Knox", 24.058152986072969, "PSE" },
                    { "Moby", 59.324385575773647, "Bear" },
                    { "Niko", 58.165808858714179, "Polaris" },
                    { "Nino", 14.634206157050144, "Easton" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "34565394197", 49, "Nash", new DateTime(1962, 12, 22, 18, 9, 29, 423, DateTimeKind.Local).AddTicks(5379), "Aleksandra, Aleksandra", "Łuczak" },
                    { "36012710454", 47, "Nile", new DateTime(1963, 4, 7, 8, 19, 24, 955, DateTimeKind.Local).AddTicks(5339), "Eugeniusz, Eugeniusz", "Duszyński" },
                    { "68827910906", 46, "Bam", new DateTime(1985, 10, 17, 7, 43, 26, 800, DateTimeKind.Local).AddTicks(3039), "Gabriel, Gabriel", "Muszyński" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[] { "34565394197", null, "Cadet" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "32745399630", 51, "Moby", new DateTime(1977, 1, 7, 3, 0, 52, 288, DateTimeKind.Local).AddTicks(1623), "Mateusz, Mateusz", "Staszewski" },
                    { "37977504032", 54, "Huss", new DateTime(1999, 7, 14, 12, 20, 30, 525, DateTimeKind.Local).AddTicks(268), "Nadzieja, Nadzieja", "Kubiak" },
                    { "40693627556", 50, "Niko", new DateTime(1969, 2, 12, 7, 41, 55, 477, DateTimeKind.Local).AddTicks(4162), "Innocenty, Innocenty", "Ziółkowski" },
                    { "46571807247", 45, "Knox", new DateTime(1967, 5, 5, 21, 55, 58, 479, DateTimeKind.Local).AddTicks(5598), "Katarzyna, Katarzyna", "Mazurkiewicz" },
                    { "81434779931", 48, "Barron", new DateTime(1981, 5, 4, 2, 3, 10, 363, DateTimeKind.Local).AddTicks(2235), "Ludwika, Ludwika", "Szymczyk" },
                    { "87049174607", 53, "Jax", new DateTime(1966, 3, 11, 10, 17, 24, 829, DateTimeKind.Local).AddTicks(213), "Roman, Roman", "Przybysz" },
                    { "97240929374", 52, "Nino", new DateTime(1955, 2, 23, 17, 55, 46, 262, DateTimeKind.Local).AddTicks(9772), "Józef, Józef", "Dróżdż" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[,]
                {
                    { "46571807247", null, "Cadet" },
                    { "81434779931", null, "Cadet" },
                    { "87049174607", null, "Senior" },
                    { "97240929374", null, "Junior" }
                });
        }
    }
}
