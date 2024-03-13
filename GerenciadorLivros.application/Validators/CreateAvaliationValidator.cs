using FluentValidation;
using GerenciadorLivros.application.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.application.Validators
{
    public class CreateAvaliationValidator : AbstractValidator<NewAvaliationInputModel>
    {
        public CreateAvaliationValidator()
        {
            RuleFor(b=>b.Rating).GreaterThanOrEqualTo(1).WithMessage("Rating must be a number between 1 and 5").LessThanOrEqualTo(5).WithMessage("Rating must be a number between 1 and 5");
            RuleFor(b => b.StartedDate).LessThanOrEqualTo(b => b.FinishedDate).WithMessage("Starting Date cant be after finished Date");
        }
    }
}
