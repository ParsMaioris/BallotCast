using Microsoft.EntityFrameworkCore;

namespace BallotCast.Infrastructure;

public class ReferendumContext : DbContext
{
    public ReferendumContext(DbContextOptions<ReferendumContext> options)
        : base(options)
    {
    }

    public DbSet<ReferendumEntity> Referendums { get; set; }
    public DbSet<ParagraphEntity> Paragraphs { get; set; }
    public DbSet<ReferendumResultEntity> ReferendumResults { get; set; }
    public DbSet<VoterEntity> Voters { get; set; }
    public DbSet<VoteEntity> Votes { get; set; }
    public DbSet<VoterReferendumEntity> VoterReferendums { get; set; }

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

        modelBuilder.Entity<VoterReferendumEntity>()
            .HasKey(vr => new { vr.VoterId, vr.ReferendumId });

        modelBuilder.Entity<VoterReferendumEntity>()
            .HasOne(vr => vr.Voter)
            .WithMany(v => v.EligibleReferendums)
            .HasForeignKey(vr => vr.VoterId);

        modelBuilder.Entity<VoterReferendumEntity>()
            .HasOne(vr => vr.Referendum)
            .WithMany(r => r.EligibleVoters)
            .HasForeignKey(vr => vr.ReferendumId);

        modelBuilder.Entity<ReferendumEntity>()
            .HasOne(r => r.Result)
            .WithOne(rr => rr.Referendum)
            .HasForeignKey<ReferendumResultEntity>(rr => rr.ReferendumId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}