namespace BallotCast.Domain;

public class GetVoterByIdQuery
{
    private readonly IVoterRepository _voterRepository;

    public GetVoterByIdQuery(IVoterRepository voterRepository)
    {
        _voterRepository = voterRepository;
    }

    public async Task<Voter> ExecuteAsync(int voterId)
    {
        return await _voterRepository.GetByIdAsync(voterId);
    }
}