using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class ReferendumContext : DbContext
{
    public ReferendumContext(DbContextOptions<ReferendumContext> options)
        : base(options)
    {
    }

    public DbSet<Referendum> Referendums { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
                .UseSqlite("Data Source=referendum.db")
                .UseLazyLoadingProxies();
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Seed();
    }
}

public class Referendum
{
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Title { get; set; }

    [Required]
    [MaxLength(1000)]
    public string Question { get; set; }

    public virtual List<Paragraph> Paragraphs { get; set; } = new List<Paragraph>();

    public virtual List<ReferendumOption> Options { get; set; } = new List<ReferendumOption>();

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? LastModifiedDate { get; set; }
    public ReferendumStatus Status { get; set; } = ReferendumStatus.Pending;

    public virtual ReferendumResult Result { get; set; }
    public int? ResultId { get; set; }
}

public class Paragraph
{
    public int Id { get; set; }
    [Required]
    [MaxLength(500)]
    public string Content { get; set; }

    public int ReferendumId { get; set; }
    public virtual Referendum Referendum { get; set; }
}

public class ReferendumOption
{
    public int Id { get; set; }
    [Required]
    [MaxLength(200)]
    public string OptionText { get; set; }
    public int VoteCount { get; set; }

    public int ReferendumId { get; set; }
    public virtual Referendum Referendum { get; set; }
}

public class ReferendumResult
{
    public int Id { get; set; }
    public DateTime ResultDate { get; set; } = DateTime.UtcNow;
    public virtual List<OptionResult> OptionResults { get; set; } = new List<OptionResult>();
}

public class OptionResult
{
    public int Id { get; set; }
    public string OptionText { get; set; }
    public int VoteCount { get; set; }

    public int ReferendumResultId { get; set; }
    public virtual ReferendumResult ReferendumResult { get; set; }
}

public enum ReferendumStatus
{
    Pending,
    Active,
    Closed
}