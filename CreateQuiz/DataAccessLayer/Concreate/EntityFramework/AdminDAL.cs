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
    public class AdminDAL : GenericDAL<Admin>, IAdminDAL
    {
        public Admin LoginUserDAL(Admin user)
        {
            using var c = new SqliteContext();
            return c.Admins.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
        }
    }
}
