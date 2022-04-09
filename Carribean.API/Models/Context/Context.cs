using Carribean.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carribean.API.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> contextOptions) : base(contextOptions) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Tickets)
                .WithOne(t => t.User);

            base.OnModelCreating(modelBuilder);
        }
    }
}
