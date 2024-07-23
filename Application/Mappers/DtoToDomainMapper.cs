using BallotCast.Domain;

namespace BallotCast.Application;

public static class DtoToDomainMapper
{
    public static Voter MapToDomain(VoterRequestDto voterRequestDto)
    {
        if (voterRequestDto == null) return null;

        return new Voter(
            voterRequestDto.Id,
            voterRequestDto.Name,
            voterRequestDto.Email
        );
    }

    public static Vote MapToDomain(VoteRequestDto voteRequestDto)
    {
        if (voteRequestDto == null) return null;

        return new Vote(
            voteRequestDto.Id,
            new Voter(voteRequestDto.VoterId, "Dummy Name", "dummy@example.com"), // Assume we load the actual Voter elsewhere
            new Referendum(voteRequestDto.ReferendumId, "Dummy Title", "Dummy Question"), // Assume we load the actual Referendum elsewhere
            voteRequestDto.IsYes
        );
    }

    public static Referendum MapToDomain(ReferendumRequestDto referendumRequestDto)
    {
        if (referendumRequestDto == null) return null;

        return new Referendum(
            referendumRequestDto.Id,
            referendumRequestDto.Title,
            referendumRequestDto.Question
        );
    }

    // Add more mappings as needed...
}