using Microsoft.EntityFrameworkCore;
using NET_6._0__JWT__CQRS.Core.Application.Interfaces;
using NET_6._0__JWT__CQRS.Persistance.Context;
using System.Linq.Expressions;

namespace NET_6._0__JWT__CQRS.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly ProjectJwtContext _jwtcontext;

        public Repository(ProjectJwtContext jwtcontext)
        {
            _jwtcontext = jwtcontext;
        }

        public async Task CreatAsync(T entity)
        {
            await this._jwtcontext.Set<T>().AddAsync(entity);
            await this._jwtcontext.SaveChangesAsync();
             
        }

        public async Task DeleteAsync(T entity)
        {
             this._jwtcontext.Set<T>().Remove(entity);
            await this._jwtcontext.SaveChangesAsync();

        }

        public async Task<List<T>> GetAllAsync()
        {
            return await this._jwtcontext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await this._jwtcontext.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<T?> GetByIdAsync(object id) 
        {
            return await this._jwtcontext.Set<T>().FindAsync(id); 
        }

        public async Task UpdateAsync(T entity)
        {
            this._jwtcontext.Set<T>().Update(entity);
            await this._jwtcontext.SaveChangesAsync();
        }

    }
}
