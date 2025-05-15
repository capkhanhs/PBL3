using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.DAL
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(params object[] keyValues);
        void Add(T entity);
        void Update(T entity);
        void Delete(params object[] keyValues );
        void Save();
    }
}
