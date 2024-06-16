using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArcheryMAS.Enitites;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Enitites;

[Table("ArrowSetOutdoor")]
public partial class ArrowSetOutdoor
{
    public string Material { get; set; } = null!;

    [Column(TypeName = "double")] public double MaxDiameter { get; set; }

    [Column(TypeName = "double")] public double Diameter { get; set; }

    [Key] public int ArrowSet_ID { get; set; }

    [ForeignKey("ArrowSet_ID")]
    [InverseProperty("ArrowSetOutdoor")]
    public virtual ArrowSet ArrowSet { get; set; } = null!;

    [InverseProperty("ArrowSetOutdoor_ArrowSet")]
    public virtual ICollection<UniversalSet> UniversalSets { get; set; } = new List<UniversalSet>();
}