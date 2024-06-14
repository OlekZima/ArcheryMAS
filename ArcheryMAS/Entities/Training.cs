using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Entities;

[PrimaryKey("Archer_Person_PESEL", "Coach_Person_PESEL")]
public partial class Training
{
    [Key] public string Archer_Person_PESEL { get; set; } = null!;

    [Key] public string Coach_Person_PESEL { get; set; } = null!;

    [Column(TypeName = "datetime")] public DateTime DateAndTimeTrainingStart { get; set; }

    [Column(TypeName = "datetime")] public DateTime DateAndTimeTrainingEnd { get; set; }

    [ForeignKey("Archer_Person_PESEL")]
    [InverseProperty("Training")]
    public virtual Archer Archer_Person_PESELNavigation { get; set; } = null!;

    [ForeignKey("Coach_Person_PESEL")]
    [InverseProperty("Training")]
    public virtual Coach Coach_Person_PESELNavigation { get; set; } = null!;
}