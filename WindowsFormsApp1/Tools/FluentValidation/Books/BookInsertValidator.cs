using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using WindowsFormsApp1.Objects.Books;

namespace WindowsFormsApp1.Tools.FluentValidation.Books
{
    public class BookInsertValidator : AbstractValidator<InsertBook>
    {
        public BookInsertValidator()
        {
            RuleFor(b => b.KitapAd)
                .NotEmpty().WithMessage("Kitap adını boş bırakamazsınız");

            RuleFor(x => x.YayınEvi)
                .NotEmpty().WithMessage("Yayınevi kısmını boş bırakamazsınız");

            RuleFor(x => x.Sayfa)
                .NotEmpty().WithMessage("Sayfa kısmını boş bırakamazsınız");
        }
    }
}
