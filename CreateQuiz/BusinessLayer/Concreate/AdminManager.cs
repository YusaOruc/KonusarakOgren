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
    public class AdminManager : IAdminService
    {
        IAdminDAL _adminDAL;
        public AdminManager(IAdminDAL adminDAL)
        {
            _adminDAL = adminDAL;
        }
        public void DeleteService(Admin t)
        {
            _adminDAL.DeleteDAl(t);
        }

        public Admin GetByIDService(int id)
        {
           return _adminDAL.GetByIdDAL(id);
        }

        public List<Admin> GetListAllService()
        {
            return _adminDAL.GetListAllDAL();
        }

        public List<Admin> GetListAllService(Expression<Func<Admin, bool>> filter)
        {
            return _adminDAL.GetListAllDAL(filter);
        }

        public void InsertService(Admin t)
        {
            _adminDAL.InsertDAL(t);
        }

        public Admin LoginUserDALService(Admin user)
        {
            return _adminDAL.LoginUserDAL(user);
        }

        public void UpdateService(Admin t)
        {
            _adminDAL.UpdateDAL(t);
        }
    }
}
