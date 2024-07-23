namespace BallotCast.Domain;

public class ReferendumResult
{
    public int Id { get; private set; }
    public DateTime ResultDate { get; private set; }
    public int YesCount { get; private set; }
    public int NoCount { get; private set; }

    public ReferendumResult(int id, int yesCount, int noCount)
    {
        Id = id;
        YesCount = yesCount;
        NoCount = noCount;
        ResultDate = DateTime.UtcNow;
    }

    public void UpdateResult(int yesCount, int noCount)
    {
        YesCount = yesCount;
        NoCount = noCount;
    }
}