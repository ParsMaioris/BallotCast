namespace BallotCast.Application;

public class ReferendumResultDto
{
    public int Id { get; set; }
    public DateTime ResultDate { get; set; }
    public int YesCount { get; set; }
    public int NoCount { get; set; }
}