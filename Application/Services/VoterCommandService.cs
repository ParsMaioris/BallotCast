using BallotCast.Domain;

namespace BallotCast.Application;

public class VoterCommandService
{
    private readonly AddVoterCommand _addVoterCommand;
    private readonly UpdateVoterCommand _updateVoterCommand;
    private readonly DeleteVoterCommand _deleteVoterCommand;

    public VoterCommandService(
        AddVoterCommand addVoterCommand,
        UpdateVoterCommand updateVoterCommand,
        DeleteVoterCommand deleteVoterCommand)
    {
        _addVoterCommand = addVoterCommand;
        _updateVoterCommand = updateVoterCommand;
        _deleteVoterCommand = deleteVoterCommand;
    }

    public async Task AddVoterAsync(VoterRequestDto voterRequestDto)
    {
        var voter = DtoToDomainMapper.MapToDomain(voterRequestDto);
        await _addVoterCommand.ExecuteAsync(voter);
    }

    public async Task UpdateVoterAsync(VoterRequestDto voterRequestDto)
    {
        var voter = DtoToDomainMapper.MapToDomain(voterRequestDto);
        await _updateVoterCommand.ExecuteAsync(voter);
    }

    public async Task DeleteVoterAsync(int id)
    {
        await _deleteVoterCommand.ExecuteAsync(id);
    }
}