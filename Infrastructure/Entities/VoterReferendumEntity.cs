namespace BallotCast.Infrastructure;

public class VoterReferendumEntity
{
    public int VoterId { get; set; }
    public virtual VoterEntity Voter { get; set; }

    public int ReferendumId { get; set; }
    public virtual ReferendumEntity Referendum { get; set; }

    public bool CanVote { get; set; } = false;
}