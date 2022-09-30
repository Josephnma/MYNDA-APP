using Mynda.Persistence.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynda.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyndaDBContext _context;
        //private IGenericRepository<> _;


        public UnitOfWork(MyndaDBContext context)
        {
            _context = context;

        }
        //  public IGenericRepository<>  => _ ??= new GenericRepository<>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

    }
}
