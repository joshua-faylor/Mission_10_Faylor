using Microsoft.EntityFrameworkCore;
using BowlingLeagueAPI.Models;

namespace BowlingLeagueAPI.Data
{
    /// <summary>
    /// Entity Framework Core DbContext for the Bowling League database.
    /// Handles database connection and entity configuration.
    /// </summary>
    public class BowlingContext : DbContext
    {
        // Constructor that accepts DbContext options
        public BowlingContext(DbContextOptions<BowlingContext> options) : base(options)
        {
        }

        // DbSet for Bowlers table
        public DbSet<Bowler> Bowlers { get; set; }

        // DbSet for Teams table
        public DbSet<Team> Teams { get; set; }

        /// <summary>
        /// Configures the database entity relationships and constraints.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the Bowler entity to map to the Bowlers table
            modelBuilder.Entity<Bowler>()
                .ToTable("Bowlers")
                .HasKey(b => b.BowlerID);

            // Configure the Team entity to map to the Teams table
            modelBuilder.Entity<Team>()
                .ToTable("Teams")
                .HasKey(t => t.TeamID);
        }
    }
}
