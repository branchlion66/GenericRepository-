using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseRepo.Repository.Base
{
    public interface IDeveloperRepository<TEntity> where TEntity : class
    {
        int Add(TEntity TEntity); 
        int AddRange(IEnumerable<TEntity> entities);
        List<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        int Remove(TEntity TEntity);
        int RemoveRange(IEnumerable<TEntity> entities);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}
