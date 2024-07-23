namespace BallotCast.Application;

public class VoteDto
{
    public int Id { get; set; }
    public bool IsYes { get; set; }
    public DateTime VoteDate { get; set; }
    public ReferendumDto Referendum { get; set; }
}