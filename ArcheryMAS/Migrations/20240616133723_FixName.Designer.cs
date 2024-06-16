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
    [Migration("20240616133723_FixName")]
    partial class FixName
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
                            Person_PESEL = "50910221135",
                            Rank = "Cadet"
                        },
                        new
                        {
                            Person_PESEL = "81329863211",
                            Rank = "Senior"
                        },
                        new
                        {
                            Person_PESEL = "74198294289",
                            Rank = "Senior"
                        },
                        new
                        {
                            Person_PESEL = "98245229845",
                            Rank = "Junior"
                        },
                        new
                        {
                            Person_PESEL = "66299831239",
                            Rank = "Junior"
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
                            ID = 45,
                            ArrowLength = 31.202022359485682,
                            ArrowQuantity = 6,
                            MinQuantity = 0,
                            State = "New"
                        },
                        new
                        {
                            ID = 46,
                            ArrowLength = 28.790868543778348,
                            ArrowQuantity = 10,
                            MinQuantity = 0,
                            State = "Broken"
                        },
                        new
                        {
                            ID = 47,
                            ArrowLength = 34.266556707575653,
                            ArrowQuantity = 9,
                            MinQuantity = 0,
                            State = "Broken"
                        },
                        new
                        {
                            ID = 48,
                            ArrowLength = 33.305163011060145,
                            ArrowQuantity = 11,
                            MinQuantity = 0,
                            State = "Used"
                        },
                        new
                        {
                            ID = 49,
                            ArrowLength = 36.972003646064877,
                            ArrowQuantity = 9,
                            MinQuantity = 0,
                            State = "Broken"
                        },
                        new
                        {
                            ID = 50,
                            ArrowLength = 22.52871953834233,
                            ArrowQuantity = 8,
                            MinQuantity = 0,
                            State = "Broken"
                        },
                        new
                        {
                            ID = 51,
                            ArrowLength = 39.117178503798236,
                            ArrowQuantity = 10,
                            MinQuantity = 0,
                            State = "New"
                        },
                        new
                        {
                            ID = 52,
                            ArrowLength = 26.374453501102575,
                            ArrowQuantity = 11,
                            MinQuantity = 0,
                            State = "Used"
                        },
                        new
                        {
                            ID = 53,
                            ArrowLength = 32.33969771780103,
                            ArrowQuantity = 8,
                            MinQuantity = 0,
                            State = "Used"
                        },
                        new
                        {
                            ID = 54,
                            ArrowLength = 25.642501563257621,
                            ArrowQuantity = 8,
                            MinQuantity = 0,
                            State = "Broken"
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
                            NickName = "Nash",
                            Force = 25.271686831546461,
                            Manufacturer = "Hoyt"
                        },
                        new
                        {
                            NickName = "Kip",
                            Force = 25.522169910746822,
                            Manufacturer = "Hoyt"
                        },
                        new
                        {
                            NickName = "Bam",
                            Force = 39.630445426448652,
                            Manufacturer = "PSE"
                        },
                        new
                        {
                            NickName = "Neo",
                            Force = 47.127804667112322,
                            Manufacturer = "Bear"
                        },
                        new
                        {
                            NickName = "Jinx",
                            Force = 76.446941078189312,
                            Manufacturer = "Easton"
                        },
                        new
                        {
                            NickName = "Koda",
                            Force = 83.805043784932948,
                            Manufacturer = "Easton"
                        },
                        new
                        {
                            NickName = "Mack",
                            Force = 45.128274872978253,
                            Manufacturer = "Easton"
                        },
                        new
                        {
                            NickName = "Nile",
                            Force = 25.199545992582856,
                            Manufacturer = "Easton"
                        },
                        new
                        {
                            NickName = "Ginger",
                            Force = 78.155260500288009,
                            Manufacturer = "Bear"
                        },
                        new
                        {
                            NickName = "Bo",
                            Force = 59.425499819124468,
                            Manufacturer = "PSE"
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
                            PESEL = "74198294289",
                            ArrowSet_ID = 53,
                            Bow_NickName = "Neo",
                            DateOfBirth = new DateTime(2002, 12, 7, 7, 44, 6, 123, DateTimeKind.Local).AddTicks(9048),
                            Names = "Walenty, Jakubina",
                            Surname = "Żmuda"
                        },
                        new
                        {
                            PESEL = "16709791766",
                            ArrowSet_ID = 45,
                            Bow_NickName = "Bo",
                            DateOfBirth = new DateTime(1984, 1, 3, 20, 56, 27, 290, DateTimeKind.Local).AddTicks(6732),
                            Names = "Eustracjusz, Kamila",
                            Surname = "Leśniewski"
                        },
                        new
                        {
                            PESEL = "84096874650",
                            ArrowSet_ID = 46,
                            Bow_NickName = "Mack",
                            DateOfBirth = new DateTime(2003, 1, 3, 20, 15, 26, 635, DateTimeKind.Local).AddTicks(263),
                            Names = "Arystarch, Luiza",
                            Surname = "Janusz"
                        },
                        new
                        {
                            PESEL = "81329863211",
                            ArrowSet_ID = 54,
                            Bow_NickName = "Nile",
                            DateOfBirth = new DateTime(1991, 1, 15, 9, 58, 52, 668, DateTimeKind.Local).AddTicks(5389),
                            Names = "Onufry, Kleopatra",
                            Surname = "Milewski"
                        },
                        new
                        {
                            PESEL = "50540141027",
                            ArrowSet_ID = 52,
                            Bow_NickName = "Jinx",
                            DateOfBirth = new DateTime(1999, 7, 17, 8, 10, 30, 98, DateTimeKind.Local).AddTicks(9858),
                            Names = "Diana, Nikodem",
                            Surname = "Maślanka"
                        },
                        new
                        {
                            PESEL = "66299831239",
                            ArrowSet_ID = 51,
                            Bow_NickName = "Bam",
                            DateOfBirth = new DateTime(1961, 9, 25, 3, 24, 31, 957, DateTimeKind.Local).AddTicks(6003),
                            Names = "Justyna, Tomasz",
                            Surname = "Pająk"
                        },
                        new
                        {
                            PESEL = "44676240041",
                            ArrowSet_ID = 49,
                            Bow_NickName = "Kip",
                            DateOfBirth = new DateTime(1958, 5, 22, 5, 48, 34, 386, DateTimeKind.Local).AddTicks(1640),
                            Names = "Karolina, Lea",
                            Surname = "Przybył"
                        },
                        new
                        {
                            PESEL = "50910221135",
                            ArrowSet_ID = 48,
                            Bow_NickName = "Koda",
                            DateOfBirth = new DateTime(1988, 10, 27, 23, 1, 48, 545, DateTimeKind.Local).AddTicks(3119),
                            Names = "Hubert, Larysa",
                            Surname = "Marchewka"
                        },
                        new
                        {
                            PESEL = "45004851850",
                            ArrowSet_ID = 47,
                            Bow_NickName = "Ginger",
                            DateOfBirth = new DateTime(1965, 4, 19, 18, 38, 48, 807, DateTimeKind.Local).AddTicks(12),
                            Names = "Prokop, Agrypina",
                            Surname = "Łuczak"
                        },
                        new
                        {
                            PESEL = "98245229845",
                            ArrowSet_ID = 50,
                            Bow_NickName = "Nash",
                            DateOfBirth = new DateTime(1971, 6, 16, 18, 5, 18, 666, DateTimeKind.Local).AddTicks(5098),
                            Names = "Hieronim, Ida",
                            Surname = "Wnuk"
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