using Elementalist.Business.Constants;
using Elementalist.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elementalist.Business.ValidationRoles.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //Buradaki kurallar örnektir.
            RuleFor(p => p.ProductName).NotEmpty().WithMessage(Messages.ProductNotEmpty);
            //RuleFor(p => p.ProductName).Length(2, 30);
            //RuleFor(p => p.UnitPrice).NotEmpty();
            //RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(1);
            //RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
        }
    }
}
