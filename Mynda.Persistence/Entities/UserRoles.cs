using Microsoft.AspNetCore.Identity;

namespace Mynda.Persistence.Entities
{
    public class UserRoles : IdentityUserRole<int>
    {
        public Myndas? Mynda { get; set; }
        public AppRole? Role { get; set; }
    }
}
