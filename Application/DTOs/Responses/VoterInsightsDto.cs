namespace BallotCast.Application;

public class VoterInsightsDto
{
    public VoterDto Voter { get; set; }
    public int TotalVotes { get; set; }
    public int YesVotes { get; set; }
    public int NoVotes { get; set; }
    public List<VoteDto> VoteHistory { get; set; }
}