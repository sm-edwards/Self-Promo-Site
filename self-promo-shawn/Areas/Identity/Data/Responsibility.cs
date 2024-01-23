using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace self_promo_shawn.Data;

public class Responsibility
{
    [Key] public int ResponsibilityId { get; set; }
    [Required] [MaxLength(150)] public string Value { get; set; } = default!;

    // Foreign Key field (referencing "parent")
    public int ExperienceId { get; set; }
    public int SequenceNumber{get; set;}

    // Navigation property (referencing "parent")
    public Experience? Experience { get; set; }
}