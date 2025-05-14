using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
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
        //Lấy tất cả dữ liệu theo kiểu T
        public List<T> GetAll()
        {
            return dbSet.ToList();
        }
        //Lấy dữ liệu theo id
        public T GetById(params object[] keyValues)
        {
            return dbSet.Find(keyValues);
        }

        //Thêm đối tượng T vào DB
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        //Cập nhật đối tượng T vào DB
        public void Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        //Xóa đối tượng T khỏi DB
        public void Delete(object id)
        {
            T entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
            }
        }

        //Lưu thay đổi vào DB
        public void Save()
        {
            context.SaveChanges();
        }

        // Hàm Select chung với điều kiện
        public List<T> Select(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate).ToList();
        }
    }
}
