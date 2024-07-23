namespace BallotCast.Domain;

public class UpdateVoterCommand
{
    private readonly IVoterRepository _voterRepository;

    public UpdateVoterCommand(IVoterRepository voterRepository)
    {
        _voterRepository = voterRepository;
    }

    public async Task ExecuteAsync(Voter voter)
    {
        await _voterRepository.UpdateAsync(voter);
    }
}