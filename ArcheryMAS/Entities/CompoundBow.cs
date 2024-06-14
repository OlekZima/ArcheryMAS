using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Entities;

[Table("CompoundBow")]
public partial class CompoundBow
{
    [Key] public string Bow_NickName { get; set; } = null!;

    [Column(TypeName = "double")]
    public double OpticalZoom
    {
        get => OpticalZoom;
        set
        {
            if (value >= 2.5)
            {
                throw new Exception("OpticalZoom is too strong!");
            }
        }
    }

    [ForeignKey("Bow_NickName")]
    [InverseProperty("CompoundBow")]
    public virtual Bow Bow_NickNameNavigation { get; set; } = null!;
}