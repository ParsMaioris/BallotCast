namespace BallotCast.Application;

public class VoteRequestDto
{
    public int Id { get; set; }
    public int VoterId { get; set; }
    public int ReferendumId { get; set; }
    public bool IsYes { get; set; }
}