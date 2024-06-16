using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArcheryMAS.Migrations
{
    /// <inheritdoc />
    public partial class CoachesFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "25714446282");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "33299095329");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "75551600592");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "83259993854");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "92239556628");

            migrationBuilder.DeleteData(
                table: "Coach",
                keyColumn: "Person_PESEL",
                keyValue: "06232654273");

            migrationBuilder.DeleteData(
                table: "Coach",
                keyColumn: "Person_PESEL",
                keyValue: "12571672084");

            migrationBuilder.DeleteData(
                table: "Coach",
                keyColumn: "Person_PESEL",
                keyValue: "47452415174");

            migrationBuilder.DeleteData(
                table: "Coach",
                keyColumn: "Person_PESEL",
                keyValue: "50807791874");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "36769569813");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "06232654273");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "12571672084");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "25714446282");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "33299095329");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "47452415174");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "50807791874");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "75551600592");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "83259993854");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "92239556628");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Barron");

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
                keyValue: "Kona");

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
                keyValue: "Moss");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Nash");

            migrationBuilder.AddColumn<int>(
                name: "MinSalary",
                table: "Coach",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "ArrowLength", "ArrowQuantity" },
                values: new object[] { 34.53629683160981, 8 });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 23.806805523961678, 11, "New" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 20.209184544416861, 12, "New" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "ArrowLength", "State" },
                values: new object[] { 24.732469978127419, "New" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 28.644330937620737, 8, "Broken" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 27.948336062230901, 8, "Used" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "ArrowLength", "ArrowQuantity" },
                values: new object[] { 33.71357524788629, 6 });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "ArrowLength", "State" },
                values: new object[] { 31.46373826922812, "Broken" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 21.88019982044564, 9, "Broken" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 39.901794111854144, 7, "Used" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Beazle",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 83.874604578071256, "Polaris" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Nile",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 66.085100599444303, "Polaris" });

            migrationBuilder.InsertData(
                table: "Bow",
                columns: new[] { "NickName", "Force", "Manufacturer" },
                values: new object[,]
                {
                    { "Bake", 87.909506492872524, "Bear" },
                    { "Huss", 43.026440329525371, "Polaris" },
                    { "Kai", 64.883343481450964, "PSE" },
                    { "Knox", 16.703210418913581, "Polaris" },
                    { "Kylo", 12.771510177899565, "Hoyt" },
                    { "Mars", 24.079378548180991, "Hoyt" },
                    { "Moby", 64.648084459328203, "Bear" },
                    { "Neo", 26.130856683460205, "PSE" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "13059870195", 58, "Nile", new DateTime(1959, 3, 24, 7, 14, 33, 780, DateTimeKind.Local).AddTicks(6869), "Eliza, Serafina", "Wojtczak" },
                    { "40509350330", 54, "Beazle", new DateTime(1980, 8, 1, 13, 53, 36, 905, DateTimeKind.Local).AddTicks(4133), "Eugenia, Leonid", "Gajda" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[,]
                {
                    { "13059870195", null, "Cadet" },
                    { "40509350330", null, "Senior" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "01703123432", 56, "Bake", new DateTime(1999, 12, 11, 2, 4, 27, 43, DateTimeKind.Local).AddTicks(7348), "Estera, Nadzieja", "Winiarski" },
                    { "62521228462", 53, "Knox", new DateTime(1964, 7, 7, 6, 13, 41, 33, DateTimeKind.Local).AddTicks(9997), "Nazary, Fryderyk", "Przybyła" },
                    { "63067105383", 52, "Mars", new DateTime(1977, 5, 15, 23, 42, 45, 568, DateTimeKind.Local).AddTicks(5539), "Franciszka, Adrian", "Kwiatkowski" },
                    { "65885693917", 49, "Huss", new DateTime(2002, 4, 18, 22, 21, 39, 546, DateTimeKind.Local).AddTicks(2543), "Serafina, Sergiusz", "Golec" },
                    { "79506123851", 55, "Moby", new DateTime(1981, 8, 3, 0, 18, 53, 662, DateTimeKind.Local).AddTicks(7736), "Ilona, Fryderyk", "Szymczak" },
                    { "81749421112", 51, "Kai", new DateTime(1986, 5, 12, 20, 0, 5, 743, DateTimeKind.Local).AddTicks(2646), "Ansgary, Erast", "Guzik" },
                    { "84604994968", 50, "Neo", new DateTime(1972, 8, 27, 11, 30, 43, 598, DateTimeKind.Local).AddTicks(1925), "Sergiusz, Apollinary", "Żebrowski" },
                    { "99420785581", 57, "Kylo", new DateTime(1997, 9, 17, 2, 35, 9, 25, DateTimeKind.Local).AddTicks(9455), "Eliza, Hieronim", "Palacz" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[,]
                {
                    { "62521228462", null, "Senior" },
                    { "81749421112", null, "Senior" },
                    { "84604994968", null, "Senior" }
                });

            migrationBuilder.InsertData(
                table: "Coach",
                columns: new[] { "Person_PESEL", "Bonus", "MinSalary" },
                values: new object[,]
                {
                    { "01703123432", 343, 5000 },
                    { "63067105383", 968, 5000 },
                    { "79506123851", 626, 5000 },
                    { "99420785581", 867, 5000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "13059870195");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "40509350330");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "62521228462");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "81749421112");

            migrationBuilder.DeleteData(
                table: "Archer",
                keyColumn: "Person_PESEL",
                keyValue: "84604994968");

            migrationBuilder.DeleteData(
                table: "Coach",
                keyColumn: "Person_PESEL",
                keyValue: "01703123432");

            migrationBuilder.DeleteData(
                table: "Coach",
                keyColumn: "Person_PESEL",
                keyValue: "63067105383");

            migrationBuilder.DeleteData(
                table: "Coach",
                keyColumn: "Person_PESEL",
                keyValue: "79506123851");

            migrationBuilder.DeleteData(
                table: "Coach",
                keyColumn: "Person_PESEL",
                keyValue: "99420785581");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "65885693917");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Huss");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "01703123432");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "13059870195");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "40509350330");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "62521228462");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "63067105383");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "79506123851");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "81749421112");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "84604994968");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PESEL",
                keyValue: "99420785581");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Bake");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kai");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Knox");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Kylo");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Mars");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Moby");

            migrationBuilder.DeleteData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Neo");

            migrationBuilder.DropColumn(
                name: "MinSalary",
                table: "Coach");

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "ArrowLength", "ArrowQuantity" },
                values: new object[] { 33.021185873064731, 10 });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 35.165490418570784, 12, "Used" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 35.934790178690932, 10, "Used" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "ArrowLength", "State" },
                values: new object[] { 36.59697364256219, "Broken" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 24.592908558709041, 10, "Used" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 25.903966240839399, 9, "New" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "ArrowLength", "ArrowQuantity" },
                values: new object[] { 34.514716228899729, 10 });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "ArrowLength", "State" },
                values: new object[] { 23.987528284170551, "New" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 20.979562223032321, 11, "Used" });

            migrationBuilder.UpdateData(
                table: "ArrowSet",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "ArrowLength", "ArrowQuantity", "State" },
                values: new object[] { 21.566603263570386, 11, "Broken" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Beazle",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 42.942405383356096, "Easton" });

            migrationBuilder.UpdateData(
                table: "Bow",
                keyColumn: "NickName",
                keyValue: "Nile",
                columns: new[] { "Force", "Manufacturer" },
                values: new object[] { 16.861716436235042, "PSE" });

            migrationBuilder.InsertData(
                table: "Bow",
                columns: new[] { "NickName", "Force", "Manufacturer" },
                values: new object[,]
                {
                    { "Barron", 10.163273817721816, "Mathews" },
                    { "Jinx", 56.953474860108706, "Mathews" },
                    { "Kane", 55.240000131229543, "Polaris" },
                    { "Kona", 76.343923350390057, "Polaris" },
                    { "Kota", 75.684253749842995, "Hoyt" },
                    { "Kruz", 41.797378348746193, "Easton" },
                    { "Moss", 27.47817855881382, "Polaris" },
                    { "Nash", 16.978901562965515, "Hoyt" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "36769569813", 58, "Beazle", new DateTime(1967, 7, 14, 14, 3, 55, 816, DateTimeKind.Local).AddTicks(5352), "Kalistrat, Aida", "Olejniczak" },
                    { "75551600592", 55, "Nile", new DateTime(1990, 6, 27, 4, 51, 23, 499, DateTimeKind.Local).AddTicks(3242), "Arystarch, Bazyli", "Cybulski" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[] { "75551600592", null, "Junior" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PESEL", "ArrowSet_ID", "Bow_NickName", "DateOfBirth", "Names", "Surname" },
                values: new object[,]
                {
                    { "06232654273", 50, "Kruz", new DateTime(1994, 8, 18, 22, 51, 20, 664, DateTimeKind.Local).AddTicks(4), "Beniamin, Arkady", "Czerniak" },
                    { "12571672084", 52, "Barron", new DateTime(1974, 3, 2, 11, 9, 4, 61, DateTimeKind.Local).AddTicks(9605), "Reginald, Brajan", "Żurawski" },
                    { "25714446282", 54, "Moss", new DateTime(2003, 4, 9, 15, 11, 24, 719, DateTimeKind.Local).AddTicks(4669), "Penelopa, Gerald", "Zaremba" },
                    { "33299095329", 56, "Kane", new DateTime(1973, 1, 11, 11, 36, 20, 994, DateTimeKind.Local).AddTicks(2318), "Izaak, Jakubina", "Kurowski" },
                    { "47452415174", 57, "Jinx", new DateTime(1954, 7, 13, 5, 38, 32, 260, DateTimeKind.Local).AddTicks(8406), "Żaneta, Oliwier", "Motyka" },
                    { "50807791874", 53, "Kota", new DateTime(1984, 2, 7, 17, 40, 19, 61, DateTimeKind.Local).AddTicks(3142), "Paula, Michalina", "Gawroński" },
                    { "83259993854", 51, "Kona", new DateTime(1964, 3, 17, 5, 1, 36, 955, DateTimeKind.Local).AddTicks(599), "Aurora, Marceli", "Kostecki" },
                    { "92239556628", 49, "Nash", new DateTime(1971, 11, 12, 13, 39, 39, 631, DateTimeKind.Local).AddTicks(199), "Tamara, Łazarz", "Gałązka" }
                });

            migrationBuilder.InsertData(
                table: "Archer",
                columns: new[] { "Person_PESEL", "LeaveReason", "Rank" },
                values: new object[,]
                {
                    { "25714446282", null, "Cadet" },
                    { "33299095329", null, "Junior" },
                    { "83259993854", null, "Cadet" },
                    { "92239556628", null, "Senior" }
                });

            migrationBuilder.InsertData(
                table: "Coach",
                columns: new[] { "Person_PESEL", "Bonus" },
                values: new object[,]
                {
                    { "06232654273", 960 },
                    { "12571672084", 200 },
                    { "47452415174", 381 },
                    { "50807791874", 809 }
                });
        }
    }
}
