using BusinessLayer.Concreate;
using BusinessLayer.ValidationRules;
using BusinessLayer.ValidationRules.AdminPanel;
using CreateQuiz.Helper;
using CreateQuiz.ViewModels;
using DataAccessLayer.Concreate.EntityFramework;
using EntityLayer.Concreate.EntityFrameworkSqlite;
using FluentValidation.Results;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CreateQuiz.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        AnswerManager answerManager = new AnswerManager(new AnswerDAL());
        QuestionManager questionManager = new QuestionManager(new QuestionDAL());
        ExamManager examManager = new ExamManager(new ExamDAL());
        public IActionResult Index()
        {
            List<string> value = GetArticle.GetALL();
            
            var articles = GetArticle.GetDetails(value);
            return View(articles);
            
        }
        public IActionResult Quiz()
        {

            var value = examManager.GetListAllWithQuestionService();
            return View(value);
        }
        [HttpPost]
        public IActionResult CreateQuiz( List<Answer> answer,  Question question)
        {

            


            Exam exam = new Exam();
            questionManager.InsertService(question);

            var values= questionManager.FindByNameService(question);
            exam.Date = DateTime.Now;
            exam.QuestionId = values.QuestionId;
            examManager.InsertService(exam);
            

            foreach (var item in answer)
            {
                item.QuestionId = values.QuestionId;
                answerManager.InsertService(item);
            }

            return RedirectToAction("Quiz");

        }
        public IActionResult DeleteExam(int id)
        {
            var values = examManager.GetByIDService(id);
            examManager.DeleteService(values);
            return RedirectToAction("Quiz");
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
        
    }
}
