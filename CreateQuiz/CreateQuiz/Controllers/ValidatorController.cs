using BusinessLayer.Concreate;
using CreateQuiz.ViewModels;
using DataAccessLayer.Concreate.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateQuiz.Controllers
{
    public class ValidatorController : Controller
    {
        AnswerManager answerManager = new AnswerManager(new AnswerDAL());
        
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string[] Index(string responses)
        {
            responses= responses.Trim();
            string[] responsList = responses.Split(" ");

            int counter = 0;
            string[] righList = new string[responsList.Length];
            foreach (var item in responsList)
            {
                var value = answerManager.GetByIDService(Convert.ToInt32(item));
                righList[counter] = value.RightAnswer;
                counter = counter + 1;
            }
            return righList;
        }
    }
}
