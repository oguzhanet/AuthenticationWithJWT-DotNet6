using AuthServer.Core.DTOs;
using FluentValidation;

namespace AuthServer.API.Validations
{
    public class UserAppDtoValidator:AbstractValidator<UserAppDto>
    {
        public UserAppDtoValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x=>x.UserName)
                .NotEmpty();

            RuleFor(x => x.City)
                .NotEmpty();
        }
    }
}
