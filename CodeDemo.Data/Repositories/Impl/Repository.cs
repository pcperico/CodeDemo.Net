using CodeDemo.Data.Repositories.Interfaces;
using CodeDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDemo.Data.Repositories.Impl
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public DBContexCodeDemo context;

        public Repository()
        {
            context = new DBContexCodeDemo();
        }

        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }

        public T Save(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void Update(T entity, int id)
        {
            T existing = context.Set<T>().Find(id);
            if (existing == null) return;
            context.Entry(existing).CurrentValues.SetValues(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }


        public ICollection<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
    }
}
