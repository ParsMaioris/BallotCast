using BallotCast.Domain;
using Microsoft.EntityFrameworkCore;

public class ReferendumResultRepository : Repository<ReferendumResult>, IReferendumResultRepository
{
    public ReferendumResultRepository(ReferendumContext context) : base(context) { }

    public new IEnumerable<BallotCast.Domain.ReferendumResult> GetAll()
    {
        return _dbSet
            .Include(r => r.OptionResults)
            .ToList()
            .Select(r => r.ToDomainEntity());
    }

    public new BallotCast.Domain.ReferendumResult GetById(int id)
    {
        var dataEntity = _dbSet
            .Include(r => r.OptionResults)
            .FirstOrDefault(r => r.Id == id);
        return dataEntity?.ToDomainEntity();
    }

    public new void Add(BallotCast.Domain.ReferendumResult result)
    {
        var dataEntity = result.ToDataEntity();
        _dbSet.Add(dataEntity);
        _context.SaveChanges();
        result.SetId(dataEntity.Id);
    }

    public new void Update(BallotCast.Domain.ReferendumResult result)
    {
        var dataEntity = result.ToDataEntity();
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