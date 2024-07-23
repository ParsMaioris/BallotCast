namespace BallotCast.Application;

public class VoterDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public List<VoteDto> CastVotes { get; set; } = new List<VoteDto>();
}