using BusinessLayer.Abstract.Repositories;
using EntityLayer.Concreate.EntityFrameworkSqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IQuestionService: IRepositoryService<Question>
    {
        Question FindByNameService(Question question);
    }
}
