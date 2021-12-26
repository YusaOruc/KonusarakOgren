using BusinessLayer.Concreate;
using BusinessLayer.ValidationRules.AdminPanel;
using DataAccessLayer.Concreate.EntityFramework;
using EntityLayer.Concreate.EntityFrameworkSqlite;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CreateQuiz.Controllers
{
    public class LoginController : Controller
    {
        AdminManager adminManager = new AdminManager(new AdminDAL());
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SingIn(Admin admin)
        {

            var values = adminManager.LoginUserDALService(admin);
            AdminLoginValidator validationRules = new AdminLoginValidator();
            ValidationResult result = validationRules.Validate(admin);
            if (result.IsValid)
            {
                if (values != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,admin.UserName)
                    };
                    var userIdentity = new ClaimsIdentity(claims, "a");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı veya şifrenizi yanlış girdiniz.");
                    return View("Index",admin);

                }
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View("Index",admin);

        }
    }
}
