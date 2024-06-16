using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArcheryMAS.Migrations;

[Table("President")]
public partial class President
{
    [Key] public string Person_PESEL { get; set; } = null!;

    public string DegreeOfEducation { get; set; } = null!;

    [ForeignKey("Person_PESEL")]
    [InverseProperty("President")]
    public virtual Person Person_PESELNavigation { get; set; } = null!;
}