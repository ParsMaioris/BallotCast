namespace BallotCast.Domain;

public class DeleteVoterCommand
{
    private readonly IVoterRepository _voterRepository;

    public DeleteVoterCommand(IVoterRepository voterRepository)
    {
        _voterRepository = voterRepository;
    }

    public async Task ExecuteAsync(int voterId)
    {
        await _voterRepository.DeleteAsync(voterId);
    }
}