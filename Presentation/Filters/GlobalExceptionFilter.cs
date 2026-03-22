using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using movielandia_.net_api.Application.Common.Exceptions;

namespace movielandia_.net_api.Presentation.Filters;

/// <summary>
/// Converts well-known application exceptions into structured HTTP responses.
/// Keeps try/catch blocks out of every controller action.
/// </summary>
public sealed class GlobalExceptionFilter : IExceptionFilter
{
    private readonly ILogger<GlobalExceptionFilter> _logger;

    public GlobalExceptionFilter(ILogger<GlobalExceptionFilter> logger)
        => _logger = logger;

    public void OnException(ExceptionContext context)
    {
        switch (context.Exception)
        {
            case ValidationException ve:
                HandleValidation(context, ve);
                break;

            case NotFoundException nfe:
                HandleNotFound(context, nfe);
                break;

            case ConflictException ce:
                HandleConflict(context, ce);
                break;

            default:
                HandleUnknown(context);
                break;
        }
    }

    private static void HandleValidation(ExceptionContext context, ValidationException ex)
    {
        var errors = ex.Errors
            .GroupBy(e => e.PropertyName)
            .ToDictionary(
                g => g.Key,
                g => g.Select(e => e.ErrorMessage).ToArray());

        context.Result = new BadRequestObjectResult(new ValidationProblemDetails(errors)
        {
            Title = "One or more validation errors occurred.",
            Status = StatusCodes.Status400BadRequest,
        });

        context.ExceptionHandled = true;
    }

    private static void HandleNotFound(ExceptionContext context, NotFoundException ex)
    {
        context.Result = new NotFoundObjectResult(new ProblemDetails
        {
            Title = "Resource not found.",
            Detail = ex.Message,
            Status = StatusCodes.Status404NotFound,
        });

        context.ExceptionHandled = true;
    }

    private static void HandleConflict(ExceptionContext context, ConflictException ex)
    {
        context.Result = new ConflictObjectResult(new ProblemDetails
        {
            Title = "Conflict.",
            Detail = ex.Message,
            Status = StatusCodes.Status409Conflict,
        });

        context.ExceptionHandled = true;
    }

    private void HandleUnknown(ExceptionContext context)
    {
        _logger.LogError(context.Exception, "Unhandled exception");

        context.Result = new ObjectResult(new ProblemDetails
        {
            Title = "An unexpected error occurred.",
            Status = StatusCodes.Status500InternalServerError,
        })
        { StatusCode = StatusCodes.Status500InternalServerError };

        context.ExceptionHandled = true;
    }
}
