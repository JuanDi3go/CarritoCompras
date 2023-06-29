using Application.Interfaces.IRepositoriesInterfaces;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbCarritoComprasContext _context;

        public UnitOfWork(DbCarritoComprasContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync();
        }
    }
}
