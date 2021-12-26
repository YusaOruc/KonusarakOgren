﻿using DataAccessLayer.Abstract.IRepositories;
using EntityLayer.Concreate.EntityFrameworkSqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAdminDAL: IGenericDAL<Admin>
    {
        Admin LoginUserDAL(Admin user);
    }
}
