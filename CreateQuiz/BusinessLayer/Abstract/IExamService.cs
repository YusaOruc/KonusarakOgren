using BusinessLayer.Abstract.Repositories;
using EntityLayer.Concreate.EntityFrameworkSqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IExamService : IRepositoryService<Exam>
    {
        List<Exam> GetListAllWithQuestionService();
        Exam GetListAllWithQuestionService(Expression<Func<Exam, bool>> filter);
    }
}
