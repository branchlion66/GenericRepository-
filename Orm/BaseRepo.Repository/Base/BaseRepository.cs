using BaseRepo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseRepo.Repository.Base
{
    public class BaseRepository<TEntity> : IDeveloperRepository<TEntity> where TEntity : class
    {
        public readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int Add(TEntity TEntity)
        {
            _context.Set<TEntity>().Add(TEntity);
            return _context.SaveChanges();

        }

        public int AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
            return _context.SaveChanges();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).FirstOrDefault();
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public int Remove(TEntity TEntity)
        {
            _context.Set<TEntity>().Remove(TEntity);
            return _context.SaveChanges();
        }

        public int RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
            return _context.SaveChanges();
        }
    }
}
