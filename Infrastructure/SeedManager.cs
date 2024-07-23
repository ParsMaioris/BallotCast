namespace BallotCast.Infrastructure;

public class SeedManager
{
    private readonly VoterSeedService _voterSeedService;
    private readonly ReferendumSeedService _referendumSeedService;
    private readonly VoteSeedService _voteSeedService;

    public SeedManager(VoterSeedService voterSeedService, ReferendumSeedService referendumSeedService, VoteSeedService voteSeedService)
    {
        _voterSeedService = voterSeedService;
        _referendumSeedService = referendumSeedService;
        _voteSeedService = voteSeedService;
    }

    public void SeedData()
    {
        _voterSeedService.SeedVoters();
        _referendumSeedService.SeedReferendums();
        _voteSeedService.SeedVotes();
    }
}
