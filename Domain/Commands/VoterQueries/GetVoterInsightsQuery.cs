namespace BallotCast.Domain;

public class GetVoterInsightsQuery
{
    private readonly IVoterRepository _voterRepository;
    private readonly IVoteRepository _voteRepository;

    public GetVoterInsightsQuery(IVoterRepository voterRepository, IVoteRepository voteRepository)
    {
        _voterRepository = voterRepository;
        _voteRepository = voteRepository;
    }

    public async Task<VoterInsights> ExecuteAsync(int voterId)
    {
        var voter = await _voterRepository.GetByIdAsync(voterId);
        if (voter == null) return null;

        var votes = (await _voteRepository.GetAllAsync()).Where(v => v.VoterId == voterId).ToList();
        return new VoterInsights(voter, votes);
    }
}