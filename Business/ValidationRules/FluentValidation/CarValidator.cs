using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Araç fiyatı 0'dan büyük olmalı. ");
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage("Boş bırakmayınız.");
            RuleFor(c => c.BrandId).NotEmpty().WithMessage("Boş bırakmayınız.");
            RuleFor(c => c.Description).MinimumLength(2).WithMessage("En az iki karakter olacak şekilde giriniz.");

                
        }
    }
}
