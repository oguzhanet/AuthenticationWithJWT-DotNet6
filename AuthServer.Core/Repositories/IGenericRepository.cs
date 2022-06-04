using System.Linq.Expressions;

namespace AuthServer.Core.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        TEntity GetAllAsync(Expression<Func<TEntity, bool>> filter);

        Task<TEntity> GetByIdAsync(int id);
        
        Task AddAsync(TEntity entity);
        
        TEntity UpdateAsync(TEntity entity);
        
        void Remove(TEntity entity);
    }
}
