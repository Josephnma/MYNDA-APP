using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynda.Persistence.Entities
{
    public class Agents
    {
        public int Id { get; set; }

        [ForeignKey("Users")]
        public string UserId { get; set; }
        public User Users { get; set; }
    }
}
