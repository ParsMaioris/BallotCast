namespace BallotCast.Infrastructure;

public class VoteSeedService
{
    private readonly ReferendumContext _context;

    public VoteSeedService(ReferendumContext context)
    {
        _context = context;
    }

    public void SeedVotes()
    {
        if (_context.Votes.Any()) return;

        var votes = new List<VoteEntity>
            {
                new VoteEntity { Id = 1, VoterId = 1, ReferendumId = 1, IsYes = true, VoteDate = DateTime.UtcNow },
                new VoteEntity { Id = 2, VoterId = 2, ReferendumId = 1, IsYes = false, VoteDate = DateTime.UtcNow },
                new VoteEntity { Id = 3, VoterId = 3, ReferendumId = 1, IsYes = true, VoteDate = DateTime.UtcNow },
                new VoteEntity { Id = 4, VoterId = 4, ReferendumId = 1, IsYes = false, VoteDate = DateTime.UtcNow },
                new VoteEntity { Id = 5, VoterId = 5, ReferendumId = 1, IsYes = true, VoteDate = DateTime.UtcNow },
                new VoteEntity { Id = 6, VoterId = 6, ReferendumId = 1, IsYes = false, VoteDate = DateTime.UtcNow },
                new VoteEntity { Id = 7, VoterId = 7, ReferendumId = 1, IsYes = true, VoteDate = DateTime.UtcNow }
            };

        _context.Votes.AddRange(votes);
        _context.SaveChanges();
    }
}