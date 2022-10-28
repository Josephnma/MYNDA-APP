using System.ComponentModel.DataAnnotations.Schema;
using Mynda.Persistence.Entities;

namespace Mynda.Shared.DTOs;

public class ShareHolderDTO
{
    
    public string? ShareHolderName { get; set; }
    
    public string? Email { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    public string? ProfileImageUrl { get; set; }
    
    public string? Address { get; set; }
    public string? Shares { get; set; }
    
    public string? Role { get; set; }
    
    public string? NINImageUrl { get; set; }
    
}