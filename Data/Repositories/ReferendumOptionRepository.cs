using BallotCast.Domain;
using Microsoft.EntityFrameworkCore;

public class ReferendumOptionRepository : Repository<ReferendumOption>, IReferendumOptionRepository
{
    public ReferendumOptionRepository(ReferendumContext context) : base(context) { }

    public new IEnumerable<BallotCast.Domain.ReferendumOption> GetAll()
    {
        return _dbSet
            .Include(o => o.Referendum)
            .ToList()
            .Select(o => o.ToDomainEntity());
    }

    public new BallotCast.Domain.ReferendumOption GetById(int id)
    {
        var dataEntity = _dbSet
            .Include(o => o.Referendum)
            .FirstOrDefault(o => o.Id == id);
        return dataEntity?.ToDomainEntity();
    }

    public new void Add(BallotCast.Domain.ReferendumOption option)
    {
        var dataEntity = option.ToDataEntity();
        _dbSet.Add(dataEntity);
        _context.SaveChanges();
        option.SetId(dataEntity.Id);
    }

    public new void Update(BallotCast.Domain.ReferendumOption option)
    {
        var dataEntity = option.ToDataEntity();
        _dbSet.Update(dataEntity);
        _context.SaveChanges();
    }

    public new void Delete(int id)
    {
        var dataEntity = _dbSet.Find(id);
        if (dataEntity != null)
        {
            _dbSet.Remove(dataEntity);
            _context.SaveChanges();
        }
    }
}