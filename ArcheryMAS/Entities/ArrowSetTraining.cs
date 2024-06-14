using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Entities;

[Table("ArrowSetTraining")]
public partial class ArrowSetTraining
{
    public string Material { get; set; } = "Aluminum";

    [Key] public int ArrowSet_ID { get; set; }

    [ForeignKey("ArrowSet_ID")]
    [InverseProperty("ArrowSetTraining")]
    public virtual ArrowSet ArrowSet { get; set; } = null!;

    [InverseProperty("ArrowSetTraining_ArrowSet")]
    public virtual ICollection<UniversalSet> UniversalSets { get; set; } = new List<UniversalSet>();
}