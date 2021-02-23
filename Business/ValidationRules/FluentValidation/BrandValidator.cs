using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty().WithMessage("Boş bırakmayınız.");
            RuleFor(b => b.BrandName).MinimumLength(2).WithMessage("En az iki karakter olacak şekilde giriniz.");
            
        }
    }
}
