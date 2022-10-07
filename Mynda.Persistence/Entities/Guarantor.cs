using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynda.Persistence.Entities
{
    public class Guarantor
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(30)]
        public string? Email { get; set; }

        [Required]
        [MaxLength(500)]
        public string? Address { get; set; }

        [MaxLength(15)]
        public string? PhoneNumber { get; set; }
      
    }
}
