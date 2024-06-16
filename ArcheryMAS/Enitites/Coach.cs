using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Migrations;

[Table("Coach")]
public partial class Coach
{
    [Key] public string Person_PESEL { get; set; } = null!;

    public int MinSalary { get; set; }

    public int Bonus { get; set; }

    [ForeignKey("Person_PESEL")]
    [InverseProperty("Coach")]
    public virtual Person Person_PESELNavigation { get; set; } = null!;

    [InverseProperty("Coach_Person_PESELNavigation")]
    public virtual ICollection<Training> Training { get; set; } = new List<Training>();
}