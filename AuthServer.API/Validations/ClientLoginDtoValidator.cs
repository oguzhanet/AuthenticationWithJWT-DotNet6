using AuthServer.Core.DTOs;
using FluentValidation;

namespace AuthServer.API.Validations
{
    public class ClientLoginDtoValidator:AbstractValidator<ClientLoginDto>
    {
        public ClientLoginDtoValidator()
        {
            RuleFor(x => x.ClientId)
                .NotEmpty();

            RuleFor(x => x.ClientSecret)
                .NotEmpty();
        }
    }
}
