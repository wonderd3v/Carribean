using Carribean.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Carribean.API.Services
{
    public interface IBaseService<TEntity> where TEntity : BaseModel 
    {
        IQueryable<TEntity> Query();
        IQueryable<TEntity> GetAll();
        TEntity GetById(int id);
        Task<TEntity> Create(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task Delete(int id);
    }
    public class BaseServices<TEntity> : IBaseService<TEntity> where TEntity : BaseModel 
    {
        protected readonly Context _context;

        protected readonly DbSet<TEntity> _dbSet;

        public BaseServices(Context context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();

        }
        public virtual IQueryable<TEntity> Query()
        {
            return _dbSet.AsQueryable();
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            var entities = Query();

            return entities;
        }

        public virtual TEntity GetById(int id)
        {
            var entity = Query().Where(x => x.Id == id).FirstOrDefault();

            if (entity == null) return null;

            return entity;
        }

        public virtual async Task<TEntity> Create(TEntity entity)
        {
            _dbSet.Add(entity);

            await _context.SaveChangesAsync();

            return entity;
        }
        public virtual async Task<TEntity> Update(TEntity entity)
        {
            var entityExist = Query().Any(x => x.Id == entity.Id);
            if (entityExist is false) return null;

            _dbSet.Update(entity);

            await _context.SaveChangesAsync();

            return entity;
        }

        public virtual async Task Delete(int id)
        {
            var entity = await Query().Where(x => x.Id == id)
            .FirstOrDefaultAsync();

            if (entity is null) return;

            _dbSet.Remove(entity);

            await _context.SaveChangesAsync();
        }
    }
}
