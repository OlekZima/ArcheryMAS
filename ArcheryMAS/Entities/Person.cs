using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Entities;

[Table("Person")]
public partial class Person
{
    [Key] public string PESEL { get; set; } = null!;

    public string Bow_NickName { get; set; } = null!;

    public int ArrowSet_ID { get; set; }

    public string Surname { get; set; } = null!;

    [Column(TypeName = "date")] public DateTime DateOfBirth { get; set; }

    public string Names { get; set; } = null!;

    [InverseProperty("Person_PESELNavigation")]
    public virtual Archer? Archer { get; set; }

    [InverseProperty("Person_PESELNavigation")]
    public virtual ICollection<ArrowSet> ArrowSets { get; set; } = new List<ArrowSet>();

    [ForeignKey("Bow_NickName")]
    [InverseProperty("People")]
    public virtual Bow Bow_NickNameNavigation { get; set; } = null!;

    [InverseProperty("Person_PESELNavigation")]
    public virtual Coach? Coach { get; set; }

    [InverseProperty("Person_PESELNavigation")]
    public virtual President? President { get; set; }
}