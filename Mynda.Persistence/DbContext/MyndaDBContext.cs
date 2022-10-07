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

        public DbSet<Myndas> Myndas { get; set; }

    }
}
