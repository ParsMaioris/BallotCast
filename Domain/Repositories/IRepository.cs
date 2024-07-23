namespace BallotCast.Domain;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
}

public interface IVoterRepository : IRepository<Voter> { }
public interface IReferendumRepository : IRepository<Referendum> { }
public interface IVoteRepository : IRepository<Vote> { }
public interface IVoterReferendumRepository : IRepository<VoterReferendum> { }
public interface IParagraphRepository : IRepository<Paragraph> { }
public interface IReferendumResultRepository : IRepository<ReferendumResult> { }