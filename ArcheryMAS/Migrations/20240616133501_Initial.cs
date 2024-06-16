using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArcheryMAS.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArrowSet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false),
                    MinQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                    ArrowQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    ArrowLength = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArrowSet", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bow",
                columns: table => new
                {
                    NickName = table.Column<string>(type: "varchar(30)", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Force = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bow", x => x.NickName);
                });

            migrationBuilder.CreateTable(
                name: "Competition",
                columns: table => new
                {
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Place = table.Column<string>(type: "TEXT", nullable: false),
                    DateAndTimeStart = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateAndTimeEnd = table.Column<DateTime>(type: "datetime", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    CancelingReason = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competition", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "ArrowSetIndoor",
                columns: table => new
                {
                    ArrowSet_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxDiameter = table.Column<double>(type: "double", nullable: false),
                    Diameter = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArrowSetIndoor", x => x.ArrowSet_ID);
                    table.ForeignKey(
                        name: "FK_ArrowSetIndoor_ArrowSet_ArrowSet_ID",
                        column: x => x.ArrowSet_ID,
                        principalTable: "ArrowSet",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ArrowSetOutdoor",
                columns: table => new
                {
                    ArrowSet_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Material = table.Column<string>(type: "TEXT", nullable: false),
                    MaxDiameter = table.Column<double>(type: "double", nullable: false),
                    Diameter = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArrowSetOutdoor", x => x.ArrowSet_ID);
                    table.ForeignKey(
                        name: "FK_ArrowSetOutdoor_ArrowSet_ArrowSet_ID",
                        column: x => x.ArrowSet_ID,
                        principalTable: "ArrowSet",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ArrowSetTraining",
                columns: table => new
                {
                    ArrowSet_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Material = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArrowSetTraining", x => x.ArrowSet_ID);
                    table.ForeignKey(
                        name: "FK_ArrowSetTraining_ArrowSet_ArrowSet_ID",
                        column: x => x.ArrowSet_ID,
                        principalTable: "ArrowSet",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CompoundBow",
                columns: table => new
                {
                    Bow_NickName = table.Column<string>(type: "varchar(30)", nullable: false),
                    OpticalZoom = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompoundBow", x => x.Bow_NickName);
                    table.ForeignKey(
                        name: "FK_CompoundBow_Bow_Bow_NickName",
                        column: x => x.Bow_NickName,
                        principalTable: "Bow",
                        principalColumn: "NickName");
                });

            migrationBuilder.CreateTable(
                name: "OlympicBow",
                columns: table => new
                {
                    Bow_NickName = table.Column<string>(type: "varchar(30)", nullable: false),
                    NummberOfStabilizers = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxDaysWithoutService = table.Column<int>(type: "INTEGER", nullable: false),
                    DaysWithoutService = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlympicBow", x => x.Bow_NickName);
                    table.ForeignKey(
                        name: "FK_OlympicBow_Bow_Bow_NickName",
                        column: x => x.Bow_NickName,
                        principalTable: "Bow",
                        principalColumn: "NickName");
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PESEL = table.Column<string>(type: "TEXT", nullable: false),
                    Bow_NickName = table.Column<string>(type: "varchar(30)", nullable: false),
                    ArrowSet_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Names = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PESEL);
                    table.ForeignKey(
                        name: "FK_Person_ArrowSet_ArrowSet_ID",
                        column: x => x.ArrowSet_ID,
                        principalTable: "ArrowSet",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Person_Bow_Bow_NickName",
                        column: x => x.Bow_NickName,
                        principalTable: "Bow",
                        principalColumn: "NickName");
                });

            migrationBuilder.CreateTable(
                name: "UniversalSet",
                columns: table => new
                {
                    ArrowSetIndoor_ArrowSet_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    ArrowSetOutdoor_ArrowSet_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    ArrowSetTraining_ArrowSet_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "double", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversalSet", x => new { x.ArrowSetIndoor_ArrowSet_ID, x.ArrowSetOutdoor_ArrowSet_ID, x.ArrowSetTraining_ArrowSet_ID });
                    table.ForeignKey(
                        name: "FK_UniversalSet_ArrowSetIndoor_ArrowSetIndoor_ArrowSet_ID",
                        column: x => x.ArrowSetIndoor_ArrowSet_ID,
                        principalTable: "ArrowSetIndoor",
                        principalColumn: "ArrowSet_ID");
                    table.ForeignKey(
                        name: "FK_UniversalSet_ArrowSetOutdoor_ArrowSetOutdoor_ArrowSet_ID",
                        column: x => x.ArrowSetOutdoor_ArrowSet_ID,
                        principalTable: "ArrowSetOutdoor",
                        principalColumn: "ArrowSet_ID");
                    table.ForeignKey(
                        name: "FK_UniversalSet_ArrowSetTraining_ArrowSetTraining_ArrowSet_ID",
                        column: x => x.ArrowSetTraining_ArrowSet_ID,
                        principalTable: "ArrowSetTraining",
                        principalColumn: "ArrowSet_ID");
                });

            migrationBuilder.CreateTable(
                name: "Archer",
                columns: table => new
                {
                    Person_PESEL = table.Column<string>(type: "TEXT", nullable: false),
                    Rank = table.Column<string>(type: "TEXT", nullable: false),
                    LeaveReason = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archer", x => x.Person_PESEL);
                    table.ForeignKey(
                        name: "FK_Archer_Person_Person_PESEL",
                        column: x => x.Person_PESEL,
                        principalTable: "Person",
                        principalColumn: "PESEL");
                });

            migrationBuilder.CreateTable(
                name: "Coach",
                columns: table => new
                {
                    Person_PESEL = table.Column<string>(type: "TEXT", nullable: false),
                    MinSalary = table.Column<int>(type: "INTEGER", nullable: false),
                    Bonus = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coach", x => x.Person_PESEL);
                    table.ForeignKey(
                        name: "FK_Coach_Person_Person_PESEL",
                        column: x => x.Person_PESEL,
                        principalTable: "Person",
                        principalColumn: "PESEL");
                });

            migrationBuilder.CreateTable(
                name: "President",
                columns: table => new
                {
                    Person_PESEL = table.Column<string>(type: "TEXT", nullable: false),
                    DegreeOfEducation = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_President", x => x.Person_PESEL);
                    table.ForeignKey(
                        name: "FK_President_Person_Person_PESEL",
                        column: x => x.Person_PESEL,
                        principalTable: "Person",
                        principalColumn: "PESEL");
                });

            migrationBuilder.CreateTable(
                name: "ArcherInCompetition",
                columns: table => new
                {
                    Archer_Person_PESEL = table.Column<string>(type: "TEXT", nullable: false),
                    Competition_Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    PlaceInCompetition = table.Column<int>(type: "INTEGER", nullable: false),
                    Score = table.Column<int>(type: "INTEGER", nullable: false),
                    Prize = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArcherInCompetition", x => new { x.Archer_Person_PESEL, x.Competition_Name });
                    table.ForeignKey(
                        name: "FK_ArcherInCompetition_Archer_Archer_Person_PESEL",
                        column: x => x.Archer_Person_PESEL,
                        principalTable: "Archer",
                        principalColumn: "Person_PESEL");
                    table.ForeignKey(
                        name: "FK_ArcherInCompetition_Competition_Competition_Name",
                        column: x => x.Competition_Name,
                        principalTable: "Competition",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    Archer_Person_PESEL = table.Column<string>(type: "TEXT", nullable: false),
                    Coach_Person_PESEL = table.Column<string>(type: "TEXT", nullable: false),
                    DateAndTimeTrainingStart = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateAndTimeTrainingEnd = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => new { x.Archer_Person_PESEL, x.Coach_Person_PESEL });
                    table.ForeignKey(
                        name: "FK_Training_Archer_Archer_Person_PESEL",
                        column: x => x.Archer_Person_PESEL,
                        principalTable: "Archer",
                        principalColumn: "Person_PESEL");
                    table.ForeignKey(
                        name: "FK_Training_Coach_Coach_Person_PESEL",
                        column: x => x.Coach_Person_PESEL,
                        principalTable: "Coach",
                        principalColumn: "Person_PESEL");
                });

            migrationBuilder.InsertData(
                table: "Bow",
                columns: new[] { "NickName", "Force", "Manufacturer" },
                values: new object[,]
                {
                    { "Ginger", 83.667728707670094, "PSE" },
                    { "Jax", 79.660188688116747, "PSE" },
                    { "JB", 60.581451359478272, "PSE" },
                    { "Kai", 27.061067505680814, "Bear" },
                    { "Kip", 66.725081222875303, "Mathews" },
                    { "Koda", 19.793066423654764, "Bear" },
                    { "Kona", 17.79957357514877, "PSE" },
                    { "Mako", 21.876868033532027, "Easton" },
                    { "Niko", 51.811446980085286, "Mathews" },
                    { "Nile", 49.881938341900671, "PSE" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArcherInCompetition_Competition_Name",
                table: "ArcherInCompetition",
                column: "Competition_Name");

            migrationBuilder.CreateIndex(
                name: "IX_Person_ArrowSet_ID",
                table: "Person",
                column: "ArrowSet_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Bow_NickName",
                table: "Person",
                column: "Bow_NickName");

            migrationBuilder.CreateIndex(
                name: "IX_Training_Coach_Person_PESEL",
                table: "Training",
                column: "Coach_Person_PESEL");

            migrationBuilder.CreateIndex(
                name: "IX_UniversalSet_ArrowSetOutdoor_ArrowSet_ID",
                table: "UniversalSet",
                column: "ArrowSetOutdoor_ArrowSet_ID");

            migrationBuilder.CreateIndex(
                name: "IX_UniversalSet_ArrowSetTraining_ArrowSet_ID",
                table: "UniversalSet",
                column: "ArrowSetTraining_ArrowSet_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArcherInCompetition");

            migrationBuilder.DropTable(
                name: "CompoundBow");

            migrationBuilder.DropTable(
                name: "OlympicBow");

            migrationBuilder.DropTable(
                name: "President");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "UniversalSet");

            migrationBuilder.DropTable(
                name: "Competition");

            migrationBuilder.DropTable(
                name: "Archer");

            migrationBuilder.DropTable(
                name: "Coach");

            migrationBuilder.DropTable(
                name: "ArrowSetIndoor");

            migrationBuilder.DropTable(
                name: "ArrowSetOutdoor");

            migrationBuilder.DropTable(
                name: "ArrowSetTraining");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "ArrowSet");

            migrationBuilder.DropTable(
                name: "Bow");
        }
    }
}
