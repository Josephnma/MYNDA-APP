using Mynda.Persistence.Entities;
using Mynda.Persistence.Repository;

namespace Mynda.Persistence.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Entities.Myndas> Myndas { get; }
        IGenericRepository<Entities.Agents> Agents { get; }
        
        
        IGenericRepository<Entities.AgentDashBoard> AgentDashBoard { get; } 

        Task Save();

    }
    
    


}
