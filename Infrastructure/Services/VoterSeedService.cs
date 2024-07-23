namespace BallotCast.Infrastructure;

public class VoterSeedService
{
    private readonly ReferendumContext _context;

    public VoterSeedService(ReferendumContext context)
    {
        _context = context;
    }

    public void SeedVoters()
    {
        if (_context.Voters.Any()) return;

        var voters = new List<VoterEntity>
            {
                new VoterEntity { Id = 1, Name = "Alice Smith", Email = "alice@example.com" },
                new VoterEntity { Id = 2, Name = "Bob Johnson", Email = "bob@example.com" },
                new VoterEntity { Id = 3, Name = "Charlie Brown", Email = "charlie@example.com" },
                new VoterEntity { Id = 4, Name = "David Lee", Email = "david@example.com" },
                new VoterEntity { Id = 5, Name = "Eve Wilson", Email = "eve@example.com" },
                new VoterEntity { Id = 6, Name = "Frank White", Email = "frank@example.com" },
                new VoterEntity { Id = 7, Name = "Grace Davis", Email = "grace@example.com" },
                new VoterEntity { Id = 8, Name = "Henry Clark", Email = "henry@example.com" },
                new VoterEntity { Id = 9, Name = "Ivy Thomas", Email = "ivy@example.com" },
            };

        _context.Voters.AddRange(voters);
        _context.SaveChanges();
    }
}