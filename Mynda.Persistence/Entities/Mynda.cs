using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynda.Persistence.Entities
{
    public class Mynda : IdentityUser
    {
        public int Education { get; set; }
        public Education EducationDetails { get; set; }

        public int Guarantor { get; set; }
        public Guarantor GuarantorDetails { get; set; }

        public int Review { get; set; }
        public Reviews Reviews { get; set; }

        public int PhotoProfile { get; set; }
        public PhotoProfile PhotoProfiles { get; set; }

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

        public string? height { get; set; }

    }
}
