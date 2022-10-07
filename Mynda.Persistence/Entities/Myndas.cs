using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mynda.Persistence.Entities
{
    public class Myndas
    {
        public int Id { get; set; }

        [ForeignKey("Users")]
        public string UserId { get; set; }
        public User Users { get; set; }

        [ForeignKey("EducationDetails")]
        public int Education { get; set; }
        public Education EducationDetails { get; set; }


        [ForeignKey("GuarantorDetails")]
        public int Guarantor { get; set; }
        public Guarantor GuarantorDetails { get; set; }


        [ForeignKey("Reviews")]
        public int Review { get; set; }
        public Reviews Reviews { get; set; }


        [ForeignKey("PhotoProfiles")]
        public int PhotoProfile { get; set; }
        public PhotoProfile PhotoProfiles { get; set; }


        [ForeignKey("WorkExperienceDetails")]
        public int WorkExperience { get; set; }
        public WorkExperience WorkExperienceDetails { get; set; }

        public string? Status { get; set; }

        public string? Skills { get; set; }

        public string? LGA { get; set; }

        public string? Allergies { get; set; }

        public string? Disability { get; set; }

        public string? SalaryExpectation { get; set; }

        public string? StatesWillingToRelocate { get; set; }

        public string? ClearenceForm { get; set; }

        public string? Religion { get; set; }

        public string? AboutMe { get; set; }

        public string? Height { get; set; }

    }
}
