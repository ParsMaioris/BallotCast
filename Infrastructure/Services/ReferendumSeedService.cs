namespace BallotCast.Infrastructure;

public class ReferendumSeedService
{
    private readonly ReferendumContext _context;

    public ReferendumSeedService(ReferendumContext context)
    {
        _context = context;
    }

    public void SeedReferendums()
    {
        if (_context.Referendums.Any()) return;

        var referendums = new List<ReferendumEntity>
            {
                new ReferendumEntity { Id = 1, Title = "New Park Initiative", Question = "Should the city build a new park in the downtown area?", CreatedDate = DateTime.UtcNow, Status = ReferendumStatusEntity.Pending },
                new ReferendumEntity { Id = 2, Title = "Public Transportation Expansion", Question = "Should the city invest in expanding public transportation?", CreatedDate = DateTime.UtcNow, Status = ReferendumStatusEntity.Pending },
                new ReferendumEntity { Id = 3, Title = "School Funding Increase", Question = "Should the city increase funding for public schools?", CreatedDate = DateTime.UtcNow, Status = ReferendumStatusEntity.Pending }
            };

        _context.Referendums.AddRange(referendums);
        _context.SaveChanges();
    }
}
