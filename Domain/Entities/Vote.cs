namespace BallotCast.Domain;

public class Vote
{
    public int Id { get; private set; }
    public int VoterId { get; private set; }
    public Voter Voter { get; private set; }
    public int ReferendumId { get; private set; }
    public Referendum Referendum { get; private set; }
    public bool IsYes { get; private set; }
    public DateTime VoteDate { get; private set; }

    public Vote(int id, Voter voter, Referendum referendum, bool isYes)
    {
        Id = id;
        Voter = voter ?? throw new ArgumentNullException(nameof(voter));
        VoterId = voter.Id;
        Referendum = referendum ?? throw new ArgumentNullException(nameof(referendum));
        ReferendumId = referendum.Id;
        IsYes = isYes;
        VoteDate = DateTime.UtcNow;
    }
}