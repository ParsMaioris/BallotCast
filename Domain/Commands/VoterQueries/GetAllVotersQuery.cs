namespace BallotCast.Domain;

public class GetAllVotersQuery
{
    private readonly IVoterRepository _voterRepository;

    public GetAllVotersQuery(IVoterRepository voterRepository)
    {
        _voterRepository = voterRepository;
    }

    public async Task<IEnumerable<Voter>> ExecuteAsync()
    {
        return await _voterRepository.GetAllAsync();
    }
}