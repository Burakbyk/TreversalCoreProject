using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator :AbstractValidator<About>
    {

        public AboutValidator()
        {
            RuleFor(x=>x.Description).NotEmpty()
                .WithMessage("Açıklama Kısmını Boş Geçemezsiniz.");

            RuleFor(x => x.Image1).NotEmpty()
                .WithMessage("Lütfen Görsel Seçiniz.");

            RuleFor(x => x.Description).MinimumLength(30)
                .WithMessage("Lütfen en az 30 karakterlik bir açıklama giriniz.");

            RuleFor(x => x.Description).MaximumLength(1500)
                .WithMessage("Açıklama uzunluğu çok fazla. (Max 1500 karakter)");

        
        }

    }
}
