using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Entities;

[Table("OlympicBow")]
public partial class OlympicBow
{
    [Key] public string Bow_NickName { get; set; } = null!;

    public int NummberOfStabilizers { get; set; }

    public static int MaxDaysWithoutService { get; set; }

    public int DaysWithoutService { get; set; }

    [ForeignKey("Bow_NickName")]
    [InverseProperty("OlympicBow")]
    public virtual Bow Bow_NickNameNavigation { get; set; } = null!;
}