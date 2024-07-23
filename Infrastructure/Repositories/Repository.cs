using BallotCast.Domain;
using Microsoft.EntityFrameworkCore;

namespace BallotCast.Infrastructure;

public class Repository<TDomain, TEntity> : IRepository<TDomain>
        where TDomain : class
        where TEntity : class
{
    protected readonly ReferendumContext _context;
    protected readonly DbSet<TEntity> _dbSet;

    public Repository(ReferendumContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    public virtual async Task<IEnumerable<TDomain>> GetAllAsync()
    {
        var entities = await _dbSet.ToListAsync();
        return entities.Select(e => EntityMapper.MapToDomain(e as dynamic) as TDomain);
    }

    public virtual async Task<TDomain> GetByIdAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        return EntityMapper.MapToDomain(entity as dynamic) as TDomain;
    }

    public virtual async Task AddAsync(TDomain domainEntity)
    {
        var entity = EntityMapper.MapToInfrastructure(domainEntity as dynamic) as TEntity;
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public virtual async Task UpdateAsync(TDomain domainEntity)
    {
        var entity = EntityMapper.MapToInfrastructure(domainEntity as dynamic) as TEntity;
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

    public virtual async Task DeleteAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}

public class VoterRepository : Repository<Voter, VoterEntity>, IVoterRepository
{
    public VoterRepository(ReferendumContext context) : base(context) { }
}

public class ReferendumRepository : Repository<Referendum, ReferendumEntity>, IReferendumRepository
{
    public ReferendumRepository(ReferendumContext context) : base(context) { }
}

public class VoteRepository : Repository<Vote, VoteEntity>, IVoteRepository
{
    public VoteRepository(ReferendumContext context) : base(context) { }
}

public class VoterReferendumRepository : Repository<VoterReferendum, VoterReferendumEntity>, IVoterReferendumRepository
{
    public VoterReferendumRepository(ReferendumContext context) : base(context) { }
}

public class ParagraphRepository : Repository<Paragraph, ParagraphEntity>, IParagraphRepository
{
    public ParagraphRepository(ReferendumContext context) : base(context) { }
}

public class ReferendumResultRepository : Repository<ReferendumResult, ReferendumResultEntity>, IReferendumResultRepository
{
    public ReferendumResultRepository(ReferendumContext context) : base(context) { }
}