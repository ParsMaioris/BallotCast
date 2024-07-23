namespace BallotCast.Domain;

public class AddVoterCommand
{
    private readonly IVoterRepository _voterRepository;

    public AddVoterCommand(IVoterRepository voterRepository)
    {
        _voterRepository = voterRepository;
    }

    public async Task ExecuteAsync(Voter voter)
    {
        await _voterRepository.AddAsync(voter);
    }
}