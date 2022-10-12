using Mynda.API.CustomMiddleware;
using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Mynda.API.Exceptions;
using Logger = Serilog.ILogger;
using KeyNotFoundException = Mynda.API.Exceptions.KeyNotFoundException;
using NotImplementedException = Mynda.API.Exceptions.NotImplementedException;


namespace Mynda.API.CustomMiddleware
{
    public class GlobalMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly Logger _logger;
        private readonly IHostEnvironment _env;

        public GlobalMiddleware(RequestDelegate next, IHostEnvironment env)
        {
            _next = next;
            _env = env;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.Information(ex.Message);
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = 500;
                var response = new ProblemDetails
                {
                    Status = 500, 
                    Detail = _env.IsDevelopment() ? ex.StackTrace?.ToString() : null,
                    Title = ex.Message
                };
                var options = new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase};
                var json = JsonSerializer.Serialize(response, options);
               await httpContext.Response.WriteAsync(json);
            }
        }

        private static Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            HttpStatusCode status;
            var stackTrace = String.Empty;
            string message;
            var exceptionType = exception.GetType();
            if (exceptionType == typeof(BadRequestException))
            {
                message = exception.Message;
                status = HttpStatusCode.BadRequest;
                stackTrace = exception.StackTrace;
            } else if (exceptionType == typeof(NotFoundException))
            {
                message = exception.Message;
                status = HttpStatusCode.NotFound;
                stackTrace = exception.StackTrace;
            } else if (exceptionType == typeof(NotImplementedException))
            {
                message = exception.Message;
                status = HttpStatusCode.NotImplemented;
                stackTrace = exception.StackTrace;
            } else if (exceptionType == typeof(KeyNotFoundException))
            {
                message = exception.Message;
                status = HttpStatusCode.Unauthorized;
                stackTrace = exception.StackTrace;
            }
            else
            {
                message = exception.Message;
                status = HttpStatusCode.InternalServerError;
                stackTrace = exception.StackTrace;
            }

            var exceptionResult = JsonSerializer.Serialize(new
            {
                error = message, stackTrace
            });
            
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)status;
            return httpContext.Response.WriteAsync(exceptionResult);

        }
    }
}


