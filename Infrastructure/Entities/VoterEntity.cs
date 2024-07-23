using System.ComponentModel.DataAnnotations;

namespace BallotCast.Infrastructure;

public class VoterEntity
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public required string Name { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(100)]
    public required string Email { get; set; }

    public virtual List<VoterReferendumEntity> EligibleReferendums { get; set; } = new List<VoterReferendumEntity>();
    public virtual List<VoteEntity> CastVotes { get; set; } = new List<VoteEntity>();
}