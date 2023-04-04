using System;
using System.Linq.Expressions;

namespace NET_6._0__JWT__CQRS.Core.Application.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(object id);
        Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter);
        Task CreatAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
