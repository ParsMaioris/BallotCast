namespace BallotCast.Domain;

public class VoterInsights
{
    public Voter Voter { get; private set; }
    public int TotalVotes { get; private set; }
    public int YesVotes { get; private set; }
    public int NoVotes { get; private set; }
    public IReadOnlyCollection<Vote> VoteHistory { get; private set; }

    public VoterInsights(Voter voter, IEnumerable<Vote> votes)
    {
        Voter = voter ?? throw new ArgumentNullException(nameof(voter));
        VoteHistory = votes?.ToList() ?? throw new ArgumentNullException(nameof(votes));

        TotalVotes = VoteHistory.Count;
        YesVotes = VoteHistory.Count(v => v.IsYes);
        NoVotes = VoteHistory.Count(v => !v.IsYes);
    }
}