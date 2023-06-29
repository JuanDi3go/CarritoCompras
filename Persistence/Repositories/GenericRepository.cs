using Application.Interfaces.IRepositoriesInterfaces;
using System.Linq.Expressions;

namespace Persistence.Repositories
{
    public class GenericRepository<T> : IRepostioryAsync<T> where T : class
    {
        public Task<T> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> filtro = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> filtro)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
