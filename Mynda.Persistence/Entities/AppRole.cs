using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynda.Persistence.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public ICollection<UserRoles>? UserRoles { get; set; }
    }
}
