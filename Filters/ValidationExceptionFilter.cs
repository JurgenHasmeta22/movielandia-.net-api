using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using movielandia_.net_api.DTOs.Responses;

namespace movielandia_.net_api.Filters
{
    public class ValidationExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is ValidationException validationException)
            {
                var errorResponse = new ErrorResponse(
                    "https://tools.ietf.org/html/rfc7231#section-6.5.1",
                    "One or more validation errors occurred.",
                    StatusCodes.Status400BadRequest
                );

                foreach (var error in validationException.Errors)
                {
                    errorResponse.AddError(error.PropertyName, error.ErrorMessage);
                }

                context.Result = new BadRequestObjectResult(errorResponse);
                context.ExceptionHandled = true;
            }
        }
    }
}
