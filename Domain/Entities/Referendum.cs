namespace BallotCast.Domain;

public class Referendum
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Question { get; private set; }
    private readonly List<Paragraph> _paragraphs = new List<Paragraph>();
    public IReadOnlyCollection<Paragraph> Paragraphs => _paragraphs.AsReadOnly();
    private readonly List<VoterReferendum> _eligibleVoters = new List<VoterReferendum>();
    public IReadOnlyCollection<VoterReferendum> EligibleVoters => _eligibleVoters.AsReadOnly();
    private readonly List<Vote> _votes = new List<Vote>();
    public IReadOnlyCollection<Vote> Votes => _votes.AsReadOnly();
    public ReferendumStatus Status { get; private set; }
    public ReferendumResult Result { get; private set; }

    public Referendum(int id, string title, string question)
    {
        Id = id;
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Question = question ?? throw new ArgumentNullException(nameof(question));
        Status = ReferendumStatus.Pending;
    }

    public void AddParagraph(Paragraph paragraph)
    {
        if (paragraph == null) throw new ArgumentNullException(nameof(paragraph));
        _paragraphs.Add(paragraph);
    }

    public void AddEligibleVoter(VoterReferendum voterReferendum)
    {
        if (voterReferendum == null) throw new ArgumentNullException(nameof(voterReferendum));
        _eligibleVoters.Add(voterReferendum);
    }

    public void AddVote(Vote vote)
    {
        if (vote == null) throw new ArgumentNullException(nameof(vote));
        _votes.Add(vote);
    }

    public void SetResult(ReferendumResult result)
    {
        if (result == null) throw new ArgumentNullException(nameof(result));
        Result = result;
    }
}