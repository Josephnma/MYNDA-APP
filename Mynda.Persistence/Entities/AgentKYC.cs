using System.ComponentModel.DataAnnotations.Schema;

namespace Mynda.Persistence.Entities
{
    public class AgentKYC
    {
        [ForeignKey("Users")]
        public string UserId { get; set; }
        public User Users { get; set; }

        public string? PhotoUrl { get; set; }
        
        public string ShareHolderName { get; set; }
        
        public string Email { get; set; }
        
        public string Address { get; set; }
        
        public string Shares { get; set; }
        
        public string Role { get; set; }
        
        public string NINUrl { get; set; }
    }
}
