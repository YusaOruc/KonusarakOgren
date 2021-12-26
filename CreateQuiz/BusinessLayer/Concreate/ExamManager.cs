using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate.EntityFrameworkSqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class ExamManager : IExamService
    {
        IExamDAL _examDAL;

        public ExamManager(IExamDAL examDAL)
        {
            _examDAL = examDAL;
        }

        public void DeleteService(Exam t)
        {
            _examDAL.DeleteDAl(t);
        }

        public Exam GetByIDService(int id)
        {
            return _examDAL.GetByIdDAL(id);
        }

        public List<Exam> GetListAllService()
        {
            return _examDAL.GetListAllDAL();
        }

        public List<Exam> GetListAllService(Expression<Func<Exam, bool>> filter)
        {
            return _examDAL.GetListAllDAL(filter);
        }

        public List<Exam> GetListAllWithQuestionService()
        {
            return _examDAL.GetListAllWithQuestionDAL();
        }

        public Exam GetListAllWithQuestionService(Expression<Func<Exam, bool>> filter)
        {
            return _examDAL.GetListAllWithQuestionDAL(filter);
        }

        public void InsertService(Exam t)
        {
            _examDAL.InsertDAL(t);
        }

        public void UpdateService(Exam t)
        {
            _examDAL.InsertDAL(t);
        }
    }
}
