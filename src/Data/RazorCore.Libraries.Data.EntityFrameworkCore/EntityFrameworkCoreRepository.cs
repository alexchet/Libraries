using Microsoft.EntityFrameworkCore;
using RazorCore.Libraries.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace RazorCore.Libraries.Data.EntityFrameworkCore
{
    public abstract class EntityFrameworkCoreRepository<TEntity> : IRepository<TEntity, long> where TEntity : class, IEntity<long>
    {
        internal DbContext _context;

        public EntityFrameworkCoreRepository(DbContext context)
        {
            _context = context;
        }

        public Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>[] filters, CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            if (filters != null)
            {
                foreach (var filter in filters)
                {
                    query = query.Where(filter);
                }
            }

            return Task.FromResult(query.AsEnumerable());
        }

        public Task<TEntity> GetAsync(long Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<long> InsertAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
