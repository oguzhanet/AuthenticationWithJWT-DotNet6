using AuthServer.Core.DTOs;
using FluentValidation;

namespace AuthServer.API.Validations
{
    public class ClientTokenDtoValidator:AbstractValidator<ClientTokenDto>
    {
        public ClientTokenDtoValidator()
        {
            RuleFor(x => x.AccessToken)
                .NotEmpty();
        }
    }
}
