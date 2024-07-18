public static class EntityMapper
{
    public static BallotCast.Domain.Referendum ToDomainEntity(this Referendum dataEntity)
    {
        if (dataEntity == null) return null;

        var domainEntity = new BallotCast.Domain.Referendum(
            dataEntity.Id,
            dataEntity.Title,
            dataEntity.Question,
            dataEntity.CreatedDate,
            dataEntity.LastModifiedDate,
            (BallotCast.Domain.ReferendumStatus)dataEntity.Status
        );

        if (dataEntity.Paragraphs != null)
        {
            foreach (var paragraph in dataEntity.Paragraphs)
            {
                domainEntity.AddParagraph(paragraph.Content);
            }
        }

        if (dataEntity.Options != null)
        {
            foreach (var option in dataEntity.Options)
            {
                domainEntity.AddOption(option.OptionText);
            }
        }

        if (dataEntity.Result != null)
        {
            domainEntity.SetResult(dataEntity.Result.ToDomainEntity());
        }

        return domainEntity;
    }

    public static Referendum ToDataEntity(this BallotCast.Domain.Referendum domainEntity)
    {
        if (domainEntity == null) return null;

        var dataEntity = new Referendum
        {
            Id = domainEntity.Id,
            Title = domainEntity.Title,
            Question = domainEntity.Question,
            CreatedDate = domainEntity.CreatedDate,
            LastModifiedDate = domainEntity.LastModifiedDate,
            Status = (ReferendumStatus)domainEntity.Status,
            ResultId = domainEntity.Result?.Id
        };

        if (domainEntity.Paragraphs != null)
        {
            dataEntity.Paragraphs = domainEntity.Paragraphs.Select(p => new Paragraph { Content = p.Content }).ToList();
        }

        if (domainEntity.Options != null)
        {
            dataEntity.Options = domainEntity.Options.Select(o => new ReferendumOption { OptionText = o.OptionText }).ToList();
        }

        return dataEntity;
    }

    public static BallotCast.Domain.Paragraph ToDomainEntity(this Paragraph dataEntity)
    {
        if (dataEntity == null) return null;

        return new BallotCast.Domain.Paragraph(
            dataEntity.Id,
            dataEntity.Content,
            dataEntity.ReferendumId,
            dataEntity.Referendum.ToDomainEntity()
        );
    }

    public static Paragraph ToDataEntity(this BallotCast.Domain.Paragraph domainEntity)
    {
        if (domainEntity == null) return null;

        return new Paragraph
        {
            Id = domainEntity.Id,
            Content = domainEntity.Content,
            ReferendumId = domainEntity.ReferendumId
        };
    }

    public static BallotCast.Domain.ReferendumOption ToDomainEntity(this ReferendumOption dataEntity)
    {
        if (dataEntity == null) return null;

        return new BallotCast.Domain.ReferendumOption(
            dataEntity.Id,
            dataEntity.OptionText,
            dataEntity.VoteCount,
            dataEntity.ReferendumId,
            dataEntity.Referendum.ToDomainEntity()
        );
    }

    public static ReferendumOption ToDataEntity(this BallotCast.Domain.ReferendumOption domainEntity)
    {
        if (domainEntity == null) return null;

        return new ReferendumOption
        {
            Id = domainEntity.Id,
            OptionText = domainEntity.OptionText,
            VoteCount = domainEntity.VoteCount,
            ReferendumId = domainEntity.ReferendumId
        };
    }

    public static BallotCast.Domain.ReferendumResult ToDomainEntity(this ReferendumResult dataEntity)
    {
        if (dataEntity == null) return null;

        var optionResults = dataEntity.OptionResults?.Select(or => or.ToDomainEntity()).ToList() ?? new List<BallotCast.Domain.OptionResult>();

        return new BallotCast.Domain.ReferendumResult(
            dataEntity.Id,
            dataEntity.ResultDate,
            optionResults
        );
    }

    public static ReferendumResult ToDataEntity(this BallotCast.Domain.ReferendumResult domainEntity)
    {
        if (domainEntity == null) return null;

        var optionResults = domainEntity.OptionResults?.Select(or => or.ToDataEntity()).ToList() ?? new List<OptionResult>();

        return new ReferendumResult
        {
            Id = domainEntity.Id,
            ResultDate = domainEntity.ResultDate,
            OptionResults = optionResults
        };
    }

    public static BallotCast.Domain.OptionResult ToDomainEntity(this OptionResult dataEntity)
    {
        if (dataEntity == null) return null;

        return new BallotCast.Domain.OptionResult(
            dataEntity.Id,
            dataEntity.OptionText,
            dataEntity.VoteCount
        );
    }

    public static OptionResult ToDataEntity(this BallotCast.Domain.OptionResult domainEntity)
    {
        if (domainEntity == null) return null;

        return new OptionResult
        {
            Id = domainEntity.Id,
            OptionText = domainEntity.OptionText,
            VoteCount = domainEntity.VoteCount
        };
    }
}