using Example.API.DTO;
using FastEndpoints;
using FluentValidation;

namespace Example.API.Validators;

public class UserRegisterValidator : Validator<UserRegisterRequest>
{
    public UserRegisterValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .WithMessage("Your first name is required in order to be registered")
            .MinimumLength(3)
            .WithMessage("Your first name is too short")
            .MaximumLength(20)
            .WithMessage("Your first name is too long");
        
        RuleFor(x => x.LastName)
            .NotEmpty()
            .WithMessage("Your last name is required in order to be registered")
            .MinimumLength(5)
            .WithMessage("Your last name is too short")
            .MaximumLength(20)
            .WithMessage("Your last name is too long");

        RuleFor(x => x.Pesel)
            .Length(11)
            .WithMessage("Your pesel should be of lenght equal to 11");
    }
}