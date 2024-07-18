namespace BallotCast.Domain;

public class ReferendumResult
{
    public int Id { get; private set; }
    public DateTime ResultDate { get; private set; }
    public List<OptionResult> OptionResults { get; private set; }

    public ReferendumResult(DateTime resultDate, List<OptionResult> optionResults)
    {
        ResultDate = resultDate;
        OptionResults = optionResults ?? new List<OptionResult>();
    }

    internal ReferendumResult(int id, DateTime resultDate, List<OptionResult> optionResults)
    {
        Id = id;
        ResultDate = resultDate;
        OptionResults = optionResults ?? new List<OptionResult>();
    }

    internal void SetId(int id)
    {
        Id = id;
    }
}

public class OptionResult
{
    public int Id { get; private set; }
    public string OptionText { get; private set; }
    public int VoteCount { get; private set; }

    public OptionResult(string optionText, int voteCount)
    {
        OptionText = optionText;
        VoteCount = voteCount;
    }

    internal OptionResult(int id, string optionText, int voteCount)
    {
        Id = id;
        OptionText = optionText;
        VoteCount = voteCount;
    }

    internal void SetId(int id)
    {
        Id = id;
    }
}
