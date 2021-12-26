using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.MyContexts;
using DataAccessLayer.Concreate.Repositories;
using EntityLayer.Concreate.EntityFrameworkSqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.EntityFramework
{
    public class ExamDAL : GenericDAL<Exam>, IExamDAL
    {
        public List<Exam> GetListAllWithQuestionDAL()
        {
            using var c = new SqliteContext();
            return c.Exams.Include(x=>x.Question).Include(x=>x.Question.Answers).ToList();
        }

        public Exam GetListAllWithQuestionDAL(Expression<Func<Exam, bool>> filter)
        {
            using var c = new SqliteContext();
            return c.Exams.Include(x => x.Question).Include(x => x.Question.Answers).FirstOrDefault(filter);
        }
    }
}
