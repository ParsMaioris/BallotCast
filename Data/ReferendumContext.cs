using Microsoft.EntityFrameworkCore;

public class ReferendumContext : DbContext
{
    public ReferendumContext(DbContextOptions<ReferendumContext> options)
        : base(options)
    {
    }

    public DbSet<Referendum> Referendums { get; set; }
    public DbSet<Paragraph> Paragraphs { get; set; }
    public DbSet<ReferendumOption> ReferendumOptions { get; set; }
    public DbSet<ReferendumResult> ReferendumResults { get; set; }
    public DbSet<OptionResult> OptionResults { get; set; }

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