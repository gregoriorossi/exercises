﻿using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace GlobalErrorHandling.ExceptionHandlers
{
    internal sealed class GlobalExceptionHandler(
        ILogger<GlobalExceptionHandler> logger,
        IProblemDetailsService problemDetailsService) : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(
            HttpContext context, 
            Exception exception, 
            CancellationToken cancellationToken)
        {
            
            logger.LogError(exception, "Unahndled exception occurred");

            context.Response.StatusCode = exception switch
            {
                ApplicationException => StatusCodes.Status400BadRequest,
                _ => StatusCodes.Status500InternalServerError
            };

            return await problemDetailsService.TryWriteAsync(
                new ProblemDetailsContext
                {
                    HttpContext = context,
                    Exception = exception,
                    ProblemDetails = new ProblemDetails
                    {
                        Type = exception.GetType().Name,
                        Title = "An error occurred",
                        Detail = exception.Message,
                    }
                }
            );
        }
    }
}
