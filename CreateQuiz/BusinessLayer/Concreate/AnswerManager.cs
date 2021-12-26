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
    public class AnswerManager : IAnswerService
    {
        IAnswerDAL _answerDAL;

        public AnswerManager(IAnswerDAL answerDAL)
        {
            _answerDAL = answerDAL;
        }

        public void DeleteService(Answer t)
        {
            _answerDAL.DeleteDAl(t);
        }

        public Answer GetByIDService(int id)
        {
            return _answerDAL.GetByIdDAL(id);
        }

        public List<Answer> GetListAllService()
        {
            return _answerDAL.GetListAllDAL();
        }

        public List<Answer> GetListAllService(Expression<Func<Answer, bool>> filter)
        {
            return _answerDAL.GetListAllDAL(filter);
        }

        public void InsertService(Answer t)
        {
            _answerDAL.InsertDAL(t);
        }

        public void UpdateService(Answer t)
        {
            _answerDAL.UpdateDAL(t);
        }
    }
}
