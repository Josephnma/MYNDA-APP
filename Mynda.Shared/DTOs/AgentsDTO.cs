using System.ComponentModel.DataAnnotations;

namespace Agents.Shared.DTOs
{
    public class AgentsDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public  string UserId { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required, StringLength(20, ErrorMessage = "Your Password is limited to {2} to {1} characters", MinimumLength = 3)]
        public string Password { get; set; }
        

        [Required, StringLength(50)]
        public string? PhotoUrl { get; set; }

        [Required, StringLength(500)]
        public string? AboutMe { get; set; }


        public List<string>? Skills { get; set; }

        [Required, StringLength(15)]
        public string? StateOfOrigin { get; set; }

        [Required, StringLength(15)]
        public string? LGA { get; set; }


        public enum Sex { Male , Female }

        [Required, StringLength(10)]
        public string? BVN { get; set; }

        [Required, StringLength(15)]
        public string? Religion { get; set; }

        [Required, StringLength(10)]
        public string? NIN { get; set; }

        public string? CompanyName { get; set; }
        
        public string? UtilityBill { get; set; }

        public string? CompanyEmail { get; set; }

        public string? OfficeAddress { get; set; } 

        public string? Address { get; set; } 
        public string? CompanyPhoneNumber { get; set; }   
        
        public List<string>? SelectService { get; set; }

        }

    }

