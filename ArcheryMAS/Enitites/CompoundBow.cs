using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArcheryMAS.Enitites;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Migrations;

[Table("CompoundBow")]
public partial class CompoundBow
{
    [Key] public string Bow_NickName { get; set; } = null!;

    [Column(TypeName = "double")] public double OpticalZoom { get; set; }

    [ForeignKey("Bow_NickName")]
    [InverseProperty("CompoundBow")]
    public virtual Bow Bow_NickNameNavigation { get; set; } = null!;
}