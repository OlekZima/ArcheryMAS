﻿// <auto-generated />
using System;
using ArcheryMAS.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArcheryMAS.Migrations
{
    [DbContext(typeof(ArcheryDbContext))]
    [Migration("20240616135639_CoachesFix")]
    partial class CoachesFix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("ArcheryMAS.Migrations.Archer", b =>
                {
                    b.Property<string>("Person_PESEL")
                        .HasColumnType("TEXT");

                    b.Property<string>("LeaveReason")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rank")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Person_PESEL");

                    b.ToTable("Archer");

                    b.HasData(
                        new
                        {
                            Person_PESEL = "81749421112",
                            Rank = "Senior"
                        },
                        new
                        {
                            Person_PESEL = "84604994968",
                            Rank = "Senior"
                        },
                        new
                        {
                            Person_PESEL = "62521228462",
                            Rank = "Senior"
                        },
                        new
                        {
                            Person_PESEL = "40509350330",
                            Rank = "Senior"
                        },
                        new
                        {
                            Person_PESEL = "13059870195",
                            Rank = "Cadet"
                        });
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.ArcherInCompetition", b =>
                {
                    b.Property<string>("Archer_Person_PESEL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Competition_Name")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("PlaceInCompetition")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Prize")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Score")
                        .HasColumnType("INTEGER");

                    b.HasKey("Archer_Person_PESEL", "Competition_Name");

                    b.HasIndex("Competition_Name");

                    b.ToTable("ArcherInCompetition");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.ArrowSet", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("INTEGER");

                    b.Property<double>("ArrowLength")
                        .HasColumnType("double");

                    b.Property<int>("ArrowQuantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinQuantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("ArrowSet");

                    b.HasData(
                        new
                        {
                            ID = 49,
                            ArrowLength = 34.53629683160981,
                            ArrowQuantity = 8,
                            MinQuantity = 0,
                            State = "Broken"
                        },
                        new
                        {
                            ID = 50,
                            ArrowLength = 23.806805523961678,
                            ArrowQuantity = 11,
                            MinQuantity = 0,
                            State = "New"
                        },
                        new
                        {
                            ID = 51,
                            ArrowLength = 20.209184544416861,
                            ArrowQuantity = 12,
                            MinQuantity = 0,
                            State = "New"
                        },
                        new
                        {
                            ID = 52,
                            ArrowLength = 24.732469978127419,
                            ArrowQuantity = 12,
                            MinQuantity = 0,
                            State = "New"
                        },
                        new
                        {
                            ID = 53,
                            ArrowLength = 28.644330937620737,
                            ArrowQuantity = 8,
                            MinQuantity = 0,
                            State = "Broken"
                        },
                        new
                        {
                            ID = 54,
                            ArrowLength = 27.948336062230901,
                            ArrowQuantity = 8,
                            MinQuantity = 0,
                            State = "Used"
                        },
                        new
                        {
                            ID = 55,
                            ArrowLength = 33.71357524788629,
                            ArrowQuantity = 6,
                            MinQuantity = 0,
                            State = "Used"
                        },
                        new
                        {
                            ID = 56,
                            ArrowLength = 31.46373826922812,
                            ArrowQuantity = 12,
                            MinQuantity = 0,
                            State = "Broken"
                        },
                        new
                        {
                            ID = 57,
                            ArrowLength = 21.88019982044564,
                            ArrowQuantity = 9,
                            MinQuantity = 0,
                            State = "Broken"
                        },
                        new
                        {
                            ID = 58,
                            ArrowLength = 39.901794111854144,
                            ArrowQuantity = 7,
                            MinQuantity = 0,
                            State = "Used"
                        });
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.ArrowSetIndoor", b =>
                {
                    b.Property<int>("ArrowSet_ID")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Diameter")
                        .HasColumnType("double");

                    b.Property<double>("MaxDiameter")
                        .HasColumnType("double");

                    b.HasKey("ArrowSet_ID");

                    b.ToTable("ArrowSetIndoor");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.ArrowSetOutdoor", b =>
                {
                    b.Property<int>("ArrowSet_ID")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Diameter")
                        .HasColumnType("double");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("MaxDiameter")
                        .HasColumnType("double");

                    b.HasKey("ArrowSet_ID");

                    b.ToTable("ArrowSetOutdoor");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.ArrowSetTraining", b =>
                {
                    b.Property<int>("ArrowSet_ID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ArrowSet_ID");

                    b.ToTable("ArrowSetTraining");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.Bow", b =>
                {
                    b.Property<string>("NickName")
                        .HasColumnType("varchar(30)");

                    b.Property<double>("Force")
                        .HasColumnType("double");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("NickName");

                    b.ToTable("Bow");

                    b.HasData(
                        new
                        {
                            NickName = "Beazle",
                            Force = 83.874604578071256,
                            Manufacturer = "Polaris"
                        },
                        new
                        {
                            NickName = "Moby",
                            Force = 64.648084459328203,
                            Manufacturer = "Bear"
                        },
                        new
                        {
                            NickName = "Neo",
                            Force = 26.130856683460205,
                            Manufacturer = "PSE"
                        },
                        new
                        {
                            NickName = "Kylo",
                            Force = 12.771510177899565,
                            Manufacturer = "Hoyt"
                        },
                        new
                        {
                            NickName = "Knox",
                            Force = 16.703210418913581,
                            Manufacturer = "Polaris"
                        },
                        new
                        {
                            NickName = "Huss",
                            Force = 43.026440329525371,
                            Manufacturer = "Polaris"
                        },
                        new
                        {
                            NickName = "Nile",
                            Force = 66.085100599444303,
                            Manufacturer = "Polaris"
                        },
                        new
                        {
                            NickName = "Mars",
                            Force = 24.079378548180991,
                            Manufacturer = "Hoyt"
                        },
                        new
                        {
                            NickName = "Kai",
                            Force = 64.883343481450964,
                            Manufacturer = "PSE"
                        },
                        new
                        {
                            NickName = "Bake",
                            Force = 87.909506492872524,
                            Manufacturer = "Bear"
                        });
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.Coach", b =>
                {
                    b.Property<string>("Person_PESEL")
                        .HasColumnType("TEXT");

                    b.Property<int>("Bonus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinSalary")
                        .HasColumnType("INTEGER");

                    b.HasKey("Person_PESEL");

                    b.ToTable("Coach");

                    b.HasData(
                        new
                        {
                            Person_PESEL = "79506123851",
                            Bonus = 626,
                            MinSalary = 5000
                        },
                        new
                        {
                            Person_PESEL = "99420785581",
                            Bonus = 867,
                            MinSalary = 5000
                        },
                        new
                        {
                            Person_PESEL = "63067105383",
                            Bonus = 968,
                            MinSalary = 5000
                        },
                        new
                        {
                            Person_PESEL = "01703123432",
                            Bonus = 343,
                            MinSalary = 5000
                        });
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.Competition", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CancelingReason")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateAndTimeEnd")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateAndTimeStart")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("Competition");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.CompoundBow", b =>
                {
                    b.Property<string>("Bow_NickName")
                        .HasColumnType("varchar(30)");

                    b.Property<double>("OpticalZoom")
                        .HasColumnType("double");

                    b.HasKey("Bow_NickName");

                    b.ToTable("CompoundBow");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.OlympicBow", b =>
                {
                    b.Property<string>("Bow_NickName")
                        .HasColumnType("varchar(30)");

                    b.Property<int>("DaysWithoutService")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxDaysWithoutService")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NummberOfStabilizers")
                        .HasColumnType("INTEGER");

                    b.HasKey("Bow_NickName");

                    b.ToTable("OlympicBow");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.Person", b =>
                {
                    b.Property<string>("PESEL")
                        .HasColumnType("TEXT");

                    b.Property<int>("ArrowSet_ID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bow_NickName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Names")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PESEL");

                    b.HasIndex("ArrowSet_ID");

                    b.HasIndex("Bow_NickName");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            PESEL = "40509350330",
                            ArrowSet_ID = 54,
                            Bow_NickName = "Beazle",
                            DateOfBirth = new DateTime(1980, 8, 1, 13, 53, 36, 905, DateTimeKind.Local).AddTicks(4133),
                            Names = "Eugenia, Leonid",
                            Surname = "Gajda"
                        },
                        new
                        {
                            PESEL = "84604994968",
                            ArrowSet_ID = 50,
                            Bow_NickName = "Neo",
                            DateOfBirth = new DateTime(1972, 8, 27, 11, 30, 43, 598, DateTimeKind.Local).AddTicks(1925),
                            Names = "Sergiusz, Apollinary",
                            Surname = "Żebrowski"
                        },
                        new
                        {
                            PESEL = "99420785581",
                            ArrowSet_ID = 57,
                            Bow_NickName = "Kylo",
                            DateOfBirth = new DateTime(1997, 9, 17, 2, 35, 9, 25, DateTimeKind.Local).AddTicks(9455),
                            Names = "Eliza, Hieronim",
                            Surname = "Palacz"
                        },
                        new
                        {
                            PESEL = "01703123432",
                            ArrowSet_ID = 56,
                            Bow_NickName = "Bake",
                            DateOfBirth = new DateTime(1999, 12, 11, 2, 4, 27, 43, DateTimeKind.Local).AddTicks(7348),
                            Names = "Estera, Nadzieja",
                            Surname = "Winiarski"
                        },
                        new
                        {
                            PESEL = "13059870195",
                            ArrowSet_ID = 58,
                            Bow_NickName = "Nile",
                            DateOfBirth = new DateTime(1959, 3, 24, 7, 14, 33, 780, DateTimeKind.Local).AddTicks(6869),
                            Names = "Eliza, Serafina",
                            Surname = "Wojtczak"
                        },
                        new
                        {
                            PESEL = "79506123851",
                            ArrowSet_ID = 55,
                            Bow_NickName = "Moby",
                            DateOfBirth = new DateTime(1981, 8, 3, 0, 18, 53, 662, DateTimeKind.Local).AddTicks(7736),
                            Names = "Ilona, Fryderyk",
                            Surname = "Szymczak"
                        },
                        new
                        {
                            PESEL = "65885693917",
                            ArrowSet_ID = 49,
                            Bow_NickName = "Huss",
                            DateOfBirth = new DateTime(2002, 4, 18, 22, 21, 39, 546, DateTimeKind.Local).AddTicks(2543),
                            Names = "Serafina, Sergiusz",
                            Surname = "Golec"
                        },
                        new
                        {
                            PESEL = "62521228462",
                            ArrowSet_ID = 53,
                            Bow_NickName = "Knox",
                            DateOfBirth = new DateTime(1964, 7, 7, 6, 13, 41, 33, DateTimeKind.Local).AddTicks(9997),
                            Names = "Nazary, Fryderyk",
                            Surname = "Przybyła"
                        },
                        new
                        {
                            PESEL = "81749421112",
                            ArrowSet_ID = 51,
                            Bow_NickName = "Kai",
                            DateOfBirth = new DateTime(1986, 5, 12, 20, 0, 5, 743, DateTimeKind.Local).AddTicks(2646),
                            Names = "Ansgary, Erast",
                            Surname = "Guzik"
                        },
                        new
                        {
                            PESEL = "63067105383",
                            ArrowSet_ID = 52,
                            Bow_NickName = "Mars",
                            DateOfBirth = new DateTime(1977, 5, 15, 23, 42, 45, 568, DateTimeKind.Local).AddTicks(5539),
                            Names = "Franciszka, Adrian",
                            Surname = "Kwiatkowski"
                        });
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.President", b =>
                {
                    b.Property<string>("Person_PESEL")
                        .HasColumnType("TEXT");

                    b.Property<string>("DegreeOfEducation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Person_PESEL");

                    b.ToTable("President");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.Training", b =>
                {
                    b.Property<string>("Archer_Person_PESEL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Coach_Person_PESEL")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateAndTimeTrainingEnd")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateAndTimeTrainingStart")
                        .HasColumnType("datetime");

                    b.HasKey("Archer_Person_PESEL", "Coach_Person_PESEL");

                    b.HasIndex("Coach_Person_PESEL");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.UniversalSet", b =>
                {
                    b.Property<int>("ArrowSetIndoor_ArrowSet_ID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArrowSetOutdoor_ArrowSet_ID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArrowSetTraining_ArrowSet_ID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("ArrowSetIndoor_ArrowSet_ID", "ArrowSetOutdoor_ArrowSet_ID", "ArrowSetTraining_ArrowSet_ID");

                    b.HasIndex("ArrowSetOutdoor_ArrowSet_ID");

                    b.HasIndex("ArrowSetTraining_ArrowSet_ID");

                    b.ToTable("UniversalSet");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.Archer", b =>
                {
                    b.HasOne("ArcheryMAS.Migrations.Person", "Person_PESELNavigation")
                        .WithOne("Archer")
                        .HasForeignKey("ArcheryMAS.Migrations.Archer", "Person_PESEL")
                        .IsRequired();

                    b.Navigation("Person_PESELNavigation");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.ArcherInCompetition", b =>
                {
                    b.HasOne("ArcheryMAS.Migrations.Archer", "Archer_Person_PESELNavigation")
                        .WithMany("ArcherInCompetitions")
                        .HasForeignKey("Archer_Person_PESEL")
                        .IsRequired();

                    b.HasOne("ArcheryMAS.Migrations.Competition", "Competition_NameNavigation")
                        .WithMany("ArcherInCompetitions")
                        .HasForeignKey("Competition_Name")
                        .IsRequired();

                    b.Navigation("Archer_Person_PESELNavigation");

                    b.Navigation("Competition_NameNavigation");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.ArrowSetIndoor", b =>
                {
                    b.HasOne("ArcheryMAS.Migrations.ArrowSet", "ArrowSet")
                        .WithOne("ArrowSetIndoor")
                        .HasForeignKey("ArcheryMAS.Migrations.ArrowSetIndoor", "ArrowSet_ID")
                        .IsRequired();

                    b.Navigation("ArrowSet");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.ArrowSetOutdoor", b =>
                {
                    b.HasOne("ArcheryMAS.Migrations.ArrowSet", "ArrowSet")
                        .WithOne("ArrowSetOutdoor")
                        .HasForeignKey("ArcheryMAS.Migrations.ArrowSetOutdoor", "ArrowSet_ID")
                        .IsRequired();

                    b.Navigation("ArrowSet");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.ArrowSetTraining", b =>
                {
                    b.HasOne("ArcheryMAS.Migrations.ArrowSet", "ArrowSet")
                        .WithOne("ArrowSetTraining")
                        .HasForeignKey("ArcheryMAS.Migrations.ArrowSetTraining", "ArrowSet_ID")
                        .IsRequired();

                    b.Navigation("ArrowSet");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.Coach", b =>
                {
                    b.HasOne("ArcheryMAS.Migrations.Person", "Person_PESELNavigation")
                        .WithOne("Coach")
                        .HasForeignKey("ArcheryMAS.Migrations.Coach", "Person_PESEL")
                        .IsRequired();

                    b.Navigation("Person_PESELNavigation");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.CompoundBow", b =>
                {
                    b.HasOne("ArcheryMAS.Migrations.Bow", "Bow_NickNameNavigation")
                        .WithOne("CompoundBow")
                        .HasForeignKey("ArcheryMAS.Migrations.CompoundBow", "Bow_NickName")
                        .IsRequired();

                    b.Navigation("Bow_NickNameNavigation");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.OlympicBow", b =>
                {
                    b.HasOne("ArcheryMAS.Migrations.Bow", "Bow_NickNameNavigation")
                        .WithOne("OlympicBow")
                        .HasForeignKey("ArcheryMAS.Migrations.OlympicBow", "Bow_NickName")
                        .IsRequired();

                    b.Navigation("Bow_NickNameNavigation");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.Person", b =>
                {
                    b.HasOne("ArcheryMAS.Migrations.ArrowSet", "ArrowSet")
                        .WithMany("People")
                        .HasForeignKey("ArrowSet_ID")
                        .IsRequired();

                    b.HasOne("ArcheryMAS.Migrations.Bow", "Bow_NickNameNavigation")
                        .WithMany("People")
                        .HasForeignKey("Bow_NickName")
                        .IsRequired();

                    b.Navigation("ArrowSet");

                    b.Navigation("Bow_NickNameNavigation");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.President", b =>
                {
                    b.HasOne("ArcheryMAS.Migrations.Person", "Person_PESELNavigation")
                        .WithOne("President")
                        .HasForeignKey("ArcheryMAS.Migrations.President", "Person_PESEL")
                        .IsRequired();

                    b.Navigation("Person_PESELNavigation");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.Training", b =>
                {
                    b.HasOne("ArcheryMAS.Migrations.Archer", "Archer_Person_PESELNavigation")
                        .WithMany("Training")
                        .HasForeignKey("Archer_Person_PESEL")
                        .IsRequired();

                    b.HasOne("ArcheryMAS.Migrations.Coach", "Coach_Person_PESELNavigation")
                        .WithMany("Training")
                        .HasForeignKey("Coach_Person_PESEL")
                        .IsRequired();

                    b.Navigation("Archer_Person_PESELNavigation");

                    b.Navigation("Coach_Person_PESELNavigation");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.UniversalSet", b =>
                {
                    b.HasOne("ArcheryMAS.Migrations.ArrowSetIndoor", "ArrowSetIndoor_ArrowSet")
                        .WithMany("UniversalSets")
                        .HasForeignKey("ArrowSetIndoor_ArrowSet_ID")
                        .IsRequired();

                    b.HasOne("ArcheryMAS.Migrations.ArrowSetOutdoor", "ArrowSetOutdoor_ArrowSet")
                        .WithMany("UniversalSets")
                        .HasForeignKey("ArrowSetOutdoor_ArrowSet_ID")
                        .IsRequired();

                    b.HasOne("ArcheryMAS.Migrations.ArrowSetTraining", "ArrowSetTraining_ArrowSet")
                        .WithMany("UniversalSets")
                        .HasForeignKey("ArrowSetTraining_ArrowSet_ID")
                        .IsRequired();

                    b.Navigation("ArrowSetIndoor_ArrowSet");

                    b.Navigation("ArrowSetOutdoor_ArrowSet");

                    b.Navigation("ArrowSetTraining_ArrowSet");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.Archer", b =>
                {
                    b.Navigation("ArcherInCompetitions");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.ArrowSet", b =>
                {
                    b.Navigation("ArrowSetIndoor");

                    b.Navigation("ArrowSetOutdoor");

                    b.Navigation("ArrowSetTraining");

                    b.Navigation("People");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.ArrowSetIndoor", b =>
                {
                    b.Navigation("UniversalSets");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.ArrowSetOutdoor", b =>
                {
                    b.Navigation("UniversalSets");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.ArrowSetTraining", b =>
                {
                    b.Navigation("UniversalSets");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.Bow", b =>
                {
                    b.Navigation("CompoundBow");

                    b.Navigation("OlympicBow");

                    b.Navigation("People");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.Coach", b =>
                {
                    b.Navigation("Training");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.Competition", b =>
                {
                    b.Navigation("ArcherInCompetitions");
                });

            modelBuilder.Entity("ArcheryMAS.Migrations.Person", b =>
                {
                    b.Navigation("Archer");

                    b.Navigation("Coach");

                    b.Navigation("President");
                });
#pragma warning restore 612, 618
        }
    }
}