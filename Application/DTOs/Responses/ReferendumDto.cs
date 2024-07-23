namespace BallotCast.Application;

public class ReferendumDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Question { get; set; }
    public ReferendumResultDto Result { get; set; }
}