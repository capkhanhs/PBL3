using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using PBL.Model;

namespace PBL.DAL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly PBL3_azure_databaseEntities2 context;
        protected readonly DbSet<T> dbSet;
        public Repository()
        {
            context = new PBL3_azure_databaseEntities2();
            dbSet = context.Set<T>();
        }
        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(object id)
        {
            return dbSet.Find(id);
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
