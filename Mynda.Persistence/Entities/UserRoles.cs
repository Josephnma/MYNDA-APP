﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynda.Persistence.Entities
{
    public class UserRoles : IdentityUserRole<int>
    {
        public Myndas? Mynda { get; set; }
        public AppRole? Role { get; set; }
    }
}
