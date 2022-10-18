using System.ComponentModel.DataAnnotations;

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
            PartTime,
            Freelance,
            Remote
        }

        [Required]
        [StringLength(200)]
        public string? Location { get; set; }

        [Required]
        public DateTime Period { get; set; }

        [Required]
        [StringLength(500)]
        public string? Description { get; set; }
    }
}
