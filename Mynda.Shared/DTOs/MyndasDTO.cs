using Mynda.Persistence.Entities;
using System.ComponentModel.DataAnnotations;

namespace Mynda.Shared.DTOs
{
    public class MyndasDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required, StringLength(20, ErrorMessage = "Your Password is limited to {2} to {1} characters", MinimumLength = 3)]
        public string Password { get; set; }

        [Required, StringLength(500)]
        public string? ResidentialAddress { get; set; }

        [Required, StringLength(50)]
        public string? PhotoUrl { get; set; }

        [Required, StringLength(500)]
        public string? AboutMe { get; set; }


        public List<string>? Skills { get; set; }

        [Required, StringLength(15)]
        public string? StateOfOrigin { get; set; }

        [Required, StringLength(15)]
        public string? LGAOfOrigin { get; set; }


        public enum Sex { Male , Female }

        [Required, StringLength(10)]
        public string? Height { get; set; }

        [Required, StringLength(15)]
        public string? Religion { get; set; }

        [Required, StringLength(10)]
        public string? Disability { get; set; }

        public string? Allergies { get; set; }

        public string? SalaryExpectation { get; set; }

        public List<string>? Category { get; set; } 

        public DateTime DateOfBirth { get; set; }   
        
        public List<string>? StatesWillingToRelocate { get; set; }

        public Education EducationLevel { get; set; }

        public WorkExperience WorkExperience { get; set; }

        public string ClearanceForm { get; set; }

        public Guarantor GuarantorDetails { get; set; }

        public Reviews Reviews { get; set; }
        

    }
}
