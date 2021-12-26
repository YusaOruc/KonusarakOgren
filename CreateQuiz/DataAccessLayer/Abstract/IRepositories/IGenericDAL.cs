using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.IRepositories
{
    public interface IGenericDAL<T>where T:class
    {
        void InsertDAL(T t);
        void UpdateDAL(T t);
        void DeleteDAl(T t);
        List<T> GetListAllDAL();
        List<T> GetListAllDAL(Expression<Func<T,bool>>filter);
        T GetByIdDAL(int id);
    }
}
