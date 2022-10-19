using Mynda.Persistence.DbContext;
using Mynda.Persistence.Entities;
using Mynda.Persistence.Repository;


namespace Mynda.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyndaDbContext _context;
        private IGenericRepository<Myndas> _myndas;
        private IGenericRepository<Agents> _agents;
        private IGenericRepository<AgentDashBoard> _agentdashboard;


        public UnitOfWork(MyndaDbContext context)
        {
            _context = context;
        }
        
        public IGenericRepository<Entities.Myndas> Myndas  => _myndas ??= new GenericRepository<Myndas>(_context);
        public IGenericRepository<Entities.Agents> Agents => _agents ??= new GenericRepository<Agents>(_context);
        
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
