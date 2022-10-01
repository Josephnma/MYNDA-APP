using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynda.Persistence.Entities
{
    public class PhotoProfile
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public string User { get; set; }
        public int UserId { get; set; }
    }
}
