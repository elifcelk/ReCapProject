using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.UserId).NotEmpty().WithMessage("Boş bırakmayınız.");
            RuleFor(c => c.CompanyName).NotEmpty().WithMessage("Boş bırakmayınız.");
            RuleFor(c => c.CompanyName).MinimumLength(2).WithMessage("En az iki karakter olacak şekilde giriniz.");


        }
    }
}
