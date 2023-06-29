using System.Linq.Expressions;

namespace Application.Interfaces.IRepositoriesInterfaces
{
    public interface IRepostioryAsync<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> filtro = null);
        Task<T> GetAsync(Expression<Func<T, bool>> filtro);

    }
}
