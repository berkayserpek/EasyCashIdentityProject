using EasyCashIdentityProject.DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("İsim boş geçilemez!");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyisim boş geçilemez!");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail boş geçilemez!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez!");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez!");
            RuleFor(x => x.FirstName).MaximumLength(30).WithMessage("İsminiz çok uzun :)");
            RuleFor(x => x.FirstName).MinimumLength(2).WithMessage("İsminiz çok kısa sanırım :)");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Şifreler eşleşmiyor sanırım :)");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli bir format giriniz!");
        }
    }
}
