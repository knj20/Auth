using Auth.Data.Enteties;
using Microsoft.EntityFrameworkCore;


namespace Auth.Data.DbContexts
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options)
        : base(options)
        {
        }

        public DbSet<Plant> Plants { get; set; }

        public DbSet<Family> Families { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seed Initial data.
            base.OnModelCreating(modelBuilder);
        } 
    }
}
