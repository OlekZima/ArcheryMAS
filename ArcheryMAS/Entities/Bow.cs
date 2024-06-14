using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Entities;

[Table("Bow")]
public partial class Bow
{
    [Key]
    public string NickName
    {
        get => NickName;
        set
        {
            if (value.Length >= 30)
            {
                throw new Exception("NickName is too long");
            }
        }
    }

    public string Manufacturer { get; set; } = null!;

    [Column(TypeName = "double")] public double Force { get; set; }

    [InverseProperty("Bow_NickNameNavigation")]
    public virtual CompoundBow? CompoundBow { get; set; }

    [InverseProperty("Bow_NickNameNavigation")]
    public virtual OlympicBow? OlympicBow { get; set; }

    [InverseProperty("Bow_NickNameNavigation")]
    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}