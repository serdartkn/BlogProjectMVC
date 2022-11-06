using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
        List<T> ListAll(Expression<Func<T,bool>> filter =null);
        T ListOne(Expression<Func<T, bool>> filter);
    }
}