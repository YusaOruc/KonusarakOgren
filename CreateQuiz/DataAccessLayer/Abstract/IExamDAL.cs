using DataAccessLayer.Abstract.IRepositories;
using EntityLayer.Concreate.EntityFrameworkSqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IExamDAL:IGenericDAL<Exam>
    {
        List<Exam> GetListAllWithQuestionDAL();
        Exam GetListAllWithQuestionDAL(Expression<Func<Exam, bool>> filter);
    }
}
