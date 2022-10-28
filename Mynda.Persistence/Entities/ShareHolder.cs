using System.ComponentModel.DataAnnotations.Schema;

namespace Mynda.Persistence.Entities;

public class ShareHolder
{
    public int Id { get; set; }

    [ForeignKey("Users")]
    public string UserId { get; set; }
    public User Users { get; set; }
    
    
    public string? ShareHolderName { get; set; }
    
    public string? Email { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    public string? ProfileImageUrl { get; set; }
    
    public string? Address { get; set; }
    public string? Shares { get; set; }
    
    public string? Role { get; set; }
    
    public string? NINImageUrl { get; set; }
}