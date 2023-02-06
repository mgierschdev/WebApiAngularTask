namespace Domain.Validator;
using System;
using API.Domain.User;
using FluentValidation;


// All the buss logic on the Domain as specified in the DDD docs, easier to maintain and test

public class UserValidator : AbstractValidator<APIUser>
{
    public UserValidator()
    {
        RuleFor(APIUser => APIUser.FirstName).NotNull();
        RuleFor(APIUser => APIUser.Email).NotNull();
        RuleFor(APIUser => APIUser.PhoneNumber).NotNull();
    }
}
