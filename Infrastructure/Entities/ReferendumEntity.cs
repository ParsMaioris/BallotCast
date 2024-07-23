using System.ComponentModel.DataAnnotations;

namespace BallotCast.Infrastructure;

public class ReferendumEntity
{
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public required string Title { get; set; }

    [Required]
    [MaxLength(1000)]
    public required string Question { get; set; }

    public virtual List<ParagraphEntity> Paragraphs { get; set; } = new List<ParagraphEntity>();

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? LastModifiedDate { get; set; }
    public ReferendumStatusEntity Status { get; set; } = ReferendumStatusEntity.Pending;

    public virtual List<VoterReferendumEntity> EligibleVoters { get; set; } = new List<VoterReferendumEntity>();
    public virtual List<VoteEntity> Votes { get; set; } = new List<VoteEntity>();

    public int? ResultId { get; set; }
    public virtual ReferendumResultEntity? Result { get; set; }
}