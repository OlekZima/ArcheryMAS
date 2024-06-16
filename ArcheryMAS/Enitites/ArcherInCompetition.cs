using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Migrations;

[PrimaryKey("Archer_Person_PESEL", "Competition_Name")]
[Table("ArcherInCompetition")]
public partial class ArcherInCompetition
{
    public int PlaceInCompetition { get; set; }

    public int Score { get; set; }

    public string Prize { get; set; } = null!;

    [Key]
    public string Archer_Person_PESEL { get; set; } = null!;

    [Key]
    public string Competition_Name { get; set; } = null!;

    [ForeignKey("Archer_Person_PESEL")]
    [InverseProperty("ArcherInCompetitions")]
    public virtual Archer Archer_Person_PESELNavigation { get; set; } = null!;

    [ForeignKey("Competition_Name")]
    [InverseProperty("ArcherInCompetitions")]
    public virtual Competition Competition_NameNavigation { get; set; } = null!;
}
