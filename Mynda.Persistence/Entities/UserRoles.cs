using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mynda.Persistence.Entities
{
    public class UserRoles : IEntityTypeConfiguration<IdentityRole>
    {
        public Myndas? Mynda { get; set; }
        public AppRole? Role { get; set; }

        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData
            (
                new IdentityRole 
                { 
                    Name = "Mynda",
                    NormalizedName = "MYNDA"                
                },
                new IdentityRole 
                { 
                    Name = "Employer",
                    NormalizedName = "EMPLOYER"                
                },
                new IdentityRole 
                { 
                    Name = "Agent",
                    NormalizedName = "AGENT"                
                },
                new IdentityRole 
                { 
                    Name = "Hospital",
                    NormalizedName = "HOSPITAL"                
                }
           );
        }
    }
}
