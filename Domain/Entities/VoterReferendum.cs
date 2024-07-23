namespace BallotCast.Domain;

public class VoterReferendum
{
    public int VoterId { get; private set; }
    public Voter Voter { get; private set; }
    public int ReferendumId { get; private set; }
    public Referendum Referendum { get; private set; }
    public bool CanVote { get; private set; }

    public VoterReferendum(Voter voter, Referendum referendum, bool canVote)
    {
        Voter = voter ?? throw new ArgumentNullException(nameof(voter));
        VoterId = voter.Id;
        Referendum = referendum ?? throw new ArgumentNullException(nameof(referendum));
        ReferendumId = referendum.Id;
        CanVote = canVote;
    }
}
