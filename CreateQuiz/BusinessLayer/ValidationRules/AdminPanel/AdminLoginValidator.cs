using EntityLayer.Concreate.EntityFrameworkSqlite;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AdminPanel
{
    public class AdminLoginValidator: AbstractValidator<Admin>
    {
        public AdminLoginValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Lütfen kullanıcı adınızı giriniz.");
            RuleFor(x => x.Password).MinimumLength(2).WithMessage("Şifreniz en az 3 karakterden oluşmak zorundadır.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Lütfen şifrenizi giriniz.");
        }
    }
}
