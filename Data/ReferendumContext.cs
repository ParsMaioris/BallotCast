using Microsoft.EntityFrameworkCore;

namespace BallotCast.Data
{
    public class ReferendumContext : DbContext
    {
        public DbSet<Referendum> Referendums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=referendum.db");
        }
    }

    public class Referendum
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public bool Vote { get; set; }
    }
}