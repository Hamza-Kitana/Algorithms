using Algo22.Models;
using Microsoft.EntityFrameworkCore;
using Algo22.Models;
namespace Algo22.Data
{

    public class AlgoContext : DbContext
    {
        public AlgoContext(DbContextOptions<AlgoContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}

