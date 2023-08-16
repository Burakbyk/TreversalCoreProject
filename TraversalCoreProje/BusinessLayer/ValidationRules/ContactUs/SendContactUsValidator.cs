using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUs
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş geçilemez");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Mesaj alanı boş geçilemez");

            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu alanına en az 5 karakter girilmelidir.");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Konu alanına en fazla 100 karakter girilmelidir.");

            RuleFor(x => x.MessageBody).MinimumLength(5).WithMessage("Mesaj alanına en az 5 karakter girilmelidir.");
            RuleFor(x => x.MessageBody).MaximumLength(500).WithMessage("Mesaj alanına en fazla 500 karakter girilmelidir.");


        }


    }
}
