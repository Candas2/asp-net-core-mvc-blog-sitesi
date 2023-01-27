﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Boş geçilemez.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Boş geçilemez.");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("En fazla 50 karakter.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karakter.");
        }
    }
}
