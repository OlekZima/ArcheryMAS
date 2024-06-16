﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArcheryMAS.Migrations;

namespace ArcheryMAS.Enitites;

[Table("President")]
public partial class President
{
    [Key] public string Person_PESEL { get; set; } = null!;

    public string DegreeOfEducation { get; set; } = null!;

    [ForeignKey("Person_PESEL")]
    [InverseProperty("President")]
    public virtual Person Person_PESELNavigation { get; set; } = null!;
}