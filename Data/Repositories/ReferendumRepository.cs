using BallotCast.Domain;
using Microsoft.EntityFrameworkCore;

public class ReferendumRepository : Repository<Referendum>, IReferendumRepository
{
    public ReferendumRepository(ReferendumContext context) : base(context) { }

    public new IEnumerable<BallotCast.Domain.Referendum> GetAll()
    {
        return _dbSet
            .Include(r => r.Paragraphs)
            .Include(r => r.Options)
            .Include(r => r.Result).ThenInclude(r => r.OptionResults)
            .ToList()
            .Select(r => r.ToDomainEntity());
    }

    public new BallotCast.Domain.Referendum GetById(int id)
    {
        var dataEntity = _dbSet
            .Include(r => r.Paragraphs)
            .Include(r => r.Options)
            .Include(r => r.Result).ThenInclude(r => r.OptionResults)
            .FirstOrDefault(r => r.Id == id);
        return dataEntity?.ToDomainEntity();
    }

    public new void Add(BallotCast.Domain.Referendum referendum)
    {
        var dataEntity = referendum.ToDataEntity();
        _dbSet.Add(dataEntity);
        _context.SaveChanges();
        referendum.SetId(dataEntity.Id);
    }

    public new void Update(BallotCast.Domain.Referendum referendum)
    {
        var dataEntity = referendum.ToDataEntity();
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