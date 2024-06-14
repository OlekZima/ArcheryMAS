using System;
using System.Collections.Generic;
using ArcheryMAS.Entities;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Person = ArcheryMAS.Entities.Person;

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

    // public virtual DbSet<Name> Names { get; set; }

    public virtual DbSet<OlympicBow> OlympicBows { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<President> Presidents { get; set; }

    public virtual DbSet<Training> Training { get; set; }

    public virtual DbSet<UniversalSet> UniversalSets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=ArcheryDB.sqlite");

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

        modelBuilder.Entity<ArrowSet>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();

            entity.HasOne(d => d.Person_PESELNavigation).WithMany(p => p.ArrowSets)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

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

        // modelBuilder.Entity<Name>(entity =>
        // {
        //     entity.Property(e => e.Id).ValueGeneratedNever();
        //
        //     entity.HasMany(d => d.Person_PESELs).WithMany(p => p.Names)
        //         .UsingEntity<Dictionary<string, object>>(
        //             "PersonName",
        //             r => r.HasOne<Person>().WithMany()
        //                 .HasForeignKey("Person_PESEL")
        //                 .OnDelete(DeleteBehavior.ClientSetNull),
        //             l => l.HasOne<Name>().WithMany()
        //                 .HasForeignKey("Name_Id")
        //                 .OnDelete(DeleteBehavior.ClientSetNull),
        //             j =>
        //             {
        //                 j.HasKey("Name_Id", "Person_PESEL");
        //                 j.ToTable("PersonNames");
        //             });
        // });

        modelBuilder.Entity<OlympicBow>(entity =>
        {
            entity.HasOne(d => d.Bow_NickNameNavigation).WithOne(p => p.OlympicBow)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasOne(d => d.Bow_NickNameNavigation).WithMany(p => p.People)
                .OnDelete(DeleteBehavior.ClientSetNull);
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

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    private void SeedData(ModelBuilder modelBuilder)
    {
        const int numOfData = 10;

        var manufacturers = new List<string> { "Hoyt", "Mathews", "PSE", "Bear", "Polaris", "Easton" };
        var bowNicknames = new List<string>
        {
            "Bake", "Bam", "The Balloon Buster", "Barron", "Beazle", "Bo", "Ginger", "Huss", "Jax", "Jinx", "JB", "Kai",
            "Kane", "Kip", "Knox", "Koda", "Kody", "Kona", "Kota", "Kruz", "Kyan", "Kylo", "Loki", "Mack", "Mako",
            "Mars", "Milo", "Moby", "Moe", "Moss", "Nash", "Neo", "Niko", "Nile", "Nino", "Niko", "Nash", "Neo",
        };
        var bowFaker = new Faker<Bow>()
            .RuleFor(b => b.Force, f => f.Random.Int(10, 100))
            .RuleFor(b => b.Manufacturer, f => f.PickRandom(manufacturers))
            .RuleFor(b => b.NickName, f =>
            {
                var pickedName = f.PickRandom(bowNicknames);
                bowNicknames.Remove(pickedName);
                return pickedName;
            });
        var bows = bowFaker.Generate(numOfData);
        modelBuilder.Entity<Bow>().HasData(bows);

        var personFaker = new Faker<Person>("pl")
            .RuleFor(p => p.PESEL, f => f.Random.String2(11, "0123456789"))
            .RuleFor(p => p.Names, f => $"{f.Name.FirstName()}, {f.Name.FirstName()}")
            .RuleFor(p => p.Surname, f => f.Name.LastName())
            .RuleFor(p => p.DateOfBirth, f => f.Date.Past(20, DateTime.Now))
            .RuleFor(p => p.Bow_NickName, f =>
            {
                var pickedBow = f.PickRandom(bows);
                bows.Remove(pickedBow);
                return pickedBow.NickName;
            });
        var people = personFaker.Generate(numOfData);
        modelBuilder.Entity<Person>().HasData(people);


        var personArchersIndexes = new List<int> { 0, 1, 2, 3, 4 };
        var arrowStates = new List<string> { "New", "Used", "Broken" };
        var arrowSetFaker = new Faker<ArrowSet>()
            .RuleFor(a => a.ID, f => f.Random.Int(1, 100))
            .RuleFor(a => a.Person_PESEL, f =>
            {
                var pickedPersonIndex = f.PickRandom(personArchersIndexes);
                personArchersIndexes.Remove(pickedPersonIndex);
                return people[pickedPersonIndex].PESEL;
            })
            .RuleFor(a => a.State, f => f.PickRandom(arrowStates))
            .RuleFor(a => a.ArrowLength, f => f.Random.Double(20, 40))
            .RuleFor(a => a.ArrowQuantity, f => f.Random.Int(6, 15));
        var arrowSets = arrowSetFaker.Generate(personArchersIndexes.Count);
        modelBuilder.Entity<ArrowSet>().HasData(arrowSets);


        personArchersIndexes = [0, 1, 2, 3, 4];
        var archerFaker = new Faker<Archer>()
            .RuleFor(a => a.Rank, f => f.PickRandom("Junior", "Cadet", "Senior"))
            .RuleFor(a => a.Person_PESEL, f =>
            {
                var pickedPersonIndex = f.PickRandom(personArchersIndexes);
                personArchersIndexes.Remove(pickedPersonIndex);
                return people[pickedPersonIndex].PESEL;
            })
            .RuleFor(a => a.Person_PESELNavigation.ArrowSet_ID, f =>
            {
                var pickedArrowSet = f.PickRandom(arrowSets);
                arrowSets.Remove(pickedArrowSet);
                return pickedArrowSet.ID;
            });
        var archers = archerFaker.Generate(personArchersIndexes.Count);
        modelBuilder.Entity<Archer>().HasData(archers);
    }
}