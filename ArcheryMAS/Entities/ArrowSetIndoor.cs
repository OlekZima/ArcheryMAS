using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Entities;

[Table("ArrowSetIndoor")]
public partial class ArrowSetIndoor
{
    [Column(TypeName = "double")] public static double MaxDiameter { get; set; }

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
    [InverseProperty("ArrowSetIndoor")]
    public virtual ArrowSet ArrowSet { get; set; } = null!;

    [InverseProperty("ArrowSetIndoor_ArrowSet")]
    public virtual ICollection<UniversalSet> UniversalSets { get; set; } = new List<UniversalSet>();

    public static void ChangeMaxDiameter(double newMaxDiameter)
    {
        MaxDiameter = newMaxDiameter;
    }
}