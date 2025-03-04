using Microsoft.EntityFrameworkCore;

namespace BenchmarkBulkInsert.Db
{
    class BenchmarkDbContext : DbContext
    {
        public DbSet<Metar> Metars { get; set; }
        public DbSet<MetarWithUniqueConstraint> MetarsWithUniqueConstraint { get; set; }

        public DbSet<TmpMetar> TmpMetars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=benchmark.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure unique key constraint for MetarWithUniqueConstraint
            modelBuilder.Entity<MetarWithUniqueConstraint>()
                .HasIndex(m => new { m.Station, m.LastChange })
                .IsUnique();
        }
    }
}
