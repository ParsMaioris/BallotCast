using BallotCast.Domain;

namespace BallotCast.Application;

public class VoterQueryService
{
    private readonly GetAllVotersQuery _getAllVotersQuery;
    private readonly GetVoterByIdQuery _getVoterByIdQuery;
    private readonly GetVoterInsightsQuery _getVoterInsightsQuery;

    public VoterQueryService(
        GetAllVotersQuery getAllVotersQuery,
        GetVoterByIdQuery getVoterByIdQuery,
        GetVoterInsightsQuery getVoterInsightsQuery)
    {
        _getAllVotersQuery = getAllVotersQuery;
        _getVoterByIdQuery = getVoterByIdQuery;
        _getVoterInsightsQuery = getVoterInsightsQuery;
    }

    public async Task<IEnumerable<VoterDto>> GetAllVotersAsync()
    {
        var voters = await _getAllVotersQuery.ExecuteAsync();
        return DomainToDtoMapper.MapToDto(voters);
    }

    public async Task<VoterDto> GetVoterByIdAsync(int id)
    {
        var voter = await _getVoterByIdQuery.ExecuteAsync(id);
        return DomainToDtoMapper.MapToDto(voter);
    }

    public async Task<VoterInsightsDto> GetVoterInsightsAsync(int voterId)
    {
        var insights = await _getVoterInsightsQuery.ExecuteAsync(voterId);
        return DomainToDtoMapper.MapToDto(insights);
    }
}