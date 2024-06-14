using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Entities;

[Table("ArrowSet")]
public partial class ArrowSet
{
    [Key] public int ID { get; set; }

    public string Person_PESEL { get; set; } = null!;

    public static int MinQuantity { get; set; }

    public int ArrowQuantity { get; set; }

    public string State { get; set; } = null!;

    [Column(TypeName = "double")] public double ArrowLength { get; set; }

    [InverseProperty("ArrowSet")] public virtual ArrowSetIndoor? ArrowSetIndoor { get; set; }

    [InverseProperty("ArrowSet")] public virtual ArrowSetOutdoor? ArrowSetOutdoor { get; set; }

    [InverseProperty("ArrowSet")] public virtual ArrowSetTraining? ArrowSetTraining { get; set; }

    [ForeignKey("Person_PESEL")]
    [InverseProperty("ArrowSets")]
    public virtual Person Person_PESELNavigation { get; set; } = null!;

    public static void ChangeMinQuantity(int newMinQuantity)
    {
        MinQuantity = newMinQuantity;
    }
}