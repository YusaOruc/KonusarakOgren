using DataAccessLayer.Abstract.IRepositories;
using DataAccessLayer.Concreate.MyContexts;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.Repositories
{
    public class GenericDAL<T> : IGenericDAL<T> where T : class
    {
        
        public void DeleteDAl(T t)
        {
            using var c = new SqliteContext();

            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByIdDAL(int id)
        {
            using var c = new SqliteContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAllDAL()
        {
            using var c = new SqliteContext();
            return c.Set<T>().ToList();
        }

        public List<T> GetListAllDAL(Expression<Func<T, bool>> filter)
        {
            using var c = new SqliteContext();
            return c.Set<T>().Where(filter).ToList();
        }

        public void InsertDAL(T t)
        {
            
            using var c = new SqliteContext();
            c.Add(t);
            c.SaveChanges();
            
        }

        public void UpdateDAL(T t)
        {
            using var c = new SqliteContext();
            c.Set<T>().Update(t);
            //c.Update(t);
            c.SaveChanges();
        }
    }
}
