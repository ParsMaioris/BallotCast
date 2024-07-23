namespace BallotCast.Infrastructure;

public class ReferendumResultEntity
{
    public int Id { get; set; }

    public int ReferendumId { get; set; }
    public virtual ReferendumEntity Referendum { get; set; }

    public int YesCount { get; set; }
    public int NoCount { get; set; }
    public DateTime ResultDate { get; set; }
}