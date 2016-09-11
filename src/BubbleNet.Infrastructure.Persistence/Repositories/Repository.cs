using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;
using BubbleNet.Core.Repositories;


namespace BubbleNet.Infrastructure.Persistence.Repositories
{
    
    public class Repository<TEntity> : IRepository<TEntity> where TEntity: class
    {
        public readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

         TEntity IRepository<TEntity>.Get(long id)
        {
           return _context.Set<TEntity>().Find(id);
        }

         IEnumerable<TEntity> IRepository<TEntity>.GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

         IEnumerable<TEntity> IRepository<TEntity>.Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).ToList();
        }

         void IRepository<TEntity>.Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

         void IRepository<TEntity>.AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

         void IRepository<TEntity>.Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

         void IRepository<TEntity>.RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }
    }
}
