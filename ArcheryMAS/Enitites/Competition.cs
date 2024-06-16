using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Migrations;

[Table("Competition")]
public partial class Competition
{
    [Key]
    [Column(TypeName = "varchar(50)")]
    public string Name { get; set; } = null!;

    [Column(TypeName = "varchar(200)")] public string? Description { get; set; }

    public string Place { get; set; } = null!;

    [Column(TypeName = "datetime")] public DateTime DateAndTimeStart { get; set; }

    [Column(TypeName = "datetime")] public DateTime DateAndTimeEnd { get; set; }

    public string State { get; set; } = null!;

    public string? CancelingReason { get; set; }

    [InverseProperty("Competition_NameNavigation")]
    public virtual ICollection<ArcherInCompetition> ArcherInCompetitions { get; set; } =
        new List<ArcherInCompetition>();
}