using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Migrations;

[Table("Archer")]
public partial class Archer
{
    [Key]
    public string Person_PESEL { get; set; } = null!;

    public string Rank { get; set; } = null!;

    public string? LeaveReason { get; set; }

    [InverseProperty("Archer_Person_PESELNavigation")]
    public virtual ICollection<ArcherInCompetition> ArcherInCompetitions { get; set; } = new List<ArcherInCompetition>();

    [ForeignKey("Person_PESEL")]
    [InverseProperty("Archer")]
    public virtual Person Person_PESELNavigation { get; set; } = null!;

    [InverseProperty("Archer_Person_PESELNavigation")]
    public virtual ICollection<Training> Training { get; set; } = new List<Training>();
}
