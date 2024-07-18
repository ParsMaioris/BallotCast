using BallotCast.Domain;
using Microsoft.EntityFrameworkCore;

public class ParagraphRepository : Repository<Paragraph>, IParagraphRepository
{
    public ParagraphRepository(ReferendumContext context) : base(context) { }

    public new IEnumerable<BallotCast.Domain.Paragraph> GetAll()
    {
        return _dbSet
            .Include(p => p.Referendum)
            .ToList()
            .Select(p => p.ToDomainEntity());
    }

    public new BallotCast.Domain.Paragraph GetById(int id)
    {
        var dataEntity = _dbSet
            .Include(p => p.Referendum)
            .FirstOrDefault(p => p.Id == id);
        return dataEntity?.ToDomainEntity();
    }

    public new void Add(BallotCast.Domain.Paragraph paragraph)
    {
        var dataEntity = paragraph.ToDataEntity();
        _dbSet.Add(dataEntity);
        _context.SaveChanges();
        paragraph.SetId(dataEntity.Id);
    }

    public new void Update(BallotCast.Domain.Paragraph paragraph)
    {
        var dataEntity = paragraph.ToDataEntity();
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