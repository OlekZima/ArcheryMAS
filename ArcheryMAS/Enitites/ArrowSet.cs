using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArcheryMAS.Migrations;

namespace ArcheryMAS.Enitites;

[Table("ArrowSet")]
public partial class ArrowSet
{
    [Key] public int ID { get; set; }

    public int MinQuantity { get; set; }

    public int ArrowQuantity { get; set; }

    public string State { get; set; } = null!;

    [Column(TypeName = "double")] public double ArrowLength { get; set; }

    [InverseProperty("ArrowSet")] public virtual ArrowSetIndoor? ArrowSetIndoor { get; set; }

    [InverseProperty("ArrowSet")] public virtual ArrowSetOutdoor? ArrowSetOutdoor { get; set; }

    [InverseProperty("ArrowSet")] public virtual ArrowSetTraining? ArrowSetTraining { get; set; }

    [InverseProperty("ArrowSet")] public virtual ICollection<Person> People { get; set; } = new List<Person>();
}