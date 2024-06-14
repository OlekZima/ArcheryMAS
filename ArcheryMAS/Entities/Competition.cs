using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArcheryMAS.Context;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Entities;

[Table("Competition")]
public partial class Competition
{
    [Key] public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Place { get; set; } = null!;

    [Column(TypeName = "datetime")] public DateTime DateAndTimeStart { get; set; }

    [Column(TypeName = "datetime")] public DateTime DateAndTimeEnd { get; set; }

    public string State
    {
        get => State;
        set
        {
            var states = new List<string> { "Announced", "Started", "Finished", "Canceled" };
            if (!states.Contains(value))
            {
                throw new ArgumentException("Invalid state!");
            }
        }
    }

    public string? CancelingReason { get; set; }

    [InverseProperty("Competition_NameNavigation")]
    public virtual ICollection<ArcherInCompetition> ArcherInCompetitions { get; set; } =
        new List<ArcherInCompetition>();


    public static void AnnounceCompetition(string name, string place, DateTime dateAndTimeStart,
        DateTime dateAndTimeEnd, string? description, List<Archer>? archersToAdd)
    {
        if (name.Length >= 50)
        {
            throw new ArgumentException("Name is too long!");
        }

        if (description != null && description.Length >= 200)
        {
            throw new ArgumentException("Description is too long!");
        }

        if (dateAndTimeEnd < dateAndTimeStart)
        {
            throw new ArgumentException("End date is before start date!");
        }

        using var context = new ArcheryDbContext();
        var competition = new Competition
        {
            Name = name,
            Place = place,
            DateAndTimeStart = dateAndTimeStart,
            DateAndTimeEnd = dateAndTimeEnd,
            State = "Announced"
        };
        context.Competitions.Add(competition);
        context.SaveChanges();
    }
}