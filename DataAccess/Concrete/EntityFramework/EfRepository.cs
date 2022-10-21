using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfRepository<T> : IEntityRepository<T> where T : class
    {
        EfContext c = new EfContext();
        DbSet<T> _object;

        public EfRepository()
        {
            _object = c.Set<T>();
        }
        public int Add(T entity)
        {
            _object.Add(entity);
            return c.SaveChanges();
        }

        public int Delete(T entity)
        {
            _object.Remove(entity);
            return c.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> ListAll()
        {
            return _object.ToList();
        }

        public int Update(T entity)
        {
            return c.SaveChanges();
        }
    }
}