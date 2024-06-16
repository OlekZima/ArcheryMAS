using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Migrations;

[PrimaryKey("ArrowSetIndoor_ArrowSet_ID", "ArrowSetOutdoor_ArrowSet_ID", "ArrowSetTraining_ArrowSet_ID")]
[Table("UniversalSet")]
public partial class UniversalSet
{
    [Column(TypeName = "double")] public double Price { get; set; }

    public int Age { get; set; }

    [Key] public int ArrowSetIndoor_ArrowSet_ID { get; set; }

    [Key] public int ArrowSetOutdoor_ArrowSet_ID { get; set; }

    [Key] public int ArrowSetTraining_ArrowSet_ID { get; set; }

    [ForeignKey("ArrowSetIndoor_ArrowSet_ID")]
    [InverseProperty("UniversalSets")]
    public virtual ArrowSetIndoor ArrowSetIndoor_ArrowSet { get; set; } = null!;

    [ForeignKey("ArrowSetOutdoor_ArrowSet_ID")]
    [InverseProperty("UniversalSets")]
    public virtual ArrowSetOutdoor ArrowSetOutdoor_ArrowSet { get; set; } = null!;

    [ForeignKey("ArrowSetTraining_ArrowSet_ID")]
    [InverseProperty("UniversalSets")]
    public virtual ArrowSetTraining ArrowSetTraining_ArrowSet { get; set; } = null!;
}