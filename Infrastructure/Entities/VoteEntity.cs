namespace BallotCast.Infrastructure;

public class VoteEntity
{
    public int Id { get; set; }

    public int VoterId { get; set; }
    public virtual VoterEntity Voter { get; set; }

    public int ReferendumId { get; set; }
    public virtual ReferendumEntity Referendum { get; set; }

    public bool IsYes { get; set; }
    public DateTime VoteDate { get; set; } = DateTime.UtcNow;
}