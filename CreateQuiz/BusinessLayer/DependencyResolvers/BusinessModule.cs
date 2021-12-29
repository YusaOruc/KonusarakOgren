using BusinessLayer.Abstract;
using BusinessLayer.Concreate;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DependencyResolvers
{
    public class BusinessModule: NinjectModule
    {
        public override void Load()
        {
            Bind<IExamService>().To<ExamManager>();
            Bind<IExamDAL>().To<ExamDAL>();
        }
    }
}
