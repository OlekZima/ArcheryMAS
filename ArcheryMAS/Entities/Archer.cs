using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArcheryMAS.Context;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Entities;

[Table("Archer")]
public partial class Archer
{
    [Key] public string Person_PESEL { get; set; } = null!;

    public string Rank { get; set; } = null!;

    public string? LeaveReason { get; set; }

    [InverseProperty("Archer_Person_PESELNavigation")]
    public virtual ICollection<ArcherInCompetition> ArcherInCompetitions { get; set; } =
        new List<ArcherInCompetition>();

    [ForeignKey("Person_PESEL")]
    [InverseProperty("Archer")]
    public virtual Person Person_PESELNavigation { get; set; } = null!;

    [InverseProperty("Archer_Person_PESELNavigation")]
    public virtual ICollection<Training> Training { get; set; } = new List<Training>();

    public void AddArcher(string PESEL, string names, string surname, DateTime dateOfBirth, string bowNickname,
        string rank, Coach coach)
    {
        using (var context = new ArcheryDbContext())
        {
            var allBows = context.Bows.ToList();
            var bow = allBows.Find(bow => bow.NickName == bowNickname);
            if (bow != null)
            {
                throw new Exception("Bow with given nickname does exist in the database");
            }

            var allCoaches = context.Coaches.ToList();
            var allTraining = context.Training.ToList();
            var allArchers = context.Archers.ToList();
            // count how many archers are trained by the given coach. These tables are connected by the Training table
            var arhcersCoach = allTraining.FindAll(training => training.Coach_Person_PESEL == coach.Person_PESEL);
            if (arhcersCoach.Count >= 3)
            {
                throw new Exception("Coach is already training 3 archers");
            }

            var newPerson = new Person()
            {
                PESEL = PESEL,
                Names = names,
                Surname = surname,
                DateOfBirth = dateOfBirth,
                Bow_NickName = bowNickname,
                Coach = coach
            };

            var newArcher = new Archer()
            {
                Person_PESEL = PESEL,
                Rank = rank,
                Person_PESELNavigation = newPerson,
            };

            context.Archers.Add(newArcher);
            context.SaveChanges();
        }
    }

    // reason and isDeleteData are optional parameters
    public void LeaveClub(string reason = "No reason provided", bool isDeleteData = false)
    {
        LeaveReason = reason;

        if (isDeleteData)
        {
            DeleteData();
        }
    }

    // TODO: implement this method
    public void DeleteData()
    {
        using var context = new ArcheryDbContext();

        // delete data with this archer from the database except for the Competition table and ArcherInCompetition table and Training table
        var allArcherInCompetition = context.Remove(this).Entity.ArcherInCompetitions;
    }
}