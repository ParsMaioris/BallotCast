using System.ComponentModel.DataAnnotations;

namespace BallotCast.Infrastructure;

public class ParagraphEntity
{
    public int Id { get; set; }

    [Required]
    [MaxLength(500)]
    public string Content { get; set; }

    public int ReferendumId { get; set; }
    public virtual ReferendumEntity Referendum { get; set; }
}