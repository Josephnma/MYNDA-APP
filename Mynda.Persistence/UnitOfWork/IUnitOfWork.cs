using Mynda.Persistence.Repository;

namespace Mynda.Persistence.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Entities.Myndas> Myndas { get; }
        Task Save();
    }
}
