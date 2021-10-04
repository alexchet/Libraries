using Microsoft.EntityFrameworkCore;
using RazorCore.Libraries.Data.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorCore.Libraries.Data.EntityFrameworkCore
{
    public abstract class EntityFrameworkCoreRepository<TEntity> : IRepository<TEntity, long> where TEntity : class, IEntity<long>
    {
        internal DbContext _dbContext;
        internal DbSet<TEntity> _dbSet;

        public EntityFrameworkCoreRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public virtual Task<IEnumerable<TEntity>> GetWithSql(string query, params object[] parameters)
        {

        }
    }
}
