using Carribean.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carribean.API.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Seat> Seats { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
        }
    }
}
