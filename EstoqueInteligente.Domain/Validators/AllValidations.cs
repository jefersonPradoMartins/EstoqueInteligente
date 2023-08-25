using EstoqueInteligente.Domain.Entities;
using FluentValidation;

namespace EstoqueInteligente.Domain.Validators
{
    public class AllValidations
    {
        public class ProdutoForumaValidator : AbstractValidator<ProdutoFormula>
        {

            public ProdutoForumaValidator()
            {
                RuleFor(x => x).NotEmpty().WithMessage("A entidade não pode ser vazia.");
                RuleFor(x => x).NotNull().WithMessage("A entidade não pode ser nula.");

                RuleFor(x => x.NomeFormula).NotEmpty().WithMessage("A nome da formula não pode ser vazia.");
                RuleFor(x => x.NomeFormula).NotNull().WithMessage("A nome da formula não pode ser nula.");
            }
        }

        public class SubstanciaValidator : AbstractValidator<Substancia>
        {
            public SubstanciaValidator()
            {
                RuleFor(x => x).NotEmpty().WithMessage("A entidade não pode ser vazia.");
                RuleFor(x => x).NotNull().WithMessage("A entidade não pode ser nula.");

                RuleFor(x => x.NomeSubstancia).NotEmpty().WithMessage("O nome da substancia não pode ser vazia.");
                RuleFor(x => x.NomeSubstancia).NotNull().WithMessage("O nome da substancia não pode ser nula.");
                RuleFor(x => x.NomeSubstancia).MaximumLength(450).WithMessage("O nome da substancia deve ter no máximo 450 caracteres.");
            }
        }

    }
}
