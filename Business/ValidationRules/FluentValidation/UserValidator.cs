using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("Boş bırakmayınız");
            RuleFor(u => u.Password).NotEmpty().WithMessage("Boş bırakmayınız.");
            RuleFor(u => u.Password).MinimumLength(4).WithMessage("En az 4 karakter olacak şekilde giriniz.");
        }
    }
}
