using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynda.Persistence.Entities
{
    public class WorkExperience
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string? JobTitle { get; set; }

        [Required]
        [StringLength(30)]
        public string? CompanyName { get; set; }
        public enum EmploymentType
        {
            FullTime,
            Partime,
            Freelance,
            Remote
        }

        [Required]
        [StringLength(200)]
        public string? Location { get; set; }

        [Required]
        [StringLength(50)]
        public DateTime Period { get; set; }

        [Required]
        [StringLength(500)]
        public string? Description { get; set; }
    }
}
