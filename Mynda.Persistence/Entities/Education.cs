using System.ComponentModel.DataAnnotations;

namespace Mynda.Persistence.Entities
{
    public class Education
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string? SchoolName { get; set; }

        [Required]
        [MaxLength(10)]
        public string? StartYear { get; set; }

        [Required]
        [MaxLength(10)]
        public string? EndYear { get; set; }

        [Required]
        [MaxLength(30)]
        public string? Qualification { get; set; }
    }
}
