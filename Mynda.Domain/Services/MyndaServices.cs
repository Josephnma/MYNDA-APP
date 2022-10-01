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
        private readonly MyndaDBContext _Db;

        public MyndaServices(MyndaDBContext db)
        {
            _Db = db;
        }
    }
}
