using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArcheryMAS.Context;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Entities;

[Table("Coach")]
public partial class Coach
{
    [Key] public string Person_PESEL { get; set; } = null!;

    public static int MinSalary { get; set; } = 5000;

    public int Bonus
    {
        get
        {
            int bonus = (Training.Count / 4) * 300;
            return bonus;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"Bonus can't be negative.");
            }
        }
    }

    [ForeignKey("Person_PESEL")]
    [InverseProperty("Coach")]
    public virtual Person Person_PESELNavigation { get; set; } = null!;

    [InverseProperty("Coach_Person_PESELNavigation")]
    public virtual ICollection<Training> Training { get; set; } = new List<Training>();

    public static void ChangeMinSalary(int newMinSalary)
    {
        if (newMinSalary < MinSalary)
        {
            throw new ArgumentOutOfRangeException("New minimum salary can't be lower than the current one.");
        }

        MinSalary = newMinSalary;
    }

    public int CalculateSalary()
    {
        return MinSalary + Bonus;
    }

    public void AddCoach(string PESEL, string names, string surname)
    {
        using var context = new ArcheryDbContext();

        if (context.Coaches.Find(PESEL) != null)
        {
            throw new InvalidOperationException("Someone with this PESEL already exists.");
        }

        context.Coaches.Add(new Coach
        {
            Person_PESEL = PESEL,
            Person_PESELNavigation = new Person
            {
                PESEL = PESEL,
                Names = names,
                Surname = surname
            }
        });

        context.SaveChanges();
    }
}