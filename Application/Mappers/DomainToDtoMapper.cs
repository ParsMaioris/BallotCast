using BallotCast.Domain;

namespace BallotCast.Application;

public static class DomainToDtoMapper
{
    public static VoterDto MapToDto(Voter voter)
    {
        if (voter == null) return null;

        return new VoterDto
        {
            Id = voter.Id,
            Name = voter.Name,
            Email = voter.Email,
            CastVotes = voter.CastVotes.Select(MapToDto).ToList()
        };
    }

    public static VoteDto MapToDto(Vote vote)
    {
        if (vote == null) return null;

        return new VoteDto
        {
            Id = vote.Id,
            IsYes = vote.IsYes,
            VoteDate = vote.VoteDate,
            Referendum = MapToDto(vote.Referendum)
        };
    }

    public static VoterInsightsDto MapToDto(VoterInsights insights)
    {
        if (insights == null) return null;

        return new VoterInsightsDto
        {
            Voter = MapToDto(insights.Voter),
            TotalVotes = insights.TotalVotes,
            YesVotes = insights.YesVotes,
            NoVotes = insights.NoVotes,
            VoteHistory = insights.VoteHistory.Select(MapToDto).ToList()
        };
    }

    public static ReferendumDto MapToDto(Referendum referendum)
    {
        if (referendum == null) return null;

        return new ReferendumDto
        {
            Id = referendum.Id,
            Title = referendum.Title,
            Question = referendum.Question,
            Result = MapToDto(referendum.Result)
        };
    }

    public static ParagraphDto MapToDto(Paragraph paragraph)
    {
        if (paragraph == null) return null;

        return new ParagraphDto
        {
            Id = paragraph.Id,
            Content = paragraph.Content
        };
    }

    public static ReferendumResultDto MapToDto(ReferendumResult result)
    {
        if (result == null) return null;

        return new ReferendumResultDto
        {
            Id = result.Id,
            ResultDate = result.ResultDate,
            YesCount = result.YesCount,
            NoCount = result.NoCount
        };
    }

    public static IEnumerable<VoterDto> MapToDto(IEnumerable<Voter> voters) => voters.Select(MapToDto);
    public static IEnumerable<ReferendumDto> MapToDto(IEnumerable<Referendum> referendums) => referendums.Select(MapToDto);
    public static IEnumerable<VoteDto> MapToDto(IEnumerable<Vote> votes) => votes.Select(MapToDto);
    public static IEnumerable<ParagraphDto> MapToDto(IEnumerable<Paragraph> paragraphs) => paragraphs.Select(MapToDto);
    public static IEnumerable<ReferendumResultDto> MapToDto(IEnumerable<ReferendumResult> results) => results.Select(MapToDto);
}
