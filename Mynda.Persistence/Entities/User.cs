using Microsoft.AspNetCore.Identity;


namespace Mynda.Persistence.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }     
    }
}
