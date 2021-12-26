using BusinessLayer.Concreate;
using CreateQuiz.ViewModels;
using DataAccessLayer.Concreate.EntityFramework;
using EntityLayer.Concreate.EntityFrameworkSqlite;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateQuiz.Controllers
{
    public class AdminCreateQuizController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
