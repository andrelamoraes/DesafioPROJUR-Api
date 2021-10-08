
using FluentValidation;
using Usuarios.Domain.Entities;

namespace Usuarios.Domain.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Nome é inválido")
                .NotNull().WithMessage("Nome precisa ser preenchido.");

            RuleFor(c => c.Sobrenome)
                .NotEmpty().WithMessage("Sobrenome é inválido")
                .NotNull().WithMessage("Sobrenome precisa ser preenchido.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Email é inválido")
                .NotNull().WithMessage("Email precisa ser preenchido.");

            RuleFor(c => c.DataNascimento)
                .NotEmpty().WithMessage("DataNascimento é inválida")
                .NotNull().WithMessage("DataNascimento precisa ser preenchida.");

            RuleFor(c => c.Escolaridade)
                .NotEmpty().WithMessage("Escolaridade é inválida")
                .NotNull().WithMessage("Escolaridade precisa ser preenchida.");
        }
    }
}
