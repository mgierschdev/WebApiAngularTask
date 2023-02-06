namespace Domain.Validator;
using System;
using Domain.User;
using Domain.Util;
using FluentValidation;
using FluentValidation.Results;


// All the buss logic on the Domain as specified in the DDD docs, easier to maintain and test
public class UserValidator : AbstractValidator<APIUser>
{
    public UserValidator()
    {
        RuleFor(APIUser => APIUser.FirstName).NotNull();
        RuleFor(APIUser => APIUser.Email).NotNull();
        RuleFor(APIUser => APIUser.PhoneNumber).NotNull();
    }

    public APIResponse ValidateNewUser(APIUser user)
    {
        ValidationResult result = this.Validate(user);

        if (!result.IsValid)
        {
            string missingFields = Util.GetErrors(result.Errors);
            return new APIResponse("Missing "+ missingFields, HTTP_STATUS.BAD_REQUEST);
        }

        return new APIResponse("Completed", HTTP_STATUS.OK);
    } 
}
