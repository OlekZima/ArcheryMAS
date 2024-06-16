using System;
using System.Collections.Generic;
using ArcheryMAS.Enitites;
using ArcheryMAS.Migrations;
using Bogus;
using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using Person = ArcheryMAS.Enitites.Person;

namespace ArcheryMAS.Context;

public partial class ArcheryDbContext : DbContext
{
    public ArcheryDbContext()
    {
    }

    public ArcheryDbContext(DbContextOptions<ArcheryDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Archer> Archers { get; set; }

    public virtual DbSet<ArcherInCompetition> ArcherInCompetitions { get; set; }

    public virtual DbSet<ArrowSet> ArrowSets { get; set; }

    public virtual DbSet<ArrowSetIndoor> ArrowSetIndoors { get; set; }

    public virtual DbSet<ArrowSetOutdoor> ArrowSetOutdoors { get; set; }

    public virtual DbSet<ArrowSetTraining> ArrowSetTrainings { get; set; }

    public virtual DbSet<Bow> Bows { get; set; }

    public virtual DbSet<Coach> Coaches { get; set; }

    public virtual DbSet<Competition> Competitions { get; set; }

    public virtual DbSet<CompoundBow> CompoundBows { get; set; }

    public virtual DbSet<OlympicBow> OlympicBows { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<President?> Presidents { get; set; }

    public virtual DbSet<Training> Training { get; set; }

    public virtual DbSet<UniversalSet> UniversalSets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https: //go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=F:\\MAS_CS\\ArcheryMAS\\ArcheryMAS\\ArcherDb.sqlite");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Archer>(entity =>
        {
            entity.HasOne(d => d.Person_PESELNavigation).WithOne(p => p.Archer)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ArcherInCompetition>(entity =>
        {
            entity.HasOne(d => d.Archer_Person_PESELNavigation).WithMany(p => p.ArcherInCompetitions)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Competition_NameNavigation).WithMany(p => p.ArcherInCompetitions)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ArrowSet>(entity => { entity.Property(e => e.ID).ValueGeneratedNever(); });

        modelBuilder.Entity<ArrowSetIndoor>(entity =>
        {
            entity.Property(e => e.ArrowSet_ID).ValueGeneratedNever();

            entity.HasOne(d => d.ArrowSet).WithOne(p => p.ArrowSetIndoor).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ArrowSetOutdoor>(entity =>
        {
            entity.Property(e => e.ArrowSet_ID).ValueGeneratedNever();

            entity.HasOne(d => d.ArrowSet).WithOne(p => p.ArrowSetOutdoor).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ArrowSetTraining>(entity =>
        {
            entity.Property(e => e.ArrowSet_ID).ValueGeneratedNever();

            entity.HasOne(d => d.ArrowSet).WithOne(p => p.ArrowSetTraining).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Coach>(entity =>
        {
            entity.HasOne(d => d.Person_PESELNavigation).WithOne(p => p.Coach)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<CompoundBow>(entity =>
        {
            entity.HasOne(d => d.Bow_NickNameNavigation).WithOne(p => p.CompoundBow)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<OlympicBow>(entity =>
        {
            entity.HasOne(d => d.Bow_NickNameNavigation).WithOne(p => p.OlympicBow)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasOne(d => d.ArrowSet).WithMany(p => p.People).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Bow_NickNameNavigation).WithMany(p => p.People).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<President>(entity =>
        {
            entity.HasOne(d => d.Person_PESELNavigation).WithOne(p => p.President)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Training>(entity =>
        {
            entity.HasOne(d => d.Archer_Person_PESELNavigation).WithMany(p => p.Training)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Coach_Person_PESELNavigation).WithMany(p => p.Training)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UniversalSet>(entity =>
        {
            entity.HasOne(d => d.ArrowSetIndoor_ArrowSet).WithMany(p => p.UniversalSets)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ArrowSetOutdoor_ArrowSet).WithMany(p => p.UniversalSets)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ArrowSetTraining_ArrowSet).WithMany(p => p.UniversalSets)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
        SeedData(modelBuilder);
    }

    private void SeedData(ModelBuilder modelBuilder)
    {
        var numOfData = 10;

        var manufacturers = new List<string> { "Hoyt", "Mathews", "PSE", "Bear", "Polaris", "Easton" };
        var bowNicknames = new List<string>
        {
            "Bake", "Bam", "The Balloon Buster", "Barron", "Beazle", "Bo", "Ginger", "Huss", "Jax", "Jinx", "JB", "Kai",
            "Kane", "Kip", "Knox", "Koda", "Kody", "Kona", "Kota", "Kruz", "Kyan", "Kylo", "Loki", "Mack", "Mako",
            "Mars", "Milo", "Moby", "Moe", "Moss", "Nash", "Neo", "Niko", "Nile", "Nino", "Niko", "Nash", "Neo",
        };

        var arrowStates = new List<string> { "New", "Used", "Broken" };


        var bowFaker = new Faker<Bow>()
            .RuleFor(b => b.Force, f => f.Random.Double(10, 100))
            .RuleFor(b => b.Manufacturer, f => f.PickRandom(manufacturers))
            .RuleFor(b => b.NickName, f =>
            {
                var pickedName = f.PickRandom(bowNicknames);
                bowNicknames.Remove(pickedName);
                return pickedName;
            });
        var bows = bowFaker.Generate(numOfData);
        modelBuilder.Entity<Bow>().HasData(bows);

        var arrowSetFaker = new Faker<ArrowSet>()
            .RuleFor(a => a.ArrowQuantity, f => f.Random.Int(6, 12))
            .RuleFor(a => a.ArrowLength, f => f.Random.Double(20, 40))
            .RuleFor(a => a.State, f => f.PickRandom(arrowStates))
            .RuleFor(a => a.ID, f => f.UniqueIndex);
        var arrowSets = arrowSetFaker.Generate(numOfData);
        modelBuilder.Entity<ArrowSet>().HasData(arrowSets);

        var personFaker = new Faker<Person>("pl")
            .RuleFor(p => p.PESEL, f => f.Random.ReplaceNumbers("###########"))
            .RuleFor(p => p.Names, f =>
            {
                var gender = f.PickRandom(Name.Gender.Female, Name.Gender.Male);
                return $"{f.Name.FirstName(gender)}, {f.Name.FirstName(gender)}";
            })
            .RuleFor(p => p.Surname, f => f.Person.LastName)
            .RuleFor(p => p.DateOfBirth, f => f.Person.DateOfBirth)
            .RuleFor(p => p.Bow_NickName, f =>
            {
                var pickedBow = f.PickRandom(bows);
                bows.Remove(pickedBow);
                return pickedBow.NickName;
            })
            .RuleFor(p => p.ArrowSet_ID, f =>
            {
                var picked = f.PickRandom(arrowSets);
                arrowSets.Remove(picked);
                return picked.ID;
            });

        var people = personFaker.Generate(numOfData);
        modelBuilder.Entity<Person>().HasData(people);


        var archerFaker = new Faker<Archer>()
            .RuleFor(a => a.Person_PESEL, f =>
            {
                var pickedPerson = f.PickRandom(people);
                people.Remove(pickedPerson);
                return pickedPerson.PESEL;
            })
            .RuleFor(a => a.Rank, f => f.PickRandom("Junior", "Cadet", "Senior"));

        var archers = archerFaker.Generate(5);
        modelBuilder.Entity<Archer>().HasData(archers);

        var coachFake = new Faker<Coach>()
            .RuleFor(c => c.Person_PESEL, f =>
            {
                var pickedPerson = f.PickRandom(people);
                people.Remove(pickedPerson);
                return pickedPerson.PESEL;
            })
            // .RuleFor(c=> c.MinSalary, 5000)
            .RuleFor(c => c.Bonus, f => f.Random.Int(100, 1000));
        var coaches = coachFake.Generate(4);
        modelBuilder.Entity<Coach>().HasData(coaches);


        // var bowPresident = new Bow()
        // {
        //     NickName = "2137",
        //     Manufacturer = "Hoyt",
        //     Force = 50
        // };
        // modelBuilder.Entity<Bow>().HasData(bowPresident);
        //
        // var personPresident = new Person()
        // {
        //     PESEL = "11111111111",
        //     Names = "Janusz",
        //     Surname = "Prezes",
        //     DateOfBirth = new DateTime(1970, 1, 1),
        //     Bow_NickName = bowPresident.NickName,
        // };
        // modelBuilder.Entity<Person>().HasData(personPresident);
        //
        // var president = new President()
        // {
        //     Person_PESEL = personPresident.PESEL,
        //     DegreeOfEducation = "Master",
        // };
        // personPresident.President = president;
        // modelBuilder.Entity<President>().HasData(president);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}