using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.Repositories;
using EntityLayer.Concreate.EntityFrameworkSqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.EntityFramework
{
    public class AnswerDAL : GenericDAL<Answer>, IAnswerDAL
    {
    }
}
