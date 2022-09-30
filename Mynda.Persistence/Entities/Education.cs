using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynda.Persistence.Entities
{
    public class Education
    {
        public int Id { get; set; }
        public string? SchoolName { get; set; }
        public string? StartYear { get; set; }
        public string? EndYear { get; set; }
        public string? Qualification { get; set; }
    }
}
