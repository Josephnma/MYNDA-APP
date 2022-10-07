using Mynda.Persistence.DbContext;
using Mynda.Persistence.Repository;


namespace Mynda.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyndaDbContext _context;
        private IGenericRepository<Entities.Myndas> _myndas;


        public UnitOfWork(MyndaDbContext context)
        {
            _context = context;
        }
        
        public IGenericRepository<Entities.Myndas> Myndas  => _myndas ??= new GenericRepository<Entities.Myndas>(_context);

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
