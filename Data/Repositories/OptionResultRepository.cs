using Microsoft.EntityFrameworkCore;
using BallotCast.Domain;

public class OptionResultRepository : Repository<OptionResult>, IOptionResultRepository
{
    public OptionResultRepository(ReferendumContext context) : base(context) { }

    public new IEnumerable<BallotCast.Domain.OptionResult> GetAll()
    {
        return _dbSet
            .Include(or => or.ReferendumResult)
            .ToList()
            .Select(or => or.ToDomainEntity());
    }

    public new BallotCast.Domain.OptionResult GetById(int id)
    {
        var dataEntity = _dbSet
            .Include(or => or.ReferendumResult)
            .FirstOrDefault(or => or.Id == id);
        return dataEntity?.ToDomainEntity();
    }

    public new void Add(BallotCast.Domain.OptionResult optionResult)
    {
        var dataEntity = optionResult.ToDataEntity();
        _dbSet.Add(dataEntity);
        _context.SaveChanges();
        optionResult.SetId(dataEntity.Id);
    }

    public new void Update(BallotCast.Domain.OptionResult optionResult)
    {
        var dataEntity = optionResult.ToDataEntity();
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