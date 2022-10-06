using Mynda.Persistence.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynda.Domain.Services
{
    public class MyndaServices
    {
        private readonly MyndaDbContext _Db;

        public MyndaServices(MyndaDbContext db)
        {
            _Db = db;
        }
    }
}
