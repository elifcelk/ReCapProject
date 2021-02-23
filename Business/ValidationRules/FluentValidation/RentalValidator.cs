using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty().WithMessage("Boş bırakmayınız");
            RuleFor(r => r.CustomerId).NotEmpty().WithMessage("Boş bırakmayınız");
            RuleFor(r => r.RentDate).NotEmpty().WithMessage("Boş bırakmayınız");
            RuleFor(r => r.ReturnDate).NotEmpty().WithMessage("Araç teslim edilmedği için kiralanamaz.");
        }
    }
}
