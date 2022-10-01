using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynda.Persistence.Entities
{
    public class Reviews
    {
        public int Id { get; set; }

        public enum StarRating
        {
            Poor,
            Average,
            Good,
            VeryGood,
            Best,
        }

        [Required]
        [StringLength(500)]
        public string? Description { get; set; }

        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
