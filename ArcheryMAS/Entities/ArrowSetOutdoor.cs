using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Entities;

[Table("ArrowSetOutdoor")]
public partial class ArrowSetOutdoor
{
    public string Material { get; set; } = "Carbon";

    [Column(TypeName = "double")] public static double MaxDiameter { get; set; } = 4;

    [Column(TypeName = "double")]
    public double Diameter
    {
        get => Diameter;
        set
        {
            if (value >= MaxDiameter)
            {
                throw new ArgumentOutOfRangeException("Diameter is too big");
            }
        }
    }

    [Key] public int ArrowSet_ID { get; set; }

    [ForeignKey("ArrowSet_ID")]
    [InverseProperty("ArrowSetOutdoor")]
    public virtual ArrowSet ArrowSet { get; set; } = null!;

    [InverseProperty("ArrowSetOutdoor_ArrowSet")]
    public virtual ICollection<UniversalSet> UniversalSets { get; set; } = new List<UniversalSet>();
}