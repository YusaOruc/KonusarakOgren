using BusinessLayer.Abstract;
using BusinessLayer.Concreate;
using BusinessLayer.DependencyResolvers;
using CreateQuiz.Models;
using DataAccessLayer.Concreate.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CreateQuiz.Controllers
{
    public class HomeController : Controller
    {
        IExamService examManager;
        public HomeController()
        {
            examManager = InstanceFactory.GetInstance<IExamService>();
        }
        //ExamManager examManager = new ExamManager(new ExamDAL());
        public IActionResult Index()
        {
            var values = examManager.GetListAllWithQuestionService();
            return View(values);
        }
        public IActionResult Exam(int id)
        {

            var value = examManager.GetListAllWithQuestionService(x => x.ExamID == id);
            return View(value);
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
