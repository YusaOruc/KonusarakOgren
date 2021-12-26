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
    public class QuestionManager : IQuestionService
    {
        IQuestionDAL _questionDAL;

        public QuestionManager(IQuestionDAL questionDAL)
        {
            _questionDAL = questionDAL;
        }

        public void DeleteService(Question t)
        {
            _questionDAL.DeleteDAl(t);
        }

        public Question FindByNameService(Question question)
        {
            return _questionDAL.FindByName(question);
        }

        public Question GetByIDService(int id)
        {
            return _questionDAL.GetByIdDAL(id);
        }

        public List<Question> GetListAllService()
        {
            return _questionDAL.GetListAllDAL();
        }

        public List<Question> GetListAllService(Expression<Func<Question, bool>> filter)
        {
            return _questionDAL.GetListAllDAL(filter);
        }

        public void InsertService(Question t)
        {
            _questionDAL.InsertDAL(t);
        }

        public void UpdateService(Question t)
        {
            _questionDAL.UpdateDAL(t);
        }
    }
}
