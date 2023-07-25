﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer.DTOs.AnnouncementDTOs;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {
            RuleFor(x=>x.Title).NotEmpty()
                .WithMessage("Lütfen başlığı Boş geçmeyin.");

            RuleFor(x=>x.Content).NotEmpty()
                .WithMessage("Lütfen duyuru içeriğimi Boş geçmeyin.");

            RuleFor(x => x.Title).MinimumLength(5)
                .WithMessage("Lütfen en az 5 karakter girişi yapınız");

            RuleFor(x => x.Content).MinimumLength(20)
               .WithMessage("Lütfen en az 20 karakter girişi yapınız");

            RuleFor(x => x.Title).MaximumLength(50)
               .WithMessage("Lütfen en fazla 50 karakter girişi yapınız");

            RuleFor(x => x.Content).MaximumLength(500)
            .WithMessage("Lütfen en fazla 500 karakter girişi yapınız");

        }
    }
}