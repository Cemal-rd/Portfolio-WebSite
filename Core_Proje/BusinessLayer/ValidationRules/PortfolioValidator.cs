using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
   public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adı Boş Geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim alanı boş bırakılamaz.");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Resim2 alanı boş bırakılamaz.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat alanı boş bırakılamaz.");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Değer alanı boş bırakılamaz.");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje Adı en az 5 karakterden oluşmak zorundadır.");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje Adı en fazla 100 karakter olabilir");
        }

    }
}
