namespace Domain.Validator;
using System;
using Domain.User;
using Domain.Util;
using FluentValidation;
using FluentValidation.Results;


// All the buss logic on the Domain as specified in the DDD docs, easier to maintain and test
public class UserValidator : AbstractValidator<APIUser>
{
    public APIResponse ValidateNewUser(APIUser user)
    {
        RuleFor(APIUser => APIUser.FirstName)
            .NotNull()
            .Length(2, 250);

        RuleFor(APIUser => APIUser.LastName)
            .Length(2, 250);

        RuleFor(APIUser => APIUser.Email)
            .NotNull()
            .EmailAddress();

        // Regex validates a 10 digit phone number, in different formats; + or ( 2 digits ) or 3 digits - 4-6 digits, 
        // +48, (48) + 9 digits 
        // +47-12345678
        // (47)-1234-5678
        // (country code - 2 digits)-(eight other digits)

        RuleFor(APIUser => APIUser.PhoneNumber)
            .NotNull()
            .Matches("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");

        return CheckResult(user);
    }

    public APIResponse ValidateUserUpdate(APIUser user)
    {
        RuleFor(APIUser => APIUser.Id)
            .NotNull();

        RuleFor(APIUser => APIUser.FirstName)
            .Length(2, 250);

        RuleFor(APIUser => APIUser.LastName)
            .Length(2, 250);

        RuleFor(APIUser => APIUser.Email)
            .EmailAddress();

        // Regex validates a 10 digit phone number, in different formats; + or ( 2 digits ) or 3 digits - 4-6 digits, 
        RuleFor(APIUser => APIUser.PhoneNumber)
            .Matches("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");


        return CheckResult(user);
    }

    public APIResponse ValidateDelete(APIUser user)
    {
        RuleFor(APIUser => APIUser.Id)
            .NotNull();

        return CheckResult(user);
    }

    public APIResponse CheckResult(APIUser user)
    {
        ValidationResult result = this.Validate(user);

        if (!result.IsValid)
        {
            string missingFields = Util.GetErrors(result.Errors);
            return new APIResponse(missingFields, HTTP_STATUS.BAD_REQUEST);
        }

        return new APIResponse("Completed", HTTP_STATUS.OK);
    }
}
