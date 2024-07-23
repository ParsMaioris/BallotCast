namespace BallotCast.Domain;

public class Voter
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    private readonly List<VoterReferendum> _eligibleReferendums = new List<VoterReferendum>();
    public IReadOnlyCollection<VoterReferendum> EligibleReferendums => _eligibleReferendums.AsReadOnly();
    private readonly List<Vote> _castVotes = new List<Vote>();
    public IReadOnlyCollection<Vote> CastVotes => _castVotes.AsReadOnly();

    public Voter(int id, string name, string email)
    {
        Id = id;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Email = email ?? throw new ArgumentNullException(nameof(email));
    }

    public void AddEligibleReferendum(VoterReferendum voterReferendum)
    {
        if (voterReferendum == null) throw new ArgumentNullException(nameof(voterReferendum));
        _eligibleReferendums.Add(voterReferendum);
    }

    public void AddVote(Vote vote)
    {
        if (vote == null) throw new ArgumentNullException(nameof(vote));
        _castVotes.Add(vote);
    }
}