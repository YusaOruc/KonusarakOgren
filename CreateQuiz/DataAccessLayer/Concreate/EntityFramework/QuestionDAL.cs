using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.MyContexts;
using DataAccessLayer.Concreate.Repositories;
using EntityLayer.Concreate.EntityFrameworkSqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.EntityFramework
{
    public class QuestionDAL : GenericDAL<Question>, IQuestionDAL
    {
        public Question FindByName(Question question)
        {
            using var c = new SqliteContext();
            //return c.Questions.Where(x => x.Title == question.Title && x.QuizQuestion == question.QuizQuestion).LastOrDefault();
            return c.Questions.OrderByDescending(x => x.QuestionId).FirstOrDefault(x => x.Title == question.Title && x.QuizQuestion == question.QuizQuestion);
        }

       
    }
}
