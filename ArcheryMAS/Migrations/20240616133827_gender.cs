using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArcheryMAS.Migrations
{
    /// <inheritdoc />
    public partial class gender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "Bam");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Koda");

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
                keyValue: "Nile");

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 38.672065074396997, 7, "Used" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 38.430618901890568, 11, "New" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 28.119056535633117, 6, "New" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "ArrowLength", "ArrowQuantity" },
                values: new object[] { 37.666080501760518, 8 });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 38.909228949301905, 7, "New" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "ArrowLength", "State" },
                values: new object[] { 30.955135255116911, "Used" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "ArrowLength", "ArrowQuantity" },
                values: new object[] { 30.006605491087971, 8 });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "ArrowLength", "ArrowQuantity" },
                values: new object[] { 24.81612164873841, 12 });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 23.366387968634449, 7, "Broken" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "ArrowLength", "ArrowQuantity" },
                values: new object[] { 21.206729904099074, 7 });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Ginger",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 28.379126707026682, "PSE" });

            migrationBuilder.InsertData(
                table: "Bow",
                columns: new[] { "NickName", "Force", "Manufacturer" },
                values: new object[,]
                {
                    { "Barron", 59.540117333295747, "Mathews" },
                    { "Huss", 84.655076454387881, "Bear" },
                    { "Kai", 89.341091936417129, "PSE" },
                    { "Kota", 49.350304875064033, "PSE" },
                    { "Loki", 80.779617393814306, "Easton" },
                    { "Mako", 94.588001524327694, "Bear" },
                    { "Moby", 59.224490326244862, "Hoyt" },
                    { "Moe", 46.800722963384736, "Mathews" },
                    { "Niko", 80.594503182016695, "Mathews" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[] { "55655467444", 48, "Ginger", new DateTime(1969, 6, 11, 14, 26, 41, 522, DateTimeKind.Local).AddTicks(2047), "Janusz, Ansgary", "Dudziak" });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[] { "55655467444", null, "Junior" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "01031833697", 52, "Huss", new DateTime(1975, 5, 28, 3, 0, 51, 97, DateTimeKind.Local).AddTicks(9098), "Judyta, Ludwika", "Wieczorek" },
                    { "13355429133", 53, "Kota", new DateTime(1957, 11, 16, 12, 44, 50, 625, DateTimeKind.Local).AddTicks(8187), "Makary, Rajnold", "Urbanowicz" },
                    { "17633020386", 54, "Mako", new DateTime(1974, 4, 17, 5, 56, 55, 843, DateTimeKind.Local).AddTicks(2421), "Dina, Ida", "Jurkowski" },
                    { "18175766436", 49, "Moe", new DateTime(1998, 3, 12, 9, 20, 10, 420, DateTimeKind.Local).AddTicks(3091), "Lea, Aleksandra", "Panek" },
                    { "19912380255", 50, "Moby", new DateTime(1971, 9, 11, 22, 49, 20, 700, DateTimeKind.Local).AddTicks(9655), "Teodor, Kira", "Janusz" },
                    { "24819451900", 45, "Barron", new DateTime(1977, 11, 1, 5, 53, 38, 653, DateTimeKind.Local).AddTicks(6669), "Kornelia, Izydor", "Chmiel" },
                    { "41398581242", 46, "Kai", new DateTime(1997, 2, 24, 16, 22, 7, 342, DateTimeKind.Local).AddTicks(1719), "Agaton, Małgorzata", "Michalik" },
                    { "76201434161", 51, "Niko", new DateTime(1981, 10, 24, 11, 30, 10, 848, DateTimeKind.Local).AddTicks(7994), "Leila, Daniel", "Jędrzejewski" },
                    { "77546760995", 47, "Loki", new DateTime(1998, 4, 17, 5, 1, 11, 277, DateTimeKind.Local).AddTicks(6065), "Karolina, Kira", "Kasperek" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[,]
                {
                    { "01031833697", null, "Junior" },
                    { "13355429133", null, "Cadet" },
                    { "19912380255", null, "Cadet" },
                    { "24819451900", null, "Junior" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "01031833697");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "13355429133");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "19912380255");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "24819451900");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "55655467444");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "17633020386");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "18175766436");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "41398581242");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "76201434161");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "77546760995");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kai");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Loki");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Mako");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Moe");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Niko");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "01031833697");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "13355429133");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "19912380255");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "24819451900");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "55655467444");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Barron");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Huss");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kota");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Moby");

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 31.202022359485682, 6, "New" });

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
                columns: new[] { "ArrowLength", "ArrowQuantity" },
                values: new object[] { 33.305163011060145, 11 });

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
                columns: new[] { "ArrowLength", "State" },
                values: new object[] { 22.52871953834233, "Broken" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "ArrowLength", "ArrowQuantity" },
                values: new object[] { 39.117178503798236, 10 });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "ArrowLength", "ArrowQuantity" },
                values: new object[] { 26.374453501102575, 11 });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 32.33969771780103, 8, "Used" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "ArrowLength", "ArrowQuantity" },
                values: new object[] { 25.642501563257621, 8 });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Ginger",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 78.155260500288009, "Bear" });

            migrationBuilder.InsertData(
                table: "Bow",
                columns: new[] { "NickName", "Force", "Manufacturer" },
                values: new object[,]
                {
                    { "Bam", 39.630445426448652, "PSE" },
                    { "Bo", 59.425499819124468, "PSE" },
                    { "Jinx", 76.446941078189312, "Easton" },
                    { "Kip", 25.522169910746822, "Hoyt" },
                    { "Koda", 83.805043784932948, "Easton" },
                    { "Mack", 45.128274872978253, "Easton" },
                    { "Nash", 25.271686831546461, "Hoyt" },
                    { "Neo", 47.127804667112322, "Bear" },
                    { "Nile", 25.199545992582856, "Easton" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "45004851850", 47, "Ginger", new DateTime(1965, 4, 19, 18, 38, 48, 807, DateTimeKind.Local).AddTicks(12), "Prokop, Agrypina", "Łuczak" },
                    { "16709791766", 45, "Bo", new DateTime(1984, 1, 3, 20, 56, 27, 290, DateTimeKind.Local).AddTicks(6732), "Eustracjusz, Kamila", "Leśniewski" },
                    { "44676240041", 49, "Kip", new DateTime(1958, 5, 22, 5, 48, 34, 386, DateTimeKind.Local).AddTicks(1640), "Karolina, Lea", "Przybył" },
                    { "50540141027", 52, "Jinx", new DateTime(1999, 7, 17, 8, 10, 30, 98, DateTimeKind.Local).AddTicks(9858), "Diana, Nikodem", "Maślanka" },
                    { "50910221135", 48, "Koda", new DateTime(1988, 10, 27, 23, 1, 48, 545, DateTimeKind.Local).AddTicks(3119), "Hubert, Larysa", "Marchewka" },
                    { "66299831239", 51, "Bam", new DateTime(1961, 9, 25, 3, 24, 31, 957, DateTimeKind.Local).AddTicks(6003), "Justyna, Tomasz", "Pająk" },
                    { "74198294289", 53, "Neo", new DateTime(2002, 12, 7, 7, 44, 6, 123, DateTimeKind.Local).AddTicks(9048), "Walenty, Jakubina", "Żmuda" },
                    { "81329863211", 54, "Nile", new DateTime(1991, 1, 15, 9, 58, 52, 668, DateTimeKind.Local).AddTicks(5389), "Onufry, Kleopatra", "Milewski" },
                    { "84096874650", 46, "Mack", new DateTime(2003, 1, 3, 20, 15, 26, 635, DateTimeKind.Local).AddTicks(263), "Arystarch, Luiza", "Janusz" },
                    { "98245229845", 50, "Nash", new DateTime(1971, 6, 16, 18, 5, 18, 666, DateTimeKind.Local).AddTicks(5098), "Hieronim, Ida", "Wnuk" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[,]
                {
                    { "50910221135", null, "Cadet" },
                    { "66299831239", null, "Junior" },
                    { "74198294289", null, "Senior" },
                    { "81329863211", null, "Senior" },
                    { "98245229845", null, "Junior" }
                });
        }
    }
}
