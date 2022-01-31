using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını Boş Geçemezsiniz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriğini Boş Geçemezsiniz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Resmini Boş Geçemezsiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Blog Başlığı 150 Karakterden Fazla Olamaz");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Blog Başlığı 5 Karakterden Az Olamaz");
            RuleFor(x => x.BlogContent).MaximumLength(500).WithMessage("Blog İçeriği 500 Karakterden Fazla Olamaz");
            RuleFor(x => x.BlogContent).MinimumLength(100).WithMessage("Blog İçeriği 100 Karakterden Az Olamaz");

        }
    }
}
