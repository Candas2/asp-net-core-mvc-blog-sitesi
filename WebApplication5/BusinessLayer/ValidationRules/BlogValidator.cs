﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Başlık boş geçilemez.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği boş geçilemez.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Görsel boş geçilemez.");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("En fazla 150 karakter.");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("En az 5 karakter.");
        }
    }
}
