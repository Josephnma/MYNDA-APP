using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mynda.Persistence.Entities;

namespace Mynda.Persistence.DbContext
{
    public class MyndaDbContext : IdentityDbContext<User>
    {
        public MyndaDbContext(DbContextOptions<MyndaDbContext> options) : base(options)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserRoles());
        }

        public DbSet<Myndas> Myndas { get; set; }
        public DbSet<Agents> Agents { get; set; }
    }
}
