using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArcheryMAS.Migrations;

namespace ArcheryMAS.Enitites;

[Table("Competition")]
public partial class Competition
{
    [Key]
    [Column(TypeName = "varchar(50)")]
    [StringLength(50, ErrorMessage = "Nazwa nie może przekraczać 50 znaków.")]
    [Required(ErrorMessage = "Nazwa jest wymagana.")]
    public string Name { get; set; } = null!;

    [Column(TypeName = "varchar(200)")]
    [StringLength(200, ErrorMessage = "Opis nie może przekraczać 200 znaków.")]
    public string? Description { get; set; }

    public string Place { get; set; } = null!;


    [Column(TypeName = "datetime")]
    [Required(ErrorMessage = "Data i godzina rozpoczęcia są wymagane.")]
    public DateTime DateAndTimeStart { get; set; }

    [Column(TypeName = "datetime")]
    [Required(ErrorMessage = "Data i godzina zakończenia są wymagane.")]
    public DateTime DateAndTimeEnd { get; set; }

    public string State { get; set; } = null!;

    public string? CancelingReason { get; set; }

    [InverseProperty("Competition_NameNavigation")]
    public virtual ICollection<ArcherInCompetition> ArcherInCompetitions { get; set; } =
        new List<ArcherInCompetition>();
}