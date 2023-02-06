using System;
using FluentValidation.Results;

namespace Domain.Util
{
	public static class Util
	{

		public static string GetErrors(List<ValidationFailure> errors)
		{
			string result = "";
			foreach(ValidationFailure validationFailure in errors)
			{
				result += validationFailure.PropertyName + " ";
			}

			return result;
		}
	}
}

